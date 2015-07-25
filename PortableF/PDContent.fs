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
    
    
    let rec ListNodeIDs (device : ConnectedDevice) (parentID : string) (listSubdirectories : bool) = 
        seq { 
            let objects = device.Content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    let objectContentType = device.Properties.GetValues(!objID, null).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
                    match objectContentType with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true when listSubdirectories = true -> 
                        yield FolderID !objID
                        yield! ListNodeIDs device !objID listSubdirectories
                    | _ -> yield ObjectID !objID
        }
    
    let rec ListNodeIDs' (content : IPortableDeviceContent) (parentID : string) (listSubdirectories : bool) (f : PortableContentID -> 'a) = 
        seq { 
            let properties = content.Properties()
            let objects = content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    let objectContentType = properties.GetValues(!objID, null).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
                    match objectContentType with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true when listSubdirectories = true ->                         
                        yield f (FolderID !objID)
                        yield! (ListNodeIDs' content !objID listSubdirectories f)
                    | _ -> yield f (ObjectID !objID)
        }
    
    //    let ListContentInfo' (content : IPortableDeviceContent) (parentID : string) (listSubdirectories : bool) = 
    //        seq {
    //            ListNodeIDs' content parentID listSubdirectories (fun nodeID-> 
    //                match nodeID with
    //                | FolderID objID when listSubdirectories = true ->  yield DirectoryInfo { SupportedProperties = (enumerateSupportedProperties properties objID)
    //                                              ParentDirectoryID = parentID
    //                                              Files = (ListContentInfo content !objID listSubdirectories) }
    //                | ObjectID objID -> 
    //                        yield FileInfo { SupportedProperties = (enumerateSupportedProperties properties objID)
    //                                         ParentDirectoryID = parentID }
    //        )}
    let rec ListContentInfo  (device:ConnectedDevice)  (parentID : string) (listSubdirectories : bool) = 
        seq { 
            let objects = device.Content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    let objectContentType = device.Properties.GetValues(!objID, null).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
                    match objectContentType with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true when listSubdirectories = true -> 
                        yield DirectoryInfo { SupportedProperties = (enumerateSupportedProperties device !objID)
                                              ParentDirectoryID = parentID
                                              Files = (ListContentInfo device !objID listSubdirectories) }
                    | _ -> 
                        yield FileInfo { SupportedProperties = (enumerateSupportedProperties device !objID)
                                         ParentDirectoryID = parentID }
        }

    module Utils =
        open System.IO
    
        let GetFile (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) (FilePath targetPath) = 
            let STGM_READ = 0x00000000u
            let (PropertyValue sourceFileName) = readObjectProperty device fileID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
            let (PropertyValueUInt64 uFileSize) = readObjectPropertyByType device fileID PDHeader.WPD_OBJECT_SIZE
            let fileSize = int64 uFileSize
            let optimalTransferSizeUint = ref (uint32 0)
            let sourceStream = device.Resources.GetStream(fileID, ref PDHeader.WPD_RESOURCE_DEFAULT, STGM_READ, optimalTransferSizeUint) :?> System.Runtime.InteropServices.ComTypes.IStream
            let optimalTransferSize = int !optimalTransferSizeUint
            let targetStream = new FileStream(System.IO.Path.Combine(targetPath, sourceFileName), FileMode.Create, FileAccess.Write)
            let transferBuffer = Array.zeroCreate optimalTransferSize
            let mutable bytesRead = 0 // Never gets updated
            while targetStream.Length < fileSize do
                sourceStream.Read(transferBuffer, optimalTransferSize, nativeint bytesRead)
                let copyLength = System.Math.Min(int64 optimalTransferSize, fileSize - targetStream.Length)
                targetStream.Write(transferBuffer, 0, int copyLength)
            targetStream.Close()
    
        let DeleteFile (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) = 
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            let WPD_OBJECT_ID = ref (new PortableDeviceApiLib._tagpropertykey(fmtid = PDHeader.WPD_OBJECT_ID.fmtid, pid = PDHeader.WPD_OBJECT_ID.pid))
            values.SetStringValue(WPD_OBJECT_ID, fileID)
            let propVariant = values.GetValue(WPD_OBJECT_ID)
            let objectIds = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
            objectIds.Add(ref propVariant)
            let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
            device.Content.Delete(0u, objectIds, result)
            result    
    
        let PortableFileRequiredValues (device : ConnectedDevice) (source : FileInfo) (FolderID parentID) =
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_PARENT_ID, parentID)
            values.SetUnsignedLargeIntegerValue(ref PDHeader.WPD_OBJECT_SIZE, uint64 source.Length)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, source.Name)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, Path.GetFileNameWithoutExtension(source.Name))
            values

        let StrCopy optimalTransferSize (sourceStream:FileStream) (targetStream: System.Runtime.InteropServices.ComTypes.IStream) =
            let transferBuffer = Array.zeroCreate optimalTransferSize
            let mutable bytesToRead = optimalTransferSize
            let mutable totalBytesRead = 0;
               
            while totalBytesRead < (int sourceStream.Length) do                
                let bytesRead = sourceStream.Read(transferBuffer, 0, bytesToRead)
                targetStream.Write(transferBuffer, bytesRead, System.IntPtr.Zero)          
                totalBytesRead <- totalBytesRead + bytesRead                
            sourceStream.Close()

        let SendFile (device : ConnectedDevice) (FolderID targetFolderID) (source : FileInfo) =
            let values = PortableFileRequiredValues device source (FolderID targetFolderID)            
            let sourceStream = source.OpenRead()
            let mutable targetStream = (( new PDInterfaceInstanceProvider.DummyStreamType()) :> IStream)
            let optimalTransferSizeUint = ref (uint32 0)
            device.Content.CreateObjectWithPropertiesAndData(values, &targetStream, optimalTransferSizeUint, ref null)

            let comStream = targetStream :?> (System.Runtime.InteropServices.ComTypes.IStream)
            StrCopy (int !optimalTransferSizeUint) sourceStream comStream 
            targetStream.Commit(0u)

    module Format = 
        type CsvContent = 
            | CsvHeader of seq<PropertyName>
            | CsvLine of seq<PropertyValue>
        
        let SupportedTypes (properties : IPortableDeviceProperties) (objectID : string) = 
            properties.GetSupportedProperties(objectID)
            |> enumerateKeyCollection
            |> Seq.map (PDHeaderUtils.GetPropertyType)
        
        let PFItoCSV(input : seq<SupportedProperties>) = 
            seq { 
                yield input
                      |> Seq.map (fun (SupportedProperties pfi) -> pfi)
                      |> Seq.head
                      |> Seq.map (fun item -> item.PropertyName)
                      |> CsvHeader
                for (SupportedProperties info) in input do
                    yield info
                          |> Seq.map (fun { PropertyName = _; Value = value } -> value)
                          |> CsvLine
            }
        
        let ParseGuids(input : CsvContent) = 
            match input with
            | CsvHeader _ -> input
            | CsvLine values -> 
                values
                |> Seq.map (fun (PropertyValueString item) -> 
                       let m = System.Text.RegularExpressions.Regex.Match(item, "[A-Fa-f0-9]{8}\-([A-Fa-f0-9]{4}\-){3}[A-Fa-f0-9]{12}")
                       match (m.Success) with
                       | true -> PropertyValueString(PDHeaderUtils.GetGuidName(System.Guid.Parse(m.Value)))
                       | _ -> PropertyValueString item)
                |> CsvLine
        
        let UnbindCsvContent(input : CsvContent) = 
            match input with
            | CsvHeader headers -> Seq.map (fun (PropertyName header) -> header) headers
            | CsvLine fields -> Seq.map (fun (PropertyValueString field) -> field) fields
        
        let Join separator list = Seq.reduce (fun state item -> sprintf "%s%s%s" state separator item) list
        
        let rec FlattenDirectoryTree(node : PortableContentInfo) = 
            seq { 
                match node with
                | FileInfo content -> yield content.SupportedProperties
                | DirectoryInfo content -> 
                    yield content.SupportedProperties
                    yield! content.Files |> Seq.collect FlattenDirectoryTree
            }
