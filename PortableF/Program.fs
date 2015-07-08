namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDGlobalTypes
    
    let printFunctionalCategories device = 
        printfn "Functional categories"
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.iter 
               (fun prop -> 
               printfn "cat: %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))
               device.Device.Capabilities().GetFunctionalObjects(ref prop.guid)
               |> enumeratePropVariantCollection
               |> Seq.iter 
                      (fun prop -> 
                      printfn "\tprop: %A %A" prop.guid 
                          (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType))))
    
    let printEvents' device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents()
        |> enumeratePropVariantCollection
        |> Seq.iter 
               (fun prop -> printfn "event : %A" (PDHeaderUtils.GetPropertyName2 prop.guid (uint32 prop.variantType)))
    
    let enumerateSupportedProperties (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        properties.GetSupportedProperties(objectID)
        |> PDUtils.enumerateKeyCollection
        |> Seq.map (fun tag -> (PDHeaderUtils.GetPropertyName tag), (values.GetStringValue(ref tag)))
    
    let parseObjectID (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        (values.GetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME), 
         values.GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE))
    
    let contentTypeGuid (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        properties.GetValues(objectID, keys).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
    
    //        with ex ->
    //            (ex :?> System.Runtime.InteropServices.COMException).Message, System.Guid.Empty 
    let printEvents device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents() |> enumeratePropVariantCollection
    
    let parse2 = 
        printfn "%A" 
            (PDHeaderUtils.GetPropertyName2 
                 (new System.Guid(0x27E2E392u, 0xA111us, 0x48E0us, 0xABuy, 0x0Cuy, 0xE1uy, 0x77uy, 0x05uy, 0xA0uy, 
                                  0x5Fuy, 0x85uy)) 0u)
        printfn "%A" 
            (PDHeaderUtils.GetPropertyName2 
                 (new System.Guid(0x99ED0160u, 0x17FFus, 0x4C44us, 0x9Duy, 0x98uy, 0x1Duy, 0x7Auy, 0x6Fuy, 0x94uy, 
                                  0x19uy, 0x21uy)) 0u)
    

    
    
    
    [<EntryPoint>]
    let main argv = 
        DeviceSequence |> Seq.iter (fun device -> 
                              match connectDevice device with
                              | NotConnected dev -> printfn "Could not connect to device %A" device.DeviceID
                              | Connected dev -> 
                                  printfn ""
                                  printfn "Device name: %A" (readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME)
                                  printfn "-----------------------"
                                  let (ConnectedDevice device) = dev
                                  //let objects = device.Device.Content().EnumObjects(0u, "DEVICE", null)
                                  //printFunctionalCategories device
                                  //enumerateContent (device.Device.Content()) "DEVICE" "DEVICE" ""
                                  //enumerateContent (device.Device.Content()) "root" "s10001" ""
                                  //listContentInfo (device.Device.Content()) "DEVICE" "" true |> Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  //listContentInfo (device.Device.Content()) "s10001" "" false |> Seq.iter (printfn "%A")
                                  //Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  printfn "\n-- Search Over -- "
                                  
                                  
                                   
                                  PDContent.ListContentInfo  (device.Device.Content()) "s10001" true 
                                  |> Seq.map PDContent.Format.FlattenDirectoryTree
                                  |> Seq.collect PDContent.Format.PFItoCSV
                                  |> Seq.map (fun item ->  PDContent.Format.TabJoin item)
                                  |> Seq.iteri (fun i item -> printfn "%i %A" i item)
//                                      |> PFItoCSV
//                                      |> Seq.map ParseGuids
                                  // |> Seq.iter (printfn "%A")
                                  //System.IO.File.WriteAllLines
                                      //(@"C:\Users\Ares\Documents\Visual Studio 2015\Projects\PortableDevices\FileList.csv", 
                                       //filelist)
                                  //Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  printfn "\n-- Search Over -- ")
        //depthFirst (device.Device.Content())
        //printEvents device)
        //                                  printfn "Functional objects"
        //                                  device.Device.Capabilities().GetFunctionalObjects()
        //                                  |> enumeratePropVariantCollection
        //                                  |> Seq.map (PDHeaderUtils.ParsePropertyKey)
        //                                  |> Seq.iter (printfn "%A"))
        //                                  device.Device.Capabilities().GetFunctionalCategories()
        //                                  |> enumeratePropVariantCollection
        //                                  |> Seq.map 
        //                                         (fun category -> 
        //                                         PDHeaderUtils.GetPropertyName (category.guid) (uint32 category.variantType))
        //                                  |> Seq.iter (printfn "%A")
        //                                  match (readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME) with
        //                                  | PropertyResult friendly -> 
        //                                      System.IO.File.WriteAllLines
        //                                          (sprintf 
        //                                               @"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\Property log for %s.txt" 
        //                                               friendly, 
        //                                           ListAllPropertyValues dev |> PDUtils.SimplePropertyInfoListToString)
        //                                  | _ -> ())
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
//                   printfn "Functional Categories:"
//                   listAvailableFunctionalCategories dev |> Seq.iter (printfn "%A")
