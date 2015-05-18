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
    
    let readDeviceProperty (device : PortableDevice) = 
        let mutable content = PDInterfaceInstanceProvider.PortableDeviceContentDummyPointer()
        let mutable properties = PDInterfaceInstanceProvider.PortableDevicePropertiesDummyPointer()
        let mutable propertyValues = PDInterfaceInstanceProvider.PortableDeviceValuesDummyPointer()
        let mutable propertyValue = ""
        device.Device.Content(&content)
        content.Properties(&properties)
        properties.GetValues("DEVICE", null, &propertyValues)
        propertyValues.GetStringValue
            (ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()), &propertyValue)
        DevicePropertyValue propertyValue
    
    let DeviceSequence = 
        seq { 
            let deviceManager = PortableDeviceManagerClass()
            let deviceIDs = Utils.DeviceIdArray(deviceManager)
            if deviceIDs.Length <= 0 then failwith "No portable devices found."
            for i = 0 to deviceIDs.Length - 1 do
                yield { DeviceID = DeviceID deviceIDs.[i]
                        Device = PortableDeviceClass() }
        }
