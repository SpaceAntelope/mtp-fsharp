open System.Text.RegularExpressions
open System.IO

type PropertyInfo = 
    { name : string
      guid : string
      pv : string }

type PDHeaderNode = 
    { comments : string
      propInfo : PropertyInfo
      parentCategory : Option<PropertyInfo> }

//type PropertyInfoView = 
//    { name : string
//      propertyID : System.Guid
//      propVariant : uint32
//      categoryID : option<System.Guid>
//      comments : string
//      propertyType : string }
type ParsedLine = 
    | Line of string
    | Comment of string
    | Data of PropertyInfo

let (|SplitDataLine|) (line : string) = 
    SplitDataLine(line.Substring(line.IndexOf("(") + 1).Replace(",", "").Replace(");", "").Trim().Split(' '))

let (|MatchComments|) (line : string) = 
    match Regex.Match(line, "^\s*[/|\*]+").Success with
    | true -> Some line
    | _ -> None

let (|MatchGuid|) (line : string) = 
    match line.StartsWith("DEFINE_GUID") with
    | true -> Some line
    | _ -> None

let (|MatchPropKey|) (line : string) = 
    match line.StartsWith("DEFINE_PROPERTYKEY") with
    | true -> Some line
    | _ -> None

let (|CommentLine|GuidDefinition|PropertyDefinition|Other|) (line : string) = 
    match line with
    | MatchComments(Some ln) -> CommentLine(Comment ln)
    | MatchGuid(Some ln) -> 
        match ln with
        | SplitDataLine parts -> 
            GuidDefinition(Data { name = parts.[0]
                                  guid = System.String.Join(" ", (parts.[1..(parts.Length - 1)])).Trim()
                                  pv = "" })
    | MatchPropKey(Some ln) -> 
        match ln with
        | SplitDataLine parts -> 
            PropertyDefinition(Data { name = parts.[0]
                                      guid = System.String.Join(" ", (parts.[1..(parts.Length - 2)])).Trim()
                                      pv = parts.[parts.Length - 1] })
    | ln -> Other(Line ln)

let WpdObjectPropertiesV1 = 
    { name = "WPD_OBJECT_PROPERTIES_V1"
      guid = "0xEF6B490D 0x5CD8 0x437A 0xAF 0xFC 0xDA 0x8B 0x60 0xEE 0x4A 0x3C"
      pv = "" }

let rec parseHeader (commentStack : string) (lastGuid : Option<PropertyInfo>) (lines : string []) (index : int) = 
    seq { 
        if lines.Length > index then 
            match lines.[index] with
            | CommentLine(Comment line) -> 
                yield! parseHeader (sprintf "%s\n%s" commentStack line) lastGuid lines (index + 1)
            | GuidDefinition(Data propInfo) -> 
                yield { comments = commentStack
                        propInfo = propInfo
                        parentCategory = None }
                yield! parseHeader "" (Some propInfo) lines (index + 1)
            | PropertyDefinition(Data propInfo) when propInfo.guid.ToString() = WpdObjectPropertiesV1.guid -> 
                yield { comments = commentStack
                        propInfo = propInfo
                        parentCategory = Some WpdObjectPropertiesV1 }
                yield! parseHeader "" lastGuid lines (index + 1)
            | PropertyDefinition(Data propInfo) when lastGuid.IsSome && propInfo.guid = lastGuid.Value.guid -> 
                yield { comments = commentStack
                        propInfo = propInfo
                        parentCategory = lastGuid }
                yield! parseHeader "" lastGuid lines (index + 1)
            | PropertyDefinition(Data propInfo) when lastGuid.IsNone || propInfo.guid <> lastGuid.Value.guid -> 
                let fauxCat = 
                    { name = propInfo.name + "_Guid"
                      guid = propInfo.guid
                      pv = "" }
                yield { comments = sprintf "/// Category placeholder for %s" propInfo.name
                        propInfo = fauxCat
                        parentCategory = None }
                yield { comments = commentStack
                        propInfo = propInfo
                        parentCategory = Some fauxCat }
                yield! parseHeader "" lastGuid lines (index + 1)
            | _ -> yield! parseHeader "" lastGuid lines (index + 1)
    }

