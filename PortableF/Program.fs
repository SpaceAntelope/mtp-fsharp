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
    
    let f (properties : PortableDeviceApiLib.IPortableDeviceProperties) propertyKey objID = 
        let getValue = properties.GetValues(objID, null)
        let constName = PDHeaderUtils.GetPropertyName propertyKey
        let varenum = PDHeaderUtils.GetPropertyType propertyKey
        
        let value = 
            try 
                getValue.GetStringValue(ref propertyKey) |> ignore
            with ex -> printfn "bool %A" ex.Message
        value
    
    let BruteReadProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) = 
        GetSupportedPropertyKeys properties objID
        |> Seq.collect (fun propertyKey -> 
               seq { 
                   let getValue = properties.GetValues(objID, null)
                   let (PropertyName constName) = PDHeaderUtils.GetPropertyName propertyKey
                   let varenum = PDHeaderUtils.GetPropertyType propertyKey
                   yield try 
                             Some(constName, varenum, string (getValue.GetBoolValue(ref propertyKey)))
                         with ex -> 
                             //printfn "bool  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetErrorValue(ref propertyKey)))
                         with ex -> 
                             //printfn "error  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetFloatValue(ref propertyKey)))
                         with ex -> 
                             //printfn "float  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetGuidValue(ref propertyKey)))
                         with ex -> 
                             //printfn " guid  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetHashCode()))
                         with ex -> 
                             //printfn "hash  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetIUnknownValue(ref propertyKey)))
                         with ex -> 
                             //printfn "unknown  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetKeyValue(ref propertyKey)))
                         with ex -> 
                             //printfn "keyvalue  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetSignedIntegerValue(ref propertyKey)))
                         with ex -> 
                             //printfn "si  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetSignedLargeIntegerValue(ref propertyKey)))
                         with ex -> 
                             //printfn "lsi  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetStringValue(ref propertyKey)))
                         with ex -> 
                             //printfn "string  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetUnsignedIntegerValue(ref propertyKey)))
                         with ex -> 
                             //printfn "ui  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetUnsignedLargeIntegerValue(ref propertyKey)))
                         with ex -> 
                             //printfn "uli  : %s" ex.Message
                             None
                   yield try 
                             Some(constName, varenum, string (getValue.GetValue(ref propertyKey)))
                         with ex -> 
                             //printfn "value  : %s" ex.Message
                             None
               })
        |> Seq.choose (fun x -> x)
    
    let readObjectProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) 
        (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = properties.GetValues(objID, null)
        match PDHeaderUtils.GetPropertyType propertyKey with
        | VARENUM.VT_BOOL -> PropertyValueInt(getValue.GetBoolValue(ref propertyKey))
        | VARENUM.VT_CLSID -> PropertyValueGuid(getValue.GetGuidValue(ref propertyKey))
    
    //| VARENUM.VT_DATE -> getValue.Get(ref propertyKey)
    //        | VARENUM.VT_EMPTY -> 
    //        | VARENUM.VT_ERROR -> 
    //        | VARENUM.VT_I4 -> 
    //        | VARENUM.VT_I8 -> 
    //        | VARENUM.VT_LPWSTR -> 
    //        | VARENUM.VT_R4 -> 
    //        | VARENUM.VT_R8 -> 
    //        | VARENUM.VT_UI4 -> 
    //        | VARENUM.VT_UI8 -> 
    //        | VARENUM.VT_UNKNOWN -> 
    //        | VARENUM.VT_VECTOR | VT_UI1 -> 
    //        | VARENUM.VT_XXXX -> 
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
                                  PDContent.ListNodeIDs (device.Device.Content()) "DEVICE" true
                                  |> Seq.map 
                                         (fun item -> 
                                         match item with
                                         | PDContent.FolderID objID -> 
                                             BruteReadProperty (device.Device.Content().Properties()) objID
                                         | PDContent.ObjectID objID -> 
                                             BruteReadProperty (device.Device.Content().Properties()) objID)
                                  |> Seq.iteri (fun i item -> printfn "%i %A" i item)
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
