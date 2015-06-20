namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDTypes
    
    [<EntryPoint>]
    let main argv = 
        printfn "Welcome to FSharp.MTP Testing grounds! %A" argv
        printfn "%A" (PDHeaderUtils.GetPropertyName (System.Guid.Parse("30010000-AE6C-4804-98BA-C57B46965FE7")) 0u)
        System.Console.ReadLine() |> ignore
        DeviceSequence |> Seq.iter (fun device -> 
                              match connectDevice device with
                              | NotConnected dev -> printfn "Could not connect to device %A" device.DeviceID
                              | Connected dev -> 
                                  printfn "Device name: %A" (readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME)
                                  printfn "Power level: %A" (readDeviceProperty dev PDHeader.WPD_DEVICE_POWER_LEVEL)
                                  match (readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME) with
                                  | PropertyResult friendly -> 
                                      System.IO.File.WriteAllLines
                                          (sprintf 
                                               @"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\Property log for %s.txt" 
                                               friendly, 
                                           ListAllPropertyValues dev |> PDUtils.SimplePropertyInfoListToString)
                                  | _ -> ())
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
//                   printfn "Functional Categories:"
//                   listAvailableFunctionalCategories dev |> Seq.iter (printfn "%A")
