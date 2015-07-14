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
    
    let parseObjectID (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        let values = properties.GetValues(objectID, keys)
        (values.GetStringValue(ref PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME), values.GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE))
    
    let contentTypeGuid (properties : IPortableDeviceProperties) (objectID : string) = 
        let keys = properties.GetSupportedProperties(objectID)
        properties.GetValues(objectID, keys).GetGuidValue(ref PDHeader.WPD_OBJECT_CONTENT_TYPE)
    
    //        with ex ->
    //            (ex :?> System.Runtime.InteropServices.COMException).Message, System.Guid.Empty 
    let printEvents device = 
        printfn "Suppoerted Events"
        device.Device.Capabilities().GetSupportedEvents() |> enumeratePropVariantCollection
    
    let parse2 = 
        printfn "%A" (PDHeaderUtils.GetPropertyName2 (new System.Guid(0x27E2E392u, 0xA111us, 0x48E0us, 0xABuy, 0x0Cuy, 0xE1uy, 0x77uy, 0x05uy, 0xA0uy, 0x5Fuy, 0x85uy)) 0u)
        printfn "%A" (PDHeaderUtils.GetPropertyName2 (new System.Guid(0x99ED0160u, 0x17FFus, 0x4C44us, 0x9Duy, 0x98uy, 0x1Duy, 0x7Auy, 0x6Fuy, 0x94uy, 0x19uy, 0x21uy)) 0u)
    
    let f (properties : PortableDeviceApiLib.IPortableDeviceProperties) propertyKey objID = 
        let getValue = properties.GetValues(objID, null)
        let constName = PDHeaderUtils.GetPropertyName propertyKey
        let varenum = PDHeaderUtils.GetPropertyType propertyKey
        
        let value = 
            try 
                getValue.GetStringValue(ref propertyKey) |> ignore
            with ex -> printfn "bool %A" ex.Message
        value
    

    
    
    //| VARENUM.VT_DATE -> getValue.Get(ref propertyKey)
    //        | VARENUM.VT_EMPTY ->  
    //        | VARENUM.VT_ERROR -> 
    //        | VARENUM.VT_XXXX -> 
    //        | VARENUM.VT_R8 -> PropertyValueFloat32(getValue.GetIUnknownValue(ref propertyKey))
    //
    //        try 
    //            PropertyResult(getValue.GetStringValue(ref propertyKey))
    //        with ex -> AccessError(ex.Message)
    //    let readObjectProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) 
    //(propertyKey : PortableDeviceApiLib._tagpropertykey) = 
    //let getValue = properties.GetValues(objID, null)

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
                                  let properties = (device.Device.Content().Properties())

                                  let getTypeFromID objID =                                                                        
                                    GetSupportedPropertyKeys properties (UnbindContentID objID)
                                    |> Seq.map (fun tag -> (PDHeaderUtils.GetPropertyType tag, PDHeaderUtils.GetPropertyName tag, tag, objID))
                                    |> Meta.Temp
                                 
                                  PDContent.ListNodeIDs' (device.Device.Content()) "s10001" true getTypeFromID
                                  |> Seq.collect (fun (Meta.Temp props)->props)
                                  |> (fun collection -> query {
                                            for (varenum, propName, tag, pdID ) in collection do
                                                where (varenum = VARENUM.VT_UI4)
                                                select (propName, pdID)
                                        })
                                  |> Seq.iter (fun (a,b) -> printfn "%A\t%A" a b)

                                  printfn "null null %A" (readDeviceProperty dev PDHeader.WPD_PROPERTY_NULL)

                                  Meta.BruteReadProperty properties "DEVICE"                                   
                                  |> Seq.iter (fun (a,b,c,d) -> printfn "%s\t%A\t%s\t%s" a b c d)
                                  //Seq.iter (fun item -> printfn "%A" item)
                                  //|> Seq.map PDContent.Format.FlattenDirectoryTree
                                  //                                  |> Seq.collect PDContent.Format.PFItoCSV
                                  //                                  |> Seq.map PDContent.Format.ParseGuids
                                  //                                  |> Seq.map PDContent.Format.UnbindCsvContent
                                  //                                  |> Seq.map (fun item -> PDContent.Format.Join "\t" item)
                                  //|> ignore
                                  //|> Seq.iteri (fun i item -> printfn "%i %s" i item)
                                  //System.IO.File.WriteAllLines
                                  //(@"C:\Users\Ares\Documents\Visual Studio 2015\Projects\PortableDevices\FileList.csv", 
                                  //filelist)
                                  //Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  printfn "\n-- Search Over -- ")
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
