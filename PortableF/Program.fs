namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDTypes
    
    [<EntryPoint>]
    let main argv = 

//        let device = DeviceSequence |> Seq.head
//        let conn = connectDevice device
//        let getValue = device.Device.Content().Properties().GetValues("DEVICE",null)        
//        let value = getValue.GetFloatValue(ref (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_POWER_LEVEL()) )
//        printfn "%A" value

        //System.Console.ReadLine() |> ignore
        printfn "%A" argv
        DeviceSequence |> Seq.iter (fun device -> 
                              let conn = connectDevice device
                              printfn "Conn: %A" conn
                              let (DevicePropertyValue value) = readDeviceProperty2 device
                              printfn "Value: %s" value
                              readDevicePropertiesFromCategory device "WPD_DEVICE_PROPERTIES_V1" 
                              )
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