let result = 
    parseHeader "" None (File.ReadAllLines "c:\Program Files (x86)\Windows Kits\8.1\Include\um\PortableDevice.h") 0

let ToGuid str = 
    let arr = 
        System.Text.RegularExpressions.Regex.Split(str, "[^0-9A-Fx]+")
        |> Array.filter (fun part -> part.Length > 0 && part <> "0x")
        |> Array.map (fun part -> 
               try 
                   (System.Convert.ToUInt32(part, 16))
               with ex -> 
                   printfn "fail: %s" part
                   System.Console.ReadLine() |> ignore
                   0u)
    new System.Guid(uint32 arr.[0], uint16 arr.[1], uint16 arr.[2], byte arr.[3], byte arr.[4], byte arr.[5], 
                    byte arr.[5], byte arr.[7], byte arr.[8], byte arr.[9], byte arr.[10])

type PropertyInfoView = 
    { name : string
      propertyID : System.Guid
      propVariant : uint32
      categoryID : option<System.Guid>
      comments : string
      propertyType : option<string> }

let extractPropertyType (comment : string) = 
    let m = System.Text.RegularExpressions.Regex.Match(comment, "\[ VT_[^\]]+\]")
    match (m.Success) with
    | true -> Some m.Value
    | _ -> None

let propertyInfoTable = 
    result |> Seq.map (fun item -> 
                  printfn "%s %A" item.propInfo.guid item.parentCategory
                  { name = item.propInfo.name
                    propertyID = ToGuid(item.propInfo.guid)
                    propVariant = snd (System.UInt32.TryParse(item.propInfo.pv))
                    categoryID = 
                        match (item.parentCategory) with
                        | Some cat -> Some(ToGuid cat.guid)
                        | None -> None
                    comments = item.comments
                    propertyType = extractPropertyType (item.comments) })

propertyInfoTable |> Seq.iter (printfn "%A")

let typeIndex = 
    result
    |> Seq.map (fun item -> 
           let m = System.Text.RegularExpressions.Regex.Match(item.comments, "\[ VT_[^\]]+\]")
           match (m.Success) with
           | true -> (item.propInfo.name, m.Value)
           | _ -> (item.propInfo.name, "??"))
    |> dict

//|> Seq.iter (printfn "%A")
let names = 
    fun () -> 
        result |> Seq.iter (fun item -> 
                      match (item.parentCategory) with
                      | Some cat -> printfn "\t%s (%s - %s)" item.propInfo.name cat.name cat.guid
                      | None -> printfn "%s" item.propInfo.name)

let ToGuidDeclaration(node : PDHeaderNode) = 
    let arr = 
        System.Text.RegularExpressions.Regex.Split(node.propInfo.guid, "[^0-9A-Fa-zx]+") 
        |> Array.filter (fun part -> part.Length > 0)
    sprintf "let %s = new System.Guid(%su, %sus, %sus, %suy, %suy, %suy, %suy, %suy, %suy, %suy, %suy)" 
        node.propInfo.name arr.[0] arr.[1] arr.[2] arr.[3] arr.[4] arr.[5] arr.[6] arr.[7] arr.[8] arr.[9] arr.[10]

let ToTagPropertyDeclaration(node : PDHeaderNode) = 
    match node.parentCategory with
    | Some cat -> 
        sprintf "let %s = new PortableDeviceApiLib._tagpropertykey(fmtid = %s, pid = %su)" node.propInfo.name cat.name 
            node.propInfo.pv
    | None -> ""

