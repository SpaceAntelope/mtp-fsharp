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
                                  printfn "Device name: %A" (readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME) // (PortableDeviceHeader.WPD_DEVICE_PROPERTIES_V1.WPD_DEVICE_FRIENDLY_NAME()))
                                  printfn "Functional Categories:"
                                  listAvailableFunctionalCategories dev |> Seq.iter (printfn "%A")
                                  readDevicePropertiesFromCategory dev PDHeader.WPD_DEVICE_PROPERTIES_V1
                                  |> Seq.filter (fun propInfo -> 
                                         match propInfo.value with
                                         | DevicePropertyValue value -> true
                                         | _ -> printfn "%A not found" propInfo.name; false)
                                  |> Seq.iter (fun item  -> printfn "%s %A %A" item.categoryName item.name item.value ))
        //readDevicePropertiesFromCategory device "WPD_DEVICE_PROPERTIES_V2" 
        //let conn = connectDevice device
        //printfn "Conn: %A" conn
        //                              listAvailableFunctionalCategories device |> printfn "%s"
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
