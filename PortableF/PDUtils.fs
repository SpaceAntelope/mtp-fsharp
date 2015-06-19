namespace PortableDevices

module PDUtils = 
    open WPDCommon
    open PortableDeviceApiLib
    open PDTypes  
    open PDHeader
    open PDHeaderDecoder  
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
    
    let readDevicProperty (connectedDevice : ConnectedDevice) (propertyKey : _tagpropertykey) = 
        let (ConnectedDevice device) = connectedDevice
        DevicePropertyValue
            (device.Device.Content().Properties().GetValues("DEVICE", null).GetStringValue(ref propertyKey))
    
    //DevicePropertyValue(sprintf "%A %A" device.DeviceID propName)
    let readDeviceProperty2 (device : PortableDevice) = 
        let content = device.Device.Content()
        let props = content.Properties()
        let values = props.GetValues("DEVICE", null)
        DevicePropertyValue
            (values.GetStringValue(ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME())))
    
    //        DevicePropertyValue (
    //            device.Device.Content()
    //                .Properties()
    //                .GetValues("DEVICE",PDInterfaceInstanceProvider.PortableDeviceKeyCollectionDummyPointer())
    //                .GetStringValue(ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()))
    //            )
    let readDeviceProperty (device : PortableDevice) property = 
        let getValue = device.Device.Content().Properties().GetValues("DEVICE", null)
        try 
            DevicePropertyValue(getValue.GetStringValue(ref property))
        with ex -> DevicePropertyValue(ex.Message)
    
    let readDevicePropertiesFromCategory (device : PortableDevice) (category : string) = 
        let printProperties propList (nameList : List<string>) = 
            List.iteri (fun (i : int) propFun -> 
                System.Console.Write("\t{0}: ", nameList.[i])
                let (DevicePropertyValue value) = readDeviceProperty device (propFun())
                System.Console.WriteLine("{0}", value)) propList
        System.Console.WriteLine(category)
        match category with
        | "WPD_DEVICE_PROPERTIES_V1" -> 
            printProperties PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.PropertyFunctionList 
                PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.PropertyNameList
        | "WPD_DEVICE_PROPERTIES_V2" -> 
            printProperties PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V2.PropertyFunctionList 
                PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V2.PropertyNameList
        | _ -> ()
    
    //        let mutable content = PDInterfaceInstanceProvider.PortableDeviceContentDummyPointer()
    //        let mutable properties = PDInterfaceInstanceProvider.PortableDevicePropertiesDummyPointer()
    //        let mutable propertyValues = PDInterfaceInstanceProvider.PortableDeviceValuesDummyPointer()
    //        let mutable propertyValue = ""
    //        device.Device.Content(&content)
    //        content.Properties(&properties)
    //        properties.GetValues("DEVICE", null, &propertyValues)
    //        propertyValues.GetStringValue
    //            (ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()), &propertyValue)
    //        DevicePropertyValue propertyValue
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
    
    let listAvailableFunctionalCategories (connectedDevice : ConnectedDevice) = 
        let (ConnectedDevice device) = connectedDevice
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.map (fun category -> PDHeaderDecoder.GetPropertyName (category.guid) (uint32 category.variantType))

