namespace PortableDevices

open PortableDeviceApiLib
open PortableDevices.PDGlobalTypes
open PDUtils

module PDContent = 
    type GeneralProperties = 
        { Id : string
          Name : string
          Length : uint64
          Type : string
          CreationTime : System.DateTime
          LastWriteTime : System.DateTime
          DateAuthored : System.DateTime }
        static member CreateFromObjectID (device : ConnectedDevice) (ObjectID objID | FolderID objID) = 
            let datePattern = "yyyy/MM/dd:HH:mm:ss.fff"
            { Id = objID
              Name = 
                  match (readObjectProperty device objID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME) with
                  | (PropertyValue nm) -> nm
              Length = 
                  (match (readObjectPropertyBySpecificType device PDHeaderIndices.VARENUM.VT_UI8 PDHeader.WPD_OBJECT_SIZE) objID with
                   | (PropertyValueUInt64 value) -> value)
              Type = 
                  (match (readObjectPropertyBySpecificType device PDHeaderIndices.VARENUM.VT_CLSID PDHeader.WPD_OBJECT_CONTENT_TYPE) objID with
                   | (PropertyValueGuid value) -> 
                       if value = PDHeader.WPD_CONTENT_TYPE_FOLDER then "Folder"
                       else "File")
              CreationTime = 
                  System.DateTime.ParseExact((match (readObjectProperty device objID PDHeader.WPD_OBJECT_DATE_CREATED) with
                                              | (PropertyValue value) -> value), datePattern, null)
              LastWriteTime = 
                  System.DateTime.ParseExact((match (readObjectProperty device objID PDHeader.WPD_OBJECT_DATE_MODIFIED) with
                                              | (PropertyValue value) -> value), datePattern, null)
              DateAuthored = 
                  System.DateTime.ParseExact((match (readObjectProperty device objID PDHeader.WPD_OBJECT_DATE_AUTHORED) with
                                              | (PropertyValue value) -> value), datePattern, null) }
    
    type PortableFileInfo = 
        { GeneralProperties : GeneralProperties //option
          SupportedProperties : PropertyNameValue array
          ParentDirectoryID : string }
    
    and PortableDirectoryInfo = 
        { GeneralProperties : GeneralProperties //option
          SupportedProperties : PropertyNameValue array
          ParentDirectoryID : string
          Files : seq<PortableContentInfo> }
    
    and PortableContentInfo = 
        | FileInfo of PortableFileInfo
        | DirectoryInfo of PortableDirectoryInfo
    
    //DELETE_OBJECT_OPTIONS =
    let PORTABLE_DEVICE_DELETE_NO_RECURSION = 0u
    let PORTABLE_DEVICE_DELETE_WITH_RECURSION = 1u
    
    let rec ListNodeIDs (device : ConnectedDevice) (listSubdirectories : bool) (parentID : string) = 
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
                        yield! ListNodeIDs device listSubdirectories !objID
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true -> 
                        yield FolderID !objID
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
    
    let SearchItemByName device nodeName (FolderID parentNodeID) = 
        ListNodeIDs device false parentNodeID |> Seq.tryFind (fun (FolderID objID | ObjectID objID) -> 
                                                     let pValue = 
                                                         try 
                                                             readObjectProperty device objID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
                                                         with ex -> readObjectProperty device objID PDHeader.WPD_OBJECT_NAME
                                                     match pValue with
                                                     | PropertyValue name when name = nodeName -> true
                                                     | _ -> false)
    
    let SearchItemByNames device (nodeNames : string array) (FolderID parentNodeID) = 
        ListNodeIDs device false parentNodeID |> Seq.tryFind (fun (FolderID objID | ObjectID objID) -> 
                                                     nodeNames |> Array.exists (fun nodeName -> 
                                                                      let pValue = 
                                                                          try 
                                                                              readObjectProperty device objID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
                                                                          with ex -> readObjectProperty device objID PDHeader.WPD_OBJECT_NAME
                                                                      match pValue with
                                                                      | PropertyValue name when name = nodeName -> true
                                                                      | _ -> false))
    
    let ListChildren (device : ConnectedDevice) (FolderID parentID) = ListNodeIDs device false parentID |> Seq.map (fun nodeID -> GeneralProperties.CreateFromObjectID device nodeID)
    
    let rec ListContentInfo (device : ConnectedDevice) (listSubdirectories : bool) (parentID : string) = 
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
                        yield DirectoryInfo { GeneralProperties = (GeneralProperties.CreateFromObjectID device (FolderID !objID))
                                              SupportedProperties = (enumerateSupportedProperties device !objID)
                                              ParentDirectoryID = parentID
                                              Files = (ListContentInfo device listSubdirectories !objID) }
                    | _ -> 
                        yield FileInfo { GeneralProperties = (GeneralProperties.CreateFromObjectID device (ObjectID !objID))
                                         SupportedProperties = (enumerateSupportedProperties device !objID)
                                         ParentDirectoryID = parentID }
        }
    
    module Utils = 
        open System.IO
        
        let GetFile (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) targetPath = 
            let STGM_READ = 0x00000000u
            let (PropertyValue sourceFileName) = readObjectProperty device fileID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
            let (PropertyValueUInt64 uFileSize) = readObjectPropertyByType device PDHeader.WPD_OBJECT_SIZE fileID
            let fileSize = int64 uFileSize
            let optimalTransferSizeUint = ref (uint32 0)
            let sourceStream = device.Resources.GetStream(fileID, ref PDHeader.WPD_RESOURCE_DEFAULT, STGM_READ, optimalTransferSizeUint) :?> System.Runtime.InteropServices.ComTypes.IStream
            let optimalTransferSize = int !optimalTransferSizeUint
            let targetStream = new FileStream(System.IO.Path.Combine(targetPath, sourceFileName), FileMode.Create, FileAccess.Write)
            let transferBuffer = Array.zeroCreate optimalTransferSize
            while targetStream.Length < fileSize do
                sourceStream.Read(transferBuffer, optimalTransferSize, System.IntPtr.Zero)
                let copyLength = System.Math.Min(int64 optimalTransferSize, fileSize - targetStream.Length)
                targetStream.Write(transferBuffer, 0, int copyLength)
            targetStream.Close()
        
        let DeleteObject (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) recursively = 
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_ID, fileID)
            let propVariant = values.GetValue(ref PDHeader.WPD_OBJECT_ID)
            let objectIds = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
            objectIds.Add(ref propVariant)
            let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
            match recursively with
            | true -> device.Content.Delete(PORTABLE_DEVICE_DELETE_WITH_RECURSION, objectIds, result)
            | false -> device.Content.Delete(PORTABLE_DEVICE_DELETE_NO_RECURSION, objectIds, result)
            result
        
        let DeleteFile' (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) = 
            let objectIds = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
            ()
        
        let PortableFileRequiredValues (device : ConnectedDevice) (source : FileInfo) (FolderID parentID) = 
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_PARENT_ID, parentID)
            values.SetUnsignedLargeIntegerValue(ref PDHeader.WPD_OBJECT_SIZE, uint64 source.Length)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, source.Name)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, Path.GetFileNameWithoutExtension(source.Name))
            values
        
        let PortableFolderRequiredValues (device : ConnectedDevice) folderName (FolderID parentID) = 
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_PARENT_ID, parentID)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, folderName)
            values.SetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE, ref PDHeader.WPD_CONTENT_TYPE_FOLDER)
            values
        
        let StrCopy optimalTransferSize (sourceStream : FileStream) (targetStream : System.Runtime.InteropServices.ComTypes.IStream) = 
            let transferBuffer = Array.zeroCreate optimalTransferSize
            let mutable bytesToRead = optimalTransferSize
            let mutable totalBytesRead = 0
            while totalBytesRead < (int sourceStream.Length) do
                let bytesRead = sourceStream.Read(transferBuffer, 0, bytesToRead)
                targetStream.Write(transferBuffer, bytesRead, System.IntPtr.Zero)
                totalBytesRead <- totalBytesRead + bytesRead
        
        let SendFile (device : ConnectedDevice) (FolderID targetFolderID) (source : FileInfo) = 
            let values = PortableFileRequiredValues device source (FolderID targetFolderID)
            use sourceStream = source.OpenRead()
            let mutable targetStream = ((new PDInterfaceInstanceProvider.DummyStreamType()) :> IStream)
            let optimalTransferSizeUint = ref (uint32 0)
            device.Content.CreateObjectWithPropertiesAndData(values, &targetStream, optimalTransferSizeUint, ref null)
            let comStream = targetStream :?> System.Runtime.InteropServices.ComTypes.IStream
            StrCopy (int !optimalTransferSizeUint) sourceStream comStream
            sourceStream.Close()
            targetStream.Commit(0u)
        
        let CreateFolder (device : ConnectedDevice) folderName (FolderID targetFolderID) = 
            let values = PortableFolderRequiredValues device folderName (FolderID targetFolderID)
            let folder = ref ""
            device.Content.CreateObjectWithPropertiesOnly(values, folder)
            FolderID !folder
    
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
