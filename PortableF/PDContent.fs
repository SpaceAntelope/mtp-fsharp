namespace PortableDevices

open PortableDeviceApiLib
open PortableDevices.PDGlobalTypes
open PDUtils

module PDContent = 
    type PortableFileInfo = 
        { SupportedProperties : SupportedProperties
          ParentDirectoryID : string }
    
    and PortableDirectoryInfo = 
        { SupportedProperties : SupportedProperties
          ParentDirectoryID : string
          Files : seq<PortableContentInfo> }
    
    and PortableContentInfo = 
        | FileInfo of PortableFileInfo
        | DirectoryInfo of PortableDirectoryInfo
    
    let rec ListContentInfo (content : IPortableDeviceContent) (parentID : string) (listSubdirectories : bool) = 
        seq { 
            let properties = content.Properties()
            let objects = content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    let objectContentType = 
                        properties.GetValues(!objID, null).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
                    match objectContentType with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true when listSubdirectories = true -> 
                        yield DirectoryInfo { SupportedProperties = (enumerateSupportedProperties properties !objID)
                                              ParentDirectoryID = parentID
                                              Files = (ListContentInfo content !objID listSubdirectories) }
                    | _ -> 
                        yield FileInfo { SupportedProperties = (enumerateSupportedProperties properties !objID)
                                         ParentDirectoryID = parentID }
        }
    
    module Format = 
        let PFItoCSV(input : seq<SupportedProperties>) = 
            seq { 
                yield input
                      |> Seq.map (fun (SupportedProperties pfi) -> pfi)
                      |> (Seq.nth 0)
                      |> Seq.map (fun item -> item.Name)
                for (SupportedProperties info) in input do
                    yield info |> Seq.map (fun item -> item.Value)
            }
        
        let ParseGuids(input : seq<string>) = 
            input |> Seq.map (fun item -> 
                         let m = 
                             System.Text.RegularExpressions.Regex.Match
                                 (item, "[A-Fa-f0-9]{8}\-([A-Fa-f0-9]{4}\-){3}[A-Fa-f0-9]{12}")
                         match (m.Success) with
                         | true -> PDHeaderUtils.GetGuidName(System.Guid.Parse(m.Value))
                         | _ -> item)
        
        let TabJoin list = Seq.reduce (fun state item -> sprintf "%s,%s" state item) list

        let rec FlattenDirectoryTree (node : PortableContentInfo) =
            seq {
                match node with
                | FileInfo content -> yield content.SupportedProperties
                | DirectoryInfo content -> 
                    yield content.SupportedProperties
                    yield! content.Files |> Seq.collect FlattenDirectoryTree
            }

