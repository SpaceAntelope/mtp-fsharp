namespace PortableDevices

module PDUtils = 
    open PortableDeviceApiLib
    open PDGlobalTypes
    open PDHeaderIndices
    open PDHeader
    open PDHeaderUtils
    open System.Runtime.InteropServices
    
    let connectDevice (DeviceID deviceID) : ConnectionStatus = 
        let pValues = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
        pValues.SetStringValue(ref PDHeader.WPD_CLIENT_NAME, "Sample Client")
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_MAJOR_VERSION, 1u)
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_MINOR_VERSION, 0u)
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_REVISION, 2u)
        
        let device = PortableDeviceClass()
        device.Open(deviceID, pValues)
        try 
            Connected { DeviceID = DeviceID deviceID
                        Device = device
                        Content = device.Content()
                        Resources = device.Content().Transfer()
                        Properties = device.Content().Properties()
                        Capabilities = device.Capabilities() }
        with _ -> 
            NotConnected { DeviceID = DeviceID deviceID
                           Device = device }
    
    let disconnectDevice (device : ConnectedDevice) : ConnectionStatus = 
        device.Device.Close()
        NotConnected { DeviceID = device.DeviceID
                       Device = device.Device }
    
    let readObjectProperty (device : ConnectedDevice) (objID : string) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = device.Properties.GetValues(objID, null)
        PropertyValue(getValue.GetStringValue(ref propertyKey))
    
    let readObjectProperties (device : ConnectedDevice) (objID : string) (propertyKeys : PortableDeviceApiLib._tagpropertykey array) = 
        let getValue = device.Properties.GetValues(objID, null)
        propertyKeys |> Array.map (fun propertyKey -> PropertyValue(getValue.GetStringValue(ref propertyKey)))
    
    let readDeviceProperty (device : ConnectedDevice) (propertyKey : PortableDeviceApiLib._tagpropertykey) = readObjectProperty device "DEVICE" propertyKey
    
    let readDevicePropertiesFromCategory (connectedDevice : ConnectedDevice) (category : System.Guid) = 
        PDHeaderUtils.GetGuidPropVariants category
        |> Array.map (fun pv -> new PortableDeviceApiLib._tagpropertykey(fmtid = category, pid = pv))
        |> Array.map (fun tag -> 
               { categoryName = PDHeaderUtils.GetGuidName tag.fmtid
                 propertyName = PDHeaderUtils.GetPropertyName tag
                 result = (readDeviceProperty connectedDevice tag) })
    
    let readObjectPropertyByType (device : ConnectedDevice) (objID : string) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = device.Properties.GetValues(objID, null)
        match PDHeaderUtils.GetPropertyType propertyKey with
        | VARENUM.VT_BOOL -> PropertyValueBool(getValue.GetBoolValue(ref propertyKey) = 1)
        | VARENUM.VT_CLSID -> PropertyValueGuid(getValue.GetGuidValue(ref propertyKey))
        | VARENUM.VT_LPWSTR -> PropertyValueString(getValue.GetStringValue(ref propertyKey))
        | VARENUM.VT_I4 -> PropertyValueInt32(getValue.GetSignedIntegerValue(ref propertyKey))
        | VARENUM.VT_I8 -> PropertyValueInt64(getValue.GetSignedLargeIntegerValue(ref propertyKey))
        | VARENUM.VT_UI4 -> PropertyValueUInt32(getValue.GetUnsignedIntegerValue(ref propertyKey))
        | VARENUM.VT_UI8 -> PropertyValueUInt64(getValue.GetUnsignedLargeIntegerValue(ref propertyKey))
        | VARENUM.VT_R4 -> PropertyValueFloat32(getValue.GetFloatValue(ref propertyKey))
        | VARENUM.VT_UNKNOWN -> PropertyValueUnknown(getValue.GetIUnknownValue(ref propertyKey))
        | VARENUM.VT_VECTOR | VARENUM.VT_UI1 -> PropertyValueUChar(uint8 (getValue.GetUnsignedIntegerValue(ref propertyKey)))
        | _ -> PropertyValueUnexpected(getValue.GetStringValue(ref propertyKey))
    
    let ListAllPropertyValues(connectedDevice : ConnectedDevice) = 
        PDHeaderReflection.ListAllGuids
        |> Array.collect (fun guidInfo -> readDevicePropertiesFromCategory connectedDevice guidInfo.Guid)
        |> Array.filter (fun propInfo -> 
               match propInfo.result with
               | PropertyValue _ -> true
               | _ -> false)
    
    let DeviceIdArray = 
        let deviceManager = PortableDeviceManagerClass()
        deviceManager.RefreshDeviceList()
        let deviceCount = ref 0u
        deviceManager.GetDevices(null, deviceCount)
        let deviceIds = Array.init (int !deviceCount) (fun index -> "")
        deviceManager.GetDevices(deviceIds, deviceCount)
        deviceIds |> Array.map DeviceID
        
    //    let enumPortableDeviceValues (collection : PortableDeviceApiLib.IPortableDeviceValues) =
    //        let count = ref 0u
    //        collection.GetCount(count)
    //        seq { 
    //            for index in 0u..(!count - 1u) do
    //                let result = ref (new tag_inner_PROPVARIANT())
    //                collection.GetAt(index, pv)
    //                let pvValue = HelperFunctions.MarshalVariant<PropVariant> !pv
    //                yield { propVariant = pvValue
    //                        guid = Marshal.PtrToStructure(pvValue.pointerValue, typedefof<System.Guid>) :?> System.Guid
    //                        variantType = pvValue.variantType }
    //        }
    let enumeratePropVariantCollection (collection : PortableDeviceApiLib.IPortableDevicePropVariantCollection) = 
        let count = ref 0u
        collection.GetCount(count)
        seq { 
            for index in 0u..(!count - 1u) do
                let pv = ref (new tag_inner_PROPVARIANT())
                collection.GetAt(index, pv)
                let pvValue = HelperFunctions.MarshalVariant<PropVariant> !pv
                yield { propVariant = pvValue
                        guid = Marshal.PtrToStructure(pvValue.pointerValue, typedefof<System.Guid>) :?> System.Guid
                        variantType = pvValue.variantType }
        }
    
    let enumerateKeyCollection (collection : PortableDeviceApiLib.IPortableDeviceKeyCollection) = 
        let count = ref 0u
        collection.GetCount(count)
        seq { 
            for index in 0u..(!count - 1u) do
                let tag = ref (new PortableDeviceApiLib._tagpropertykey())
                collection.GetAt(index, tag)
                yield !tag
        }
    
    let GetSupportedPropertyKeys (device : ConnectedDevice) (objectID : string) = 
        let keys = device.Properties.GetSupportedProperties(objectID)
        device.Properties.GetSupportedProperties(objectID) |> enumerateKeyCollection
    
    let enumerateSupportedProperties (device : ConnectedDevice) (objectID : string) = 
        let keys = device.Properties.GetSupportedProperties(objectID)
        let values = device.Properties.GetValues(objectID, keys)
        device.Properties.GetSupportedProperties(objectID)
        |> enumerateKeyCollection
        |> Seq.map (fun tag -> 
               { PropertyName = (PDHeaderUtils.GetPropertyName tag)
                 Value = PropertyValueString(values.GetStringValue(ref tag)) })
        |> SupportedProperties
    
    let listAvailableFunctionalCategories (connectedDevice : ConnectedDevice) = 
        connectedDevice.Capabilities.GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.map (fun category -> PDHeaderUtils.GetPropertyName2 (category.guid) (uint32 category.variantType))
    
    open System.IO
    
    let GetFile (device : ConnectedDevice) (ObjectID fileID) (FilePath targetPath) = 
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
        let WPD_OBJECT_ID = ref (new _tagpropertykey(fmtid = PDHeader.WPD_OBJECT_ID.fmtid, pid = PDHeader.WPD_OBJECT_ID.pid))
        values.SetStringValue(WPD_OBJECT_ID, fileID)
        let propVariant = values.GetValue(WPD_OBJECT_ID)
        let objectIds = box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection
        objectIds.Add(ref propVariant)
        let result = ref (box (new PortableDeviceTypesLib.PortableDevicePropVariantCollectionClass()) :?> PortableDeviceApiLib.IPortableDevicePropVariantCollection)
        device.Content.Delete(0u, objectIds, result)
        result
