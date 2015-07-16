namespace PortableDevices

module PDUtils = 
    open WPDCommon
    open PortableDeviceApiLib
    open PDGlobalTypes
    open PDHeaderIndices
    open PDHeader
    open PDHeaderUtils
    open System.Runtime.InteropServices
    
    let connectDevice (device : PortableDevice) : ConnectionStatus = 
        let (DeviceID devID) = device.DeviceID
        //device.Device.Open(devID, PDInterfaceInstanceProvider.PortableDeviceValuesWrapper() )
        //device.Device.Open(devID, PDInterfaceInstanceProvider.PortableDeviceValuesDummyPointer() )
        Utils.ConnectToDeviceWithClientInfo(devID, device.Device)
        try 
            let content = device.Device.Content()
            Connected(ConnectedDevice device)
        with _ -> NotConnected device
    
    let disconnectDevice (ConnectedDevice device) : ConnectionStatus = 
        device.Device.Close()
        NotConnected device
    
    let readObjectProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = properties.GetValues(objID, null)
        PropertyValue(getValue.GetStringValue(ref propertyKey))
    
    let readObjectProperties (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) (propertyKeys : PortableDeviceApiLib._tagpropertykey array ) = 
        let getValue = properties.GetValues(objID, null)
        propertyKeys
        |> Array.map (fun propertyKey -> PropertyValue(getValue.GetStringValue(ref propertyKey)))

    let readDeviceProperty (ConnectedDevice device) (propertyKey : PortableDeviceApiLib._tagpropertykey) = readObjectProperty (device.Device.Content().Properties()) "DEVICE" propertyKey
    
    let readDevicePropertiesFromCategory (connectedDevice : ConnectedDevice) (category : System.Guid) = 
        PDHeaderUtils.GetGuidPropVariants category
        |> Array.map (fun pv -> new PortableDeviceApiLib._tagpropertykey(fmtid = category, pid = pv))
        |> Array.map (fun tag -> 
               { categoryName = PDHeaderUtils.GetGuidName tag.fmtid
                 propertyName = PDHeaderUtils.GetPropertyName tag
                 result = (readDeviceProperty connectedDevice tag) })
    
    let readObjectPropertyByType (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = properties.GetValues(objID, null)
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
        deviceIds
    
    let DeviceSequence = 
        seq { 
            for devId in DeviceIdArray do
                yield { DeviceID = DeviceID devId
                        Device = PortableDeviceClass() }
        }
    
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
    
    let GetSupportedPropertyKeys (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        properties.GetSupportedProperties(objectID) |> enumerateKeyCollection
    
    let enumerateSupportedProperties (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        properties.GetSupportedProperties(objectID)
        |> enumerateKeyCollection
        |> Seq.map (fun tag -> 
               { PropertyName = (PDHeaderUtils.GetPropertyName tag)
                 Value = PropertyValueString(values.GetStringValue(ref tag)) })
        |> SupportedProperties
    
    let listAvailableFunctionalCategories (connectedDevice : ConnectedDevice) = 
        let (ConnectedDevice device) = connectedDevice
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.map (fun category -> PDHeaderUtils.GetPropertyName2 (category.guid) (uint32 category.variantType))
    
    open System.IO
    
    let GetFile (ConnectedDevice device) (ObjectID fileID) (FilePath targetPath) = 
        let STGM_READ = 0x00000000u
        let properties = device.Device.Content().Properties()
        let resources = device.Device.Content().Transfer()
        let (PropertyValue sourceFileName) = readObjectProperty properties fileID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
        let (PropertyValueUInt64 uFileSize) = readObjectPropertyByType properties fileID PDHeader.WPD_OBJECT_SIZE
        let fileSize = int64 uFileSize
        
        let optimalTransferSizeUint = ref (uint32 0)
        let sourceStream = 
            resources.GetStream(fileID, ref PDHeader.WPD_RESOURCE_DEFAULT, STGM_READ, optimalTransferSizeUint) :?> 
            System.Runtime.InteropServices.ComTypes.IStream
        let optimalTransferSize = int !optimalTransferSizeUint

        let targetStream = new FileStream(System.IO.Path.Combine(targetPath, sourceFileName), FileMode.Create, FileAccess.Write)
        let transferBuffer = Array.zeroCreate optimalTransferSize
        let mutable bytesRead = 0
        
        while targetStream.Length < fileSize do
            sourceStream.Read(transferBuffer, optimalTransferSize, nativeint bytesRead)
            let copyLength = System.Math.Min(int64 optimalTransferSize, fileSize - targetStream.Length)
            targetStream.Write(transferBuffer, 0, int copyLength)

        targetStream.Close()
