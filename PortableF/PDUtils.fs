namespace PortableDevices

module PDUtils = 
    open WPDCommon
    open PortableDeviceApiLib
    open PDTypes
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
    
    let disconnectDevice (connectedDevice : ConnectedDevice) : ConnectionStatus = 
        let (ConnectedDevice device) = connectedDevice
        device.Device.Close()
        NotConnected device
    
    let readObjectProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) 
        (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = properties.GetValues(objID, null)
        try 
            PropertyResult(getValue.GetStringValue(ref propertyKey))
        with ex -> AccessError(ex.Message)
    
    let readDeviceProperty (connectedDevice : ConnectedDevice) (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let (ConnectedDevice device) = connectedDevice
        readObjectProperty (device.Device.Content().Properties()) "DEVICE" propertyKey
    
    let readDevicePropertiesFromCategory (connectedDevice : ConnectedDevice) (category : System.Guid) = 
        PDHeaderUtils.GetGuidPropVariants category
        |> Array.map (fun pv -> new PortableDeviceApiLib._tagpropertykey(fmtid = category, pid = pv))
        |> Array.map (fun tag -> 
               { categoryName = PDHeaderUtils.GetGuidName tag.fmtid
                 propertyName = PDHeaderUtils.GetPropertyName tag
                 result = (readDeviceProperty connectedDevice tag) })
    
    let ListAllPropertyKeys = 
        System.Reflection.Assembly.GetExecutingAssembly().GetType("PortableDevices.PDHeader").GetMethods()
        |> Array.filter (fun info -> info.ReturnType.Name = "_tagpropertykey")
        |> Array.map (fun info -> info.Name, info.Invoke(null, null) :?> PortableDeviceApiLib._tagpropertykey)
    
    let ListAllGuids = 
        System.Reflection.Assembly.GetExecutingAssembly().GetType("PortableDevices.PDHeader").GetMethods()
        |> Array.filter (fun info -> info.ReturnType.Name = "Guid")
        |> Array.map (fun info -> info.Name.Substring(4), info.Invoke(null, null) :?> System.Guid)
    
    let ListAllPropertyValues(connectedDevice : ConnectedDevice) = 
        ListAllGuids
        |> Array.collect (fun (name, guid) -> readDevicePropertiesFromCategory connectedDevice guid)
        |> Array.filter (fun propInfo -> 
               match propInfo.result with
               | PropertyResult _ -> true
               | _ -> false)
    
    let SimplePropertyInfoListToString(propertyValues : SimplePropertyInfo []) = 
        propertyValues
        |> Seq.groupBy (fun propInfo -> propInfo.categoryName)
        |> Seq.mapi (fun catIndex (key, values) -> 
               seq { 
                   yield sprintf "%i %s:" catIndex key
                   yield! values 
                          |> Seq.mapi (fun propIndex propInfo -> 
                                 match propInfo.result with
                                 | PropertyResult value -> sprintf "\t %i %s: %s" propIndex propInfo.propertyName value
                                 | AccessError value -> sprintf "\t%i %s: %s" propIndex propInfo.propertyName value)
               })
        |> Seq.collect (fun item -> item)
    
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
    
    let listAvailableFunctionalCategories (connectedDevice : ConnectedDevice) = 
        let (ConnectedDevice device) = connectedDevice
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.map (fun category -> PDHeaderUtils.GetPropertyName2 (category.guid) (uint32 category.variantType))
