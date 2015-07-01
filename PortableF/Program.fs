namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDTypes
    
    let printFunctionalCategories device = 
        printfn "Functional categories"
        device.Device.Capabilities().GetFunctionalCategories()
        |> enumeratePropVariantCollection
        |> Seq.iter 
               (fun prop -> 
               printfn "cat: %A" (PDHeaderUtils.GetPropertyName prop.guid (uint32 prop.variantType))
               device.Device.Capabilities().GetFunctionalObjects(ref prop.guid)
               |> enumeratePropVariantCollection
               |> Seq.iter 
                      (fun prop -> 
                      printfn "\tprop: %A %A" prop.guid 
                          (PDHeaderUtils.GetPropertyName prop.guid (uint32 prop.variantType))))
    
    let printEvents' device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents()
        |> enumeratePropVariantCollection
        |> Seq.iter 
               (fun prop -> printfn "event : %A" (PDHeaderUtils.GetPropertyName prop.guid (uint32 prop.variantType)))
    
    let enumerateSupportedProperties (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        properties.GetSupportedProperties(objectID)
        |> PDUtils.enumerateKeyCollection
        |> Seq.map (fun tag -> (PDHeaderUtils.GetPropertyName2 tag), (values.GetStringValue(ref tag)))
    
    let parseObjectID (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        (values.GetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME), 
         values.GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE))
    
    let contentTypeGuid (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        values.GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
    
    //        with ex ->
    //            (ex :?> System.Runtime.InteropServices.COMException).Message, System.Guid.Empty 
    let printEvents device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents() |> enumeratePropVariantCollection
    
    let parse2 = 
        printfn "%A" 
            (PDHeaderUtils.GetPropertyName 
                 (new System.Guid(0x27E2E392u, 0xA111us, 0x48E0us, 0xABuy, 0x0Cuy, 0xE1uy, 0x77uy, 0x05uy, 0xA0uy, 
                                  0x5Fuy, 0x85uy)) 0u)
        printfn "%A" 
            (PDHeaderUtils.GetPropertyName 
                 (new System.Guid(0x99ED0160u, 0x17FFus, 0x4C44us, 0x9Duy, 0x98uy, 0x1Duy, 0x7Auy, 0x6Fuy, 0x94uy, 
                                  0x19uy, 0x21uy)) 0u)
    
    let rec enumerateContent (content : IPortableDeviceContent) (name : string) (objectID : string) (depth : string) = 
        printfn "%s %s >" depth name //objectID
        let objects = content.EnumObjects(0u, objectID, null)
        let fetched = ref 1u
        let objID = ref ""
        let mutable fetchLimit = 25
        while !fetched > 0u && fetchLimit > 0 do
            fetchLimit <- fetchLimit - 1
            objects.Next(1u, objID, fetched)
            printfn "property %A" readObjectProperty
            if System.String.IsNullOrEmpty(!objID) = false then 
                let (name, contentType) = parseObjectID (content.Properties()) !objID
                match contentType with
                | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true -> //when name <> "DCIM" && name <> "cache" ->  
                    enumerateContent content name !objID (sprintf "%s\t" depth)
                | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT true -> 
                    printfn "%s\t%s" depth name
                | _ -> printfn "%s\t%s %s %s" depth name !objID (PDHeaderUtils.GetGuidName contentType)
    
    let rec listContentInfo (content : IPortableDeviceContent) (parentID : string) (filter : string -> bool) 
            (listRec : bool) = 
        seq { 
            let properties = content.Properties()
            let objects = content.EnumObjects(0u, parentID, null)
            let fetched = ref 1u
            let objID = ref ""
            while !fetched > 0u do
                objects.Next(1u, objID, fetched)
                if System.String.IsNullOrEmpty(!objID) = false then 
                    match (contentTypeGuid properties !objID) with
                    | PDHeaderUtils.MatchGuids PDHeader.WPD_CONTENT_TYPE_FOLDER true when listRec = true -> 
                        yield PortableFileInfo(enumerateSupportedProperties properties !objID)
                        yield! listContentInfo content !objID filter listRec
                    | _ -> yield PortableFileInfo(enumerateSupportedProperties properties !objID)
        }
    
    let PFItoCSV(input : seq<PortableFileInfo>) = 
        seq { 
            yield input
                  |> Seq.map (fun (PortableFileInfo pfi) -> pfi)
                  |> (Seq.nth 0)
                  |> Seq.map (fun item -> fst item)
            //  |> tabJoin
            for (PortableFileInfo info) in input do
                yield info |> Seq.map (fun item -> snd item)
        }
    
    //  |> tabJoin
    let ParseGuids(input : seq<string>) = 
        input |> Seq.map (fun item -> 
                     let m = 
                         System.Text.RegularExpressions.Regex.Match
                             (item, "[A-Fa-f0-9]{8}\-([A-Fa-f0-9]{4}\-){3}[A-Fa-f0-9]{12}")
                     match (m.Success) with
                     | true -> 
                         printf "%s" m.Value
                         PDHeaderUtils.GetGuidName(System.Guid.Parse(m.Value))
                     | _ -> item)
    
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
                                  let tabJoin = Seq.reduce (fun state item -> sprintf "%s,%s" state item)
                                  
                                  let filelist = 
                                      listContentInfo (device.Device.Content()) "s10001" (fun str -> true) true
                                      |> PFItoCSV
                                      |> Seq.map ParseGuids
                                      |> Seq.map tabJoin
                                  // |> Seq.iter (printfn "%A")
                                  System.IO.File.WriteAllLines
                                      (@"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\FileList.csv", 
                                       filelist)
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
