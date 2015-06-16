open System.Text.RegularExpressions
open System.IO

type PropertyInfo = 
    { name : string
      guid : string
      pv : string }

type PropertyRecord = 
    { comments : string
      propInfo : PropertyInfo }

type ParsedLine = 
    | Line of string
    | Comment of string
    | Info of PropertyInfo

let (|CommentLine|GuidDefinition|PropertyDefinition|Other|) (line : string) = 
    match line with
    | ln when Regex.Match(line, "^\s*[/|\*]+").Success = true -> CommentLine(Comment ln)
    | ln when line.StartsWith("DEFINE_GUID") = true -> 
        let lineParts = ln.Replace(",", "").Replace(" );", "").Substring(12).Trim().Split(' ')
        GuidDefinition(Info { name = lineParts.[0]
                              guid = System.String.Join(" ", (lineParts.[1..(lineParts.Length - 1)]))
                              pv = "" })
    | ln when line.StartsWith("DEFINE_PROPERTYKEY") = true -> 
        let lineParts = line.Replace(",", "").Replace(" );", "").Substring(20).Split(' ')
        PropertyDefinition(Info { name = lineParts.[0]
                                  guid = System.String.Join(" ", (lineParts.[1..(lineParts.Length - 2)]))
                                  pv = lineParts.[lineParts.Length - 1] })
    | ln -> Other(Line ln)

let rec parseHeader (commentStack : string) (lines : string []) (index : int) = 
    seq { 
        if lines.Length > index then 
            match lines.[index] with
            | CommentLine(Comment ln) -> yield! parseHeader (sprintf "%s\n%s" commentStack ln) lines (index + 1)
            | GuidDefinition(Info ln) -> 
                yield { comments = commentStack
                        propInfo = ln }
                yield! parseHeader "" lines (index + 1)
            | PropertyDefinition(Info ln) -> 
                yield { comments = commentStack
                        propInfo = ln }
                yield! parseHeader "" lines (index + 1)
            | _ -> yield! parseHeader "" lines (index + 1)
    }

let result = parseHeader "" (File.ReadAllLines "c:\Program Files (x86)\Windows Kits\8.1\Include\um\PortableDevice.h") 0
let totalLength = Seq.length result

let commentCnt = 
    result
    |> Seq.filter (fun item -> item.comments.Length > 0)
    |> Seq.length

let guidCnt = 
    result
    |> Seq.filter (fun item -> item.propInfo.pv = "")
    |> Seq.length

let propCnt = 
    result
    |> Seq.filter (fun item -> item.propInfo.pv <> "")
    |> Seq.length

let names = 
    result
    |> Seq.sortBy (fun item -> item.propInfo.name)
    |> Seq.iter (fun item -> printfn "%s" item.propInfo.name)
