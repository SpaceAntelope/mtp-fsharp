namespace PortableDevices

module PDUtils = 
    open WPDCommon
    open PortableDeviceApiLib
    open PDTypes
    
    let connectDevice : ConnectDevice = 
        fun device -> 
            let (DeviceID devID) = device.DeviceID
            Utils.ConnectToDevice(devID, device.Device) |> printfn "Connection Status: %b"
            Connected device
    
    let disconnectDevice : DisconnectDevice = 
        fun device -> 
            device.Device.Close()
            Disconnected device
    
    let readProperty : ReadDeviceProperty = 
        fun device propName -> 
            match device with
            | Connected dev -> Some(DevicePropertyValue(sprintf "%A %A" dev.DeviceID propName))
            | _ -> None
    
    let readDeviceProperty2 (device : PortableDevice) = 
        DevicePropertyValue (
            device.Device.Content()
                .Properties()
                .GetValues("DEVICE",null)
                .GetStringValue(ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()))
            )
    
    let readDeviceProperty (device : PortableDevice) property =                 
        let getValue = device.Device.Content().Properties().GetValues("DEVICE",null)        
        try 
            DevicePropertyValue (getValue.GetStringValue(ref property))
        with
        | ex-> DevicePropertyValue (ex.Message)

//                DevicePropertyValue (
//            device.Device.Content()
//                .Properties()
//                .GetValues("DEVICE",null)
//                .GetStringValue(ref property)
//            )
    

    let readDevicePropertiesFromCategory (device : PortableDevice) (category : string) =
        match category with 
        | "WPD_DEVICE_PROPERTIES_V1" -> 
            PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.PropertyFunctionList 
            |> List.iteri (
                fun i propFun ->
                    System.Console.Write("{0}: ", PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.PropertyNameList.[i] )
                    let (DevicePropertyValue value) = readDeviceProperty device (propFun()) 
                    System.Console.WriteLine("\t{0}", value)
                )
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
    
    let DeviceSequence = 
        seq { 
            let deviceManager = PortableDeviceManagerClass()
            let deviceIDs = Utils.DeviceIdArray(deviceManager)
            if deviceIDs.Length <= 0 then failwith "No portable devices found."
            for i = 0 to deviceIDs.Length - 1 do
                yield { DeviceID = DeviceID deviceIDs.[i]
                        Device = PortableDeviceClass() }
        }
