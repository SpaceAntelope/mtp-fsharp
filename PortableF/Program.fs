﻿namespace PortableDevices

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
        DeviceIdArray |> Array.iter (fun devID -> 
                             match connectDevice devID with
                             | NotConnected device -> printfn "-- Could not connect to device %A --" device.DeviceID
                             | Connected device -> 
                                 printfn "-- Connection a Success --"
                                 printfn "Device name: %A" (readDeviceProperty device PDHeader.WPD_DEVICE_FRIENDLY_NAME)
                                 printfn "--------------------------"
                                 PDContent.ListNodeIDs device false "s20001"
                                 |> Seq.map (fun nodeID -> 
                                        match nodeID with
                                        | ObjectID objID -> objID, readObjectProperties device objID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME; PDHeader.WPD_OBJECT_SIZE |]
                                        | FolderID objID -> objID, readObjectProperties device objID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME |])
                                 |> Seq.iter (printfn "%A")
                                 //printfn "%A." (GetFile device (ObjectID "oDD48") (FilePath @"C:\Users\Ares\Documents\Visual Studio 2015\Projects"))
                                 //                                  !(DeleteFile device (ObjectID "oDD48")) |> ignore//enumeratePropVariantCollection |> Seq.iter (printfn "%A")
                                 new System.IO.FileInfo(@"C:\Users\Ares\Desktop\jJJ3pD5.png")
                                 |> PDContent.Utils.SendFile device (FolderID "oDCCF")
                                 |> ObjectID
                                 |> PDContent.GeneralProperties.CreateFromObjectID device 
                                 |> printfn "%A"
                                 
                                 PDContent.ListChildren device "oDCCF" |> Seq.iter ( fun info-> printfn "%A" info)
//                                 PDContent.ListContentInfo device false "oDCCF" |> Seq.iter (fun (PDContent.FileInfo props) -> 
//                                                                                       printfn "%A" props.ParentDirectoryID
//                                                                                       props.SupportedProperties |> Array.iter (fun prop -> printfn "%A: %A:" prop.PropertyName prop.Value))
                                 //                                 PDContent.ListNodeIDs device false "oDCCF"
                                 //                                 |> Seq.map (fun (ObjectID objID | FolderID objID) -> enumerateSupportedProperties device objID)
                                 //                                 |> Seq.iter (fun (props) -> printfn "%A" props)
                                 device.Device.Close()
                                 printfn "\n-- Search Over -- ")
        printfn "\n-- Accounted for %d Devices -- " (Array.length DeviceIdArray)
        printfn "\nPress any key to exit."
        System.Console.ReadLine() |> ignore
        0
