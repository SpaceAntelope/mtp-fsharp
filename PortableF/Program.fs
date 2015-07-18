namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDGlobalTypes
    open PDHeaderIndices
    
    let printFunctionalCategories device = 
        printfn "Functional categories"
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.iter (fun prop -> 
               printfn "cat: %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))
               device.Device.Capabilities().GetFunctionalObjects(ref prop.guid)
               |> enumeratePropVariantCollection
               |> Seq.iter (fun prop -> printfn "\tprop: %A %A" prop.guid (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))))
    
    let printEvents' device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents()
        |> enumeratePropVariantCollection
        |> Seq.iter (fun prop -> printfn "event : %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType)))
    
    [<EntryPoint>]
    let main argv = 
        DeviceIdArray 
        |> Array.iter (fun devID -> 
                              match connectDevice devID with
                              | NotConnected device -> printfn "Could not connect to device %A" device.DeviceID
                              | Connected device -> 
                                  printfn ""
                                  printfn "Device name: %A" (readDeviceProperty device PDHeader.WPD_DEVICE_FRIENDLY_NAME)
                                  printfn "-----------------------"
                                  
                                  PDContent.ListNodeIDs device "oDCCF" false
                                  |> Seq.map (fun (ObjectID objID | FolderID objID) -> objID, readObjectProperties device objID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME; PDHeader.WPD_OBJECT_SIZE |])
                                  |> Seq.iter (printfn "%A")
                                 
                                  printfn "%A." (GetFile device (ObjectID "oDD48") (FilePath @"C:\Users\Ares\Documents\Visual Studio 2015\Projects"))
                                  
                                  !(DeleteFile device (ObjectID "oDD48")) |> ignore//enumeratePropVariantCollection |> Seq.iter (printfn "%A")
                                 
                                  printfn "\n-- Search Over -- ")
        System.Console.ReadLine() |> ignore
        0 