let ToFSComment(str : string) = 
    let txt = str.Replace("*/", "*").Replace("\n", "\r\n").Trim()
    let txt' = System.Text.RegularExpressions.Regex.Replace(txt, "/?\*+", "///", RegexOptions.Multiline)
    let txt'' = System.Text.RegularExpressions.Regex.Replace(txt', "^//", "///", RegexOptions.Multiline)
    System.Text.RegularExpressions.Regex.Replace(txt'', "^ \*", "///*", RegexOptions.Multiline)

let text = 
    result 
    |> Seq.map (fun propRec -> 
           match propRec.parentCategory with
           | None -> sprintf "%s\r\n    %s" (ToFSComment propRec.comments) (ToGuidDeclaration propRec)
           | Some propInfo -> sprintf "%s\r\n    %s" (ToFSComment propRec.comments) (ToTagPropertyDeclaration propRec))

let text' = 
    result
    |> Seq.filter (fun propRec -> 
           match propRec.parentCategory with
           | None -> false
           | Some pi -> true)
    |> Seq.groupBy (fun propRec -> propRec.parentCategory.Value.name)
    |> Seq.collect (fun (key, values) -> 
           let seq1 = 
               seq { 
                   yield sprintf "        | MatchGuids %s true ->" key
                   yield sprintf "             let guidName = \"%s\"" key
                   yield sprintf "             match pv with"
               }
           
           let seq2 = 
               values
               |> Seq.sortBy (fun propRec -> snd (System.UInt32.TryParse(propRec.propInfo.pv)))
               |> Seq.map 
                      (fun propRec -> 
                      sprintf "             | %su -> (guidName,\"%s\")" propRec.propInfo.pv propRec.propInfo.name)
           
           let seq3 = seq { yield sprintf "             | _ -> (guidName,\"Unknown Property\")" }
           seq { 
               yield! seq1
               yield! seq2
               yield! seq3
           })

let categoriesWithProperties = 
    result
    |> Seq.choose (fun item -> item.parentCategory)
    |> Seq.map (fun item -> item.name)
    |> Seq.distinct
    |> Seq.reduce (sprintf "%s %s")

let guidsWithoutProperties = 
    result
    |> Seq.filter (fun item -> item.parentCategory.IsNone)
    |> Seq.where (fun item -> categoriesWithProperties.Contains(item.propInfo.name) = false)

let text'' = 
    guidsWithoutProperties 
    |> Seq.map 
           (fun item -> 
           sprintf "        | MatchGuids %s true -> (\"%s\", \"No Properties\")" item.propInfo.name item.propInfo.name)

let matchCategoriesWithProperties = 
    result
    |> Seq.filter (fun propRec -> propRec.parentCategory.IsSome)
    |> Seq.map (fun propRec -> propRec.parentCategory.Value.name, propRec.propInfo.pv)
    |> Seq.groupBy (fun (name, propVar) -> name)
    |> Seq.map (fun (name, props) -> 
           let propStr = 
               props
               |> Seq.map snd
               |> Seq.reduce (fun state pv -> sprintf "%su; %s" state pv)
           sprintf "        | MatchGuids %s true -> [|%su|]" name propStr)

System.IO.File.WriteAllLines
    ("C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\PDHeader.fs", 
     (Seq.append [| "namespace PortableDevices"; "module PDHeader =" |] text))
System.IO.File.WriteAllLines
    ("C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\PDHeaderUtils.fs", 
     (Seq.append 
          [| "namespace PortableDevices"; "module PDHeaderUtils ="; "    open PortableDevices.PDHeader"; 
             "    let (|MatchGuids|) (guid1 : System.Guid) (guid2 : System.Guid ) = guid1.CompareTo(guid2) = 0\r\n"; 
             "    let GetPropertyName guid pv ="; "        match guid with" |] text'))
System.IO.File.AppendAllLines
    ("C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\PDHeaderUtils.fs", text'')
System.IO.File.AppendAllLines
    ("C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\PDHeaderUtils.fs", 
     [| "        | _ -> (\"Uknown Category\",\"\")"; "" |])
System.IO.File.AppendAllLines("C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\PDHeaderUtils.fs", 
                              [| ""
                                 "    let GetPropertiesFromCategory guid ="
                                 "        match guid with"
                                 (matchCategoriesWithProperties |> Seq.reduce (sprintf "%s\r\n%s"))
                                 "        | _ -> [||]" |])
