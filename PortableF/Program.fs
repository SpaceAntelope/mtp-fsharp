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
    
   
    //| VARENUM.VT_DATE -> getValue.Get(ref propertyKey)
    //        | VARENUM.VT_EMPTY ->  
    //        | VARENUM.VT_ERROR -> 
    //        | VARENUM.VT_XXXX -> 
    //        | VARENUM.VT_R8 -> PropertyValueFloat32(getValue.GetIUnknownValue(ref propertyKey))

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
//                                  |> Seq.filter (fun objId -> 
//                                         match objId with
//                                         | ObjectID _ -> true
//                                         | _ -> false)
                                  |> Seq.map (fun (ObjectID objID | FolderID objID) -> objID, readObjectProperties device objID [| PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME; PDHeader.WPD_OBJECT_SIZE |])
                                  |> Seq.iter (printfn "%A")
                                 
                                  printfn "0000000000000000000000 %A." (GetFile device (ObjectID "oDD48") (FilePath @"C:\Users\Ares\Documents\Visual Studio 2015\Projects"))
                                  
                                  !(DeleteFile device (ObjectID "oDD48")) |> ignore//enumeratePropVariantCollection |> Seq.iter (printfn "%A")
                                  //|> Seq.iter (fun (PropertyValue str) -> printfn "%s" str)
                                  //|> Seq.filter (fun (PropertyValue str) -> not (str.ToLower().Contains(".jpg")))
                                   //                                  PDContent.ListContentInfo (device.Device.Content()) "s10001" true
                                   //                                  |> Seq.map PDContent.Format.FlattenDirectoryTree
                                   //                                  |> Seq.map PDContent.Format.PFItoCSV
                                   //                                  |> Seq.collect (fun x -> x)
                                   //                                  |> Seq.filter(fun x -> match x with PDContent.Format.CsvLine _ -> true | _ -> false)
                                   //                                  |> Seq.filter(fun ( PDContent.Format.CsvLine item) -> not (item.ToString().Contains(".JPG")))
                                   ////                                        (item 
                                   ////                                        |> Seq.map (fun (PropertyValue x) -> x) 
                                   ////                                        |> Seq.findIndex(fun x-> not (x.Contains(".jpg" )))) > -1 )
                                   //                                  |> Seq.iter (fun ( PDContent.Format.CsvLine item) -> printfn ""; item |> Seq.iter (fun x-> printfn "%A" x))
                                   //                                  
                                  //System.Console.ReadLine() |> ignore
                                  ////                                  let getTypeFromID objID =                                                                        
                                  //                                    GetSupportedPropertyKeys properties (UnbindContentID objID)
                                  //                                    |> Seq.map (fun tag -> (PDHeaderUtils.GetPropertyType tag, PDHeaderUtils.GetPropertyName tag, tag, objID))
                                  //                                    |> Meta.Temp
                                  //                                 
                                  //                                  PDContent.ListNodeIDs' (device.Device.Content()) "s10001" true getTypeFromID
                                  //                                  |> Seq.collect (fun (Meta.Temp props)->props)
                                  //                                  |> (fun collection -> query {
                                  //                                            for (varenum, propName, tag, pdID ) in collection do
                                  //                                                where (varenum = VARENUM.VT_UI4)
                                  //                                                select (propName, pdID)
                                  //                                        })
                                  //                                  |> Seq.iter (fun (a,b) -> printfn "%A\t%A" a b)
                                  //
                                  //                                  printfn "null null %A" (readDeviceProperty dev PDHeader.WPD_PROPERTY_NULL)
                                  //
                                  //                                  Meta.BruteReadProperty properties "DEVICE"                                   
                                  //                                  |> Seq.iter (fun (a,b,c,d) -> printfn "%s\t%A\t%s\t%s" a b c d)
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
