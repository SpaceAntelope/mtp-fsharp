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
    
    let bruteReadProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) 
        (propertyKey : PortableDeviceApiLib._tagpropertykey) = 
        let getValue = properties.GetValues(objID, null)
        try 
            getValue.GetBoolValue(ref propertyKey) |> printfn "bool %A"
        with ex -> printfn "bool %A" ex.Message
        try 
            getValue.GetErrorValue(ref propertyKey) |> printfn "error %A"
        with ex -> printfn "error %A" ex.Message
        try 
            getValue.GetFloatValue(ref propertyKey) |> printfn "float %A"
        with ex -> printfn "float %A" ex.Message
        try 
            getValue.GetGuidValue(ref propertyKey) |> printfn " guid %A"
        with ex -> printfn " guid %A" ex.Message
        try 
            getValue.GetHashCode() |> printfn "hash %A"
        with ex -> printfn "hash %A" ex.Message
        try 
            getValue.GetIUnknownValue(ref propertyKey) |> printfn "unknown %A"
        with ex -> printfn "unknown %A" ex.Message
        try 
            getValue.GetKeyValue(ref propertyKey) |> printfn "keyvalue %A"
        with ex -> printfn "keyvalue %A" ex.Message
        try 
            getValue.GetSignedIntegerValue(ref propertyKey) |> printfn "si %A"
        with ex -> printfn "si %A" ex.Message
        try 
            getValue.GetSignedLargeIntegerValue(ref propertyKey) |> printfn "lsi %A"
        with ex -> printfn "lsi %A" ex.Message
        try 
            getValue.GetStringValue(ref propertyKey) |> printfn "string %A"
        with ex -> printfn "string %A" ex.Message
        try 
            getValue.GetUnsignedIntegerValue(ref propertyKey) |> printfn "ui %A"
        with ex -> printfn "ui %A" ex.Message
        try 
            getValue.GetUnsignedLargeIntegerValue(ref propertyKey) |> printfn "uli %A"
        with ex -> printfn "uli %A" ex.Message
        try 
            getValue.GetValue(ref propertyKey) |> printfn "value %A"
        with ex -> printfn "value %A" ex.Message
    
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
                                  //let objects = device.Device.Content().EnumObjects(0u, "DEVICE", null)
                                  //printFunctionalCategories device
                                  //enumerateContent (device.Device.Content()) "DEVICE" "DEVICE" ""
                                  //enumerateContent (device.Device.Content()) "root" "s10001" ""
                                  //listContentInfo (device.Device.Content()) "DEVICE" "" true |> Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  //listContentInfo (device.Device.Content()) "s10001" "" false |> Seq.iter (printfn "%A")
                                  //Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  printfn "\n-- Search Over -- "
                                  PDHeaderIndices.PropertyTypeIndex.Values
                                  |> Seq.distinct
                                  |> Seq.iter (printfn "%A")
                                  printfn "\n-- Type List Over -- "
                                  PDContent.Format.SupportedTypes (device.Device.Content().Properties()) "s10001" 
                                  |> Seq.iter (printfn "-------> %A")
                                  
                                  
                                  bruteReadProperty (device.Device.Content().Properties()) "DEVICE" 
                                      PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME
                                  
                                  
                                  PDContent.ListContentInfo (device.Device.Content()) "s10001" true
                                  |> Seq.map PDContent.Format.FlattenDirectoryTree
                                  |> Seq.collect PDContent.Format.PFItoCSV
                                  |> Seq.map PDContent.Format.ParseGuids
                                  |> Seq.map PDContent.Format.UnbindCsvContent
                                  |> Seq.map (fun item -> PDContent.Format.Join "\t" item)
                                  |> ignore
                                  //|> Seq.iteri (fun i item -> printfn "%i %s" i item)
                                  //System.IO.File.WriteAllLines
                                  //(@"C:\Users\Ares\Documents\Visual Studio 2015\Projects\PortableDevices\FileList.csv", 
                                  //filelist)
                                  //Seq.iter (fun props -> props |> Seq.iter (printfn "%A"))
                                  printfn "\n-- Search Over -- ")
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
