namespace PortableDevices

module PDUtils = 
    open PortableDeviceApiLib
    open PDGlobalTypes
    open PDHeaderIndices
    open System.Runtime.InteropServices
    
    let ConnectDevice(DeviceID deviceID) = 
        let pValues = box (new PortableDeviceTypesLib.PortableDeviceValuesClass()) :?> PortableDeviceApiLib.IPortableDeviceValues
        pValues.SetStringValue(ref PDHeader.WPD_CLIENT_NAME, "Sample Client")
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_MAJOR_VERSION, 1u)
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_MINOR_VERSION, 0u)
        pValues.SetUnsignedIntegerValue(ref PDHeader.WPD_CLIENT_REVISION, 2u)
        let device = PortableDeviceClass()
        device.Open(deviceID, pValues)
        try 
            Some { DeviceID = DeviceID deviceID
                   Device = device
                   Content = device.Content()
                   Resources = device.Content().Transfer()
                   Properties = device.Content().Properties()
                   Capabilities = device.Capabilities() }
        with _ -> None
    
    let DisconnectDevice(device : ConnectedDevice) : PortableDevice = 
        device.Device.Close()
        { DeviceID = device.DeviceID
          Device = device.Device }
    
    let DoOnDevice (deviceID : DeviceID) (action : ConnectedDevice -> unit) = 
        let device = ConnectDevice deviceID
        match device with
        | Some dev -> 
            try 
                action dev
                DisconnectDevice dev
            with ex -> 
                DisconnectDevice dev
                raise ex
        | _ -> failwith "Unable to connect to device"
    
    let readObjectProperty (device : ConnectedDevice) (FolderID objID | ObjectID objID) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = device.Properties.GetValues(objID, null)
        PropertyValue(getValue.GetStringValue(ref propertyKey))
        
    let readObjectProperties (device : ConnectedDevice) (FolderID objID | ObjectID objID) (propertyKeys : PortableDeviceApiLib._tagpropertykey array) = 
        let getValue = device.Properties.GetValues(objID, null)
        propertyKeys |> Array.map (fun propertyKey -> PropertyValue(getValue.GetStringValue(ref propertyKey)))
    
    let readDeviceProperty (device : ConnectedDevice) (propertyKey : PortableDeviceApiLib._tagpropertykey) = readObjectProperty device (FolderID "DEVICE") propertyKey
    
    let readDevicePropertiesFromCategory (connectedDevice : ConnectedDevice) (category : System.Guid) = 
        PDHeaderUtils.GetGuidPropVariants category
        |> Array.map (fun pv -> new PortableDeviceApiLib._tagpropertykey(fmtid = category, pid = pv))
        |> Array.map (fun tag -> 
               { categoryName = PDHeaderUtils.GetGuidName tag.fmtid
                 propertyName = PDHeaderUtils.GetPropertyName tag
                 result = (readDeviceProperty connectedDevice tag) })
    
    let matchObjectPropertyWithType (values : IPortableDeviceValues) varenum (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        match varenum with
        | VARENUM.VT_BOOL -> PropertyValueBool(values.GetBoolValue(ref propertyKey) = 1)
        | VARENUM.VT_CLSID -> PropertyValueGuid(values.GetGuidValue(ref propertyKey))
        | VARENUM.VT_DATE -> PropertyValueString(values.GetStringValue(ref propertyKey))
        | VARENUM.VT_LPWSTR -> PropertyValueString(values.GetStringValue(ref propertyKey))
        | VARENUM.VT_I4 -> PropertyValueInt32(values.GetSignedIntegerValue(ref propertyKey))
        | VARENUM.VT_I8 -> PropertyValueInt64(values.GetSignedLargeIntegerValue(ref propertyKey))
        | VARENUM.VT_UI4 -> PropertyValueUInt32(values.GetUnsignedIntegerValue(ref propertyKey))
        | VARENUM.VT_UI8 -> PropertyValueUInt64(values.GetUnsignedLargeIntegerValue(ref propertyKey))
        | VARENUM.VT_R4 -> PropertyValueFloat32(values.GetFloatValue(ref propertyKey))
        | VARENUM.VT_UNKNOWN -> PropertyValueUnknown(values.GetIUnknownValue(ref propertyKey))
        | VARENUM.VT_VECTOR | VARENUM.VT_UI1 -> PropertyValueUChar(uint8 (values.GetUnsignedIntegerValue(ref propertyKey)))
        | _ -> PropertyValueUnexpected(values.GetStringValue(ref propertyKey))
    
    let setObjectPropertyByType (values : IPortableDeviceValues) (propertyKey : PortableDeviceApiLib._tagpropertykey) (propertyValue : PropertyValue) = 
        match propertyValue with
        | PropertyValueBool value -> 
            values.SetBoolValue(ref propertyKey, 
                                match value with
                                | true -> 1
                                | _ -> 0)
        | PropertyValueGuid value -> values.SetGuidValue(ref propertyKey, ref value)
        //| VARENUM.VT_DATE -> PropertyValueString(values.GetStringValue(ref propertyKey))
        | PropertyValue value | PropertyValueString value -> values.SetStringValue(ref propertyKey, value)
        | PropertyValueInt32 value -> values.SetSignedIntegerValue(ref propertyKey, value)
        | PropertyValueInt64 value -> values.SetSignedLargeIntegerValue(ref propertyKey, value)
        | PropertyValueUInt32 value -> values.SetUnsignedIntegerValue(ref propertyKey, value)
        | PropertyValueUInt64 value -> values.SetUnsignedLargeIntegerValue(ref propertyKey, value)
        | PropertyValueFloat32 value -> values.SetFloatValue(ref propertyKey, value)
        | PropertyValueUnknown value -> values.GetIUnknownValue(ref propertyKey, ref value)
        | PropertyValueUChar value -> values.SetUnsignedIntegerValue(ref propertyKey, uint32 value)
        | PropertyValueUnexpected value -> values.SetStringValue(ref propertyKey, value)
        | PropertyValueFloat64 value -> values.SetFloatValue(ref propertyKey, float32 value)
        | UnableToReadValue ex -> failwith ex.Message
    
    let readObjectPropertyByType (device : ConnectedDevice) objID (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        matchObjectPropertyWithType (device.Properties.GetValues((DeconstructContentID objID), null)) (PDHeaderUtils.GetPropertyType propertyKey) propertyKey
    let readObjectPropertyBySpecificType (device : ConnectedDevice) (varenum : VARENUM) (propertyKey : PortableDeviceApiLib._tagpropertykey) (FolderID objID | ObjectID objID) = 
        matchObjectPropertyWithType (device.Properties.GetValues(objID, null)) varenum propertyKey
    
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
    
    let enumerateErrorValues (values : PortableDeviceApiLib.IPortableDeviceValues) (properties : array<PortableDeviceApiLib._tagpropertykey>) = properties |> Array.map (fun prop -> values.GetErrorValue(ref prop))
    
    let enumerateKeyCollection (collection : PortableDeviceApiLib.IPortableDeviceKeyCollection) = 
        let count = ref 0u
        collection.GetCount(count)
        seq { 
            for index in 0u..(!count - 1u) do
                let tag = ref (new PortableDeviceApiLib._tagpropertykey())
                collection.GetAt(index, tag)
                yield !tag
        }
    
    let enumerateSupportedPropertyKeys (device : ConnectedDevice) (FolderID objID | ObjectID objID) = device.Properties.GetSupportedProperties(objID) |> enumerateKeyCollection
    
    let enumerateSupportedProperties (device : ConnectedDevice) (FolderID objID | ObjectID objID) = 
        let keys = device.Properties.GetSupportedProperties(objID)
        let values = device.Properties.GetValues(objID, keys)
        device.Properties.GetSupportedProperties(objID)
        |> enumerateKeyCollection
        |> Seq.map (fun tag -> 
               { PropertyName = (PDHeaderUtils.GetPropertyName tag)
                 Value = 
                     try 
                         PropertyValueString(values.GetStringValue(ref tag))
                     with ex -> UnableToReadValue ex })
        |> Array.ofSeq // SupportedProperties
    
    let enumerateAvailableFunctionalCategories (device : ConnectedDevice) = 
        device.Capabilities.GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.map (fun category -> PDHeaderUtils.GetPropertyName2 (category.guid) (uint32 category.variantType))
    
    let enumerateSupportedCommands (device : ConnectedDevice) = device.Capabilities.GetSupportedCommands() |> enumerateKeyCollection
    let supportsCommand (device : ConnectedDevice) (command : PortableDeviceApiLib._tagpropertykey) = enumerateSupportedCommands device |> Seq.tryFind (fun item -> item = command)
    let IsPropertyWritable device (FolderID objID | ObjectID objID) tag = device.Properties.GetPropertyAttributes(objID, ref tag).GetBoolValue(ref PDHeader.WPD_PROPERTY_ATTRIBUTE_CAN_WRITE) = 1
    
    let GetObjectName device objectID = 
        let (PropertyValueGuid objectType) = readObjectPropertyByType device objectID PDHeader.WPD_OBJECT_CONTENT_TYPE
        match objectType with
        | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true -> readObjectProperty device objectID PDHeader.WPD_OBJECT_NAME
        | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT true -> readObjectProperty device objectID PDHeader.WPD_OBJECT_NAME
        | _ -> readObjectProperty device objectID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
    
    let ObjectPath device objectID = 
        let rec getPath currentID = 
            seq { 
                match currentID with
                | FolderID "" -> yield! Seq.empty
                | _ -> 
                    let (PropertyValue parentID) = readObjectProperty device currentID PDHeader.WPD_OBJECT_PARENT_ID
                    yield! getPath (FolderID parentID)
                    yield currentID
            }
        getPath objectID
    
    let ObjectPathIDs device objectID = 
        ObjectPath device objectID
        |> Seq.map (fun (FolderID id | ObjectID id) -> id)
        |> Seq.reduce (fun state dir -> sprintf "%s/%s" state dir)
    
    let ObjectPathNames device objectID = 
        ObjectPath device objectID
        |> Seq.map (GetObjectName device)
        |> Seq.map (fun (PropertyValue value) -> value)
        |> Seq.reduce (fun state dir -> sprintf "%s/%s" state dir)
