namespace PortableDevices
//
//open PortableDeviceApiLib
//open PortableDeviceTypesLib
//
//module main = 
//    open PDUtils
//    open PDGlobalTypes
//    open PDHeaderIndices
//    
//    let printFunctionalCategories device = 
//        printfn "Functional categories"
//        device.Device.Capabilities().GetFunctionalCategories()
//        |> enumeratePropVariantCollection
//        |> Seq.iter (fun prop -> 
//               printfn "cat: %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))
//               device.Device.Capabilities().GetFunctionalObjects(ref prop.guid)
//               |> enumeratePropVariantCollection
//               |> Seq.iter (fun prop -> printfn "\tprop: %A %A" prop.guid (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))))
//    
//    let printEvents' device = 
//        printfn "Suppoerted Events"
//        device.Device.Capabilities().GetSupportedEvents()
//        |> enumeratePropVariantCollection
//        |> Seq.iter (fun prop -> printfn "event : %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType)))
//    
//    [<EntryPoint>]
//    let main argv = 
//        DeviceIdArray |> Array.iter (fun devID -> 
//                             match ConnectDevice devID with
//                             | None -> printfn "-- Could not connect to device %A --" devID
//                             | Some device -> 
//                                 printfn "-- Connection a Success --"
//                                 printfn "Device name: %A" (readDeviceProperty device PDHeader.WPD_DEVICE_FRIENDLY_NAME)
//                                 printfn "--------------------------"
//
////                                 PDContent.ListNodeIDs device false (FolderID "oDCCF") 
////                                 |> Seq.head
////                                 |> PDContent.Utils.CopyObjectInDevice' device (FolderID "s20001")
//
//
//                                 PDContent.ListNodeIDs device false (FolderID "s10001") 
//                                 |> Seq.iter (fun objID ->            
//                                        let (FolderID objID' | ObjectID objID') = objID
//                                        let fileName = readObjectProperty device objID' PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
//                                        let isWritable = PDContent.Utils.IsPropertyWritable device objID PDHeader.WPD_OBJECT_PARENT_ID
//                                        printfn "%A for file %A parent_id writability is %A" objID fileName isWritable)
//                                
//
//                                 
//                                 enumerateSupportedCommands device
//                                 |> Seq.map (fun tag -> PDHeaderUtils.GetPropertyName tag)
//                                 |> Seq.map (fun (PropertyName prop) -> prop)
//                                 |> Seq.iter (printfn "%s")
////                                 let folderID = PDContent.Utils.CreateFolder device "TestFolder" (FolderID "s10001")
////                                 PDContent.Utils.SendFile device folderID (new System.IO.FileInfo("TestFile.txt"))
////                                 
////                                 PDContent.Utils.DeleteObject device folderID true |> ignore
////                                 
////                                 match PDContent.SearchItemByName device "TestFolder" (FolderID "s10001") with
////                                 | Some(FolderID folderID | ObjectID folderID) -> 
////                                     printfn "%A" (readObjectProperties device folderID [| PDHeader.WPD_OBJECT_NAME; PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME |])
////                                     match PDContent.SearchItemByName device "TestFile.txt" (FolderID folderID) with
////                                     | Some(FolderID objID | ObjectID objID) -> 
////                                         printfn "%A" (readObjectProperties device objID [| PDHeader.WPD_OBJECT_NAME; PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME |])
////                                         PDContent.Utils.DeleteObject device (ObjectID objID) false |> ignore
////                                     | None -> printfn "%s" "TestFile not found"
////                                 | None -> printfn "%s" "TestFolder not found"
////                                 PDContent.Utils.DeleteObject device folderID false |> ignore
////
////                                 match PDContent.SearchItemByName device "TestFolder" (FolderID "s10001") with
////                                 | Some(FolderID folderID | ObjectID folderID) -> 
////                                     printfn "%A" (readObjectProperties device folderID [| PDHeader.WPD_OBJECT_NAME; PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME |])
////                                     printfn "Failed to delete..."
////                                     match PDContent.SearchItemByName device "TestFile.txt" (FolderID folderID) with
////                                     | Some(FolderID objID | ObjectID objID) -> 
////                                         printfn "%A" (readObjectProperties device objID [| PDHeader.WPD_OBJECT_NAME; PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME |])
////                                         printfn "Failed to delete..."
////                                     | None -> printfn "%s" "TestFile not found - deletion successful!"
////                                 | None -> printfn "%s" "TestFolder not found - deletion successful!"
//
//                                 device.Device.Close()
//                                 printfn "\n-- Search Over -- ")
//        printfn "\n-- Accounted for %d Devices -- " (Array.length DeviceIdArray)
//        printfn "\nPress any key to exit."
//        System.Console.ReadLine() |> ignore
//        0
