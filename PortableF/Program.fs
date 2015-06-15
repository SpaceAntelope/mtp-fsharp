namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDTypes
    
    [<EntryPoint>]
    let main argv = 
        printfn "%A" argv
        DeviceSequence |> Seq.iter (fun device -> 
                              match connectDevice device with
                              | NotConnected dev -> printfn "Could not connect to device %A" device.DeviceID
                              | Connected dev ->
                                    printfn "%A" (readDevicProperty dev (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()))
                                    listAvailableFunctionalCategories dev

                                    //readDevicePropertiesFromCategory device "WPD_DEVICE_PROPERTIES_V1" 
                                    //readDevicePropertiesFromCategory device "WPD_DEVICE_PROPERTIES_V2" 

                              //let conn = connectDevice device
                              //printfn "Conn: %A" conn

//                              listAvailableFunctionalCategories device |> printfn "%s"
                              )
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
