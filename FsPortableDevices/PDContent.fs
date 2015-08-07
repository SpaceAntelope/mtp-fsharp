namespace PortableDevices

open PortableDeviceApiLib
open PortableDevices.PDGlobalTypes
open PDUtils

module PDContent = 
    type GeneralProperties = 
        { Id : PortableContentID
          Name : string
          Length : uint64
          Type : string
          LastWriteTime : System.DateTime
          ParentName : string }
        static member CreateFromObjectID (device : ConnectedDevice) (objID : PortableContentID) = 
            let datePattern = "yyyy/MM/dd:HH:mm:ss.fff"
            { Id = objID
              Name = 
                  match GetObjectName device objID with
                  | PropertyValue name -> name
              Length = 
                  (match (readObjectPropertyBySpecificType device PDHeaderIndices.VARENUM.VT_UI8 PDHeader.WPD_OBJECT_SIZE objID) with
                   | (PropertyValueUInt64 value) -> value)
              Type = 
                  match objID with
                  | FolderID _ -> "Folder"
                  | _ -> "Other"
              LastWriteTime = 
                  System.DateTime.ParseExact((match (readObjectProperty device objID PDHeader.WPD_OBJECT_DATE_MODIFIED) with
                                              | (PropertyValue value) -> value), datePattern, null)
              ParentName = 
                  match readObjectProperty device objID PDHeader.WPD_OBJECT_PARENT_ID with
                  | PropertyValue objID when not (System.String.IsNullOrEmpty(objID)) -> 
                      let (PropertyValue parentName) = GetObjectName device (ObjectID objID)
                      parentName
                  | _ -> "" }
    
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
    
    let rec ListNodeIDs (device : ConnectedDevice) (listSubdirectories : bool) (FolderID parentID) = 
        seq { 
            let objects = device.Content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    let objectContentType = device.Properties.GetValues(!objID, null).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
                    match objectContentType with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT true when listSubdirectories = true -> 
                        yield FolderID !objID
                        yield! ListNodeIDs device listSubdirectories (FolderID !objID)
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT true -> yield FolderID !objID
                    | _ -> yield ObjectID !objID
        }
    
    let (|=|) x y = System.Text.RegularExpressions.Regex.IsMatch(x, y)
    
    let SearchByProperties device parentID properties searchTerm compareFunction = 
        ListNodeIDs device false parentID |> Seq.where (fun (FolderID objID | ObjectID objID) -> 
                                                 properties |> Array.exists (fun prop -> 
                                                                   try 
                                                                       match readObjectProperty device (ObjectID objID) prop with
                                                                       | PropertyValue value when (compareFunction value searchTerm) -> true
                                                                       | _ -> false
                                                                   with _ -> false))
    
    let SearchByMatchingName device parentID objectName = SearchByProperties device parentID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME; PDHeader.WPD_OBJECT_NAME |] objectName (|=|)
    
    let SearchBySpecificName device parentID objectName = 
        let result = SearchByProperties device parentID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME; PDHeader.WPD_OBJECT_NAME |] objectName (=)
        match Seq.length result with
        | 0 -> None
        | _ -> Some(Seq.head result)
    
    let SearchItemByNames device (nodeNames : string array) parentNodeID = 
        ListNodeIDs device false parentNodeID |> Seq.tryFind (fun objID -> 
                                                     nodeNames |> Array.exists (fun nodeName -> 
                                                                      let pValue = 
                                                                          try 
                                                                              readObjectProperty device objID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
                                                                          with ex -> readObjectProperty device objID PDHeader.WPD_OBJECT_NAME
                                                                      match pValue with
                                                                      | PropertyValue name when name = nodeName -> true
                                                                      | _ -> false))
    
    let ListChildren (device : ConnectedDevice) parentID = ListNodeIDs device false parentID |> Seq.map (fun nodeID -> GeneralProperties.CreateFromObjectID device nodeID)
    
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
                                              SupportedProperties = (enumerateSupportedProperties device (ObjectID !objID))
                                              ParentDirectoryID = parentID
                                              Files = (ListContentInfo device listSubdirectories !objID) }
                    | _ -> 
                        yield FileInfo { GeneralProperties = (GeneralProperties.CreateFromObjectID device (ObjectID !objID))
                                         SupportedProperties = (enumerateSupportedProperties device (ObjectID !objID))
                                         ParentDirectoryID = parentID }
        }
    
    module Utils = 
        open System.IO
        
        let PortableFileRequiredValues (source : FileInfo) newFileName (FolderID parentID) = 
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_PARENT_ID, parentID)
            values.SetUnsignedLargeIntegerValue(ref PDHeader.WPD_OBJECT_SIZE, uint64 source.Length)
            match newFileName with
            | name when not (System.String.IsNullOrEmpty(name)) -> 
                values.SetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, name)
                values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, Path.GetFileNameWithoutExtension(name))
            | _ -> 
                values.SetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, source.Name)
                values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, Path.GetFileNameWithoutExtension(source.Name))
            values
        
        let PortableFolderRequiredValues folderName (FolderID parentID) = 
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
        
        let PortableFileRequiredValuesFromObject (device : ConnectedDevice) source (FolderID newParentID) = 
            let (PropertyValueUInt64 objectSize) = readObjectPropertyByType device source PDHeader.WPD_OBJECT_SIZE
            let (PropertyValueString originalFileName) = readObjectPropertyByType device source PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
            let (PropertyValueString objectName) = readObjectPropertyByType device source PDHeader.WPD_OBJECT_NAME
            let values = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            values.SetStringValue(ref PDHeader.WPD_OBJECT_PARENT_ID, newParentID)
            values.SetUnsignedLargeIntegerValue(ref PDHeader.WPD_OBJECT_SIZE, objectSize)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_NAME, objectName)
            values.SetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, originalFileName)
            values
    
    module IO = 
        open System.IO
        open Utils
        
        let STGM_READ = 0x00000000u
        
        let GetObject (device : ConnectedDevice) fileID targetPath = 
            let (PropertyValue sourceFileName) = readObjectProperty device fileID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
            let (PropertyValueUInt64 uFileSize) = readObjectPropertyByType device fileID PDHeader.WPD_OBJECT_SIZE
            let fileSize = int64 uFileSize
            let optimalTransferSizeUint = ref (uint32 0)
            let sourceStream = device.Resources.GetStream(DeconstructContentID fileID, ref PDHeader.WPD_RESOURCE_DEFAULT, STGM_READ, optimalTransferSizeUint) :?> System.Runtime.InteropServices.ComTypes.IStream
            let optimalTransferSize = int !optimalTransferSizeUint
            let targetStream = new FileStream(System.IO.Path.Combine(targetPath, sourceFileName), FileMode.Create, FileAccess.Write)
            let transferBuffer = Array.zeroCreate optimalTransferSize
            while targetStream.Length < fileSize do
                sourceStream.Read(transferBuffer, optimalTransferSize, System.IntPtr.Zero)
                let copyLength = System.Math.Min(int64 optimalTransferSize, fileSize - targetStream.Length)
                targetStream.Write(transferBuffer, 0, int copyLength)
            targetStream.Close()
        
        let DeleteObject (device : ConnectedDevice) (ObjectID fileID | FolderID fileID) recursively = 
            let propVariant = HelperFunctions.ConvertObjectIdToPropVariant fileID
            let objectIds = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
            objectIds.Add(ref propVariant)
            let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
            match recursively with
            | true -> device.Content.Delete(PORTABLE_DEVICE_DELETE_WITH_RECURSION, objectIds, result)
            | false -> device.Content.Delete(PORTABLE_DEVICE_DELETE_NO_RECURSION, objectIds, result)
            result.Value
        
        let SendFile (device : ConnectedDevice) (FolderID targetFolderID) (source : FileInfo) newFileName = 
            let values = PortableFileRequiredValues source newFileName (FolderID targetFolderID)
            use sourceStream = source.OpenRead()
            let mutable targetStream = ((new PDInterfaceInstanceProvider.DummyStreamType()) :> IStream)
            let optimalTransferSizeUint = ref (uint32 0)
            device.Content.CreateObjectWithPropertiesAndData(values, &targetStream, optimalTransferSizeUint, ref null)
            let comStream = targetStream :?> System.Runtime.InteropServices.ComTypes.IStream
            StrCopy (int !optimalTransferSizeUint) sourceStream comStream
            sourceStream.Close()
            targetStream.Commit(0u)
        
        let CreateFolder (device : ConnectedDevice) folderName (FolderID targetFolderID) = 
            let values = PortableFolderRequiredValues folderName (FolderID targetFolderID)
            let folder = ref ""
            device.Content.CreateObjectWithPropertiesOnly(values, folder)
            FolderID !folder
        
        let MoveObjectInDevice (device : ConnectedDevice) (FolderID targetID) (sourceIDs : string []) = 
            match (supportsCommand device PDHeader.WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS) with
            | None -> failwith "Device does not support move command."
            | Some command -> 
                let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
                let objectsToMove = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
                Array.iter (fun sourceID -> objectsToMove.Add(ref (HelperFunctions.ConvertObjectIdToPropVariant sourceID))) sourceIDs
                device.Content.Move(objectsToMove, targetID, result)
                result
        
        let CopyObjectInDevice (device : ConnectedDevice) (FolderID targetID) (sourceIDs : string []) = 
            match (supportsCommand device PDHeader.WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS) with
            | None -> failwith "Device does not support copy command."
            | Some command -> 
                let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
                let objectsToMove = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
                Array.iter (fun sourceID -> objectsToMove.Add(ref (HelperFunctions.ConvertObjectIdToPropVariant sourceID))) sourceIDs
                device.Content.Copy(objectsToMove, targetID, result)
                result
        
        let UpdateObject (device : ConnectedDevice) (FolderID objID | ObjectID objID) (newValues : array<PortableDeviceApiLib._tagpropertykey * PropertyValue>) = 
            let updatedValues = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
            newValues |> Array.iter (fun (tag, value) -> 
                             match IsPropertyWritable device (ObjectID objID) tag with
                             | false -> failwith (sprintf "%A" (PDHeaderUtils.GetPropertyName tag))
                             | true -> setObjectPropertyByType updatedValues tag value)
            device.Properties.SetValues(objID, updatedValues)
        
        let RenameObject (device : ConnectedDevice) objectID updatedName = UpdateObject device objectID [| (PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME, PropertyValueString updatedName) |]
    
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
