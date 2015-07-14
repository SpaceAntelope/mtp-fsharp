namespace PortableDevices

module Meta =     
    open PDGlobalTypes
    open PDUtils

    let BruteReadProperty (properties : PortableDeviceApiLib.IPortableDeviceProperties) (objID : string) = 
        printfn "------- %s ---------" objID        
        let getValue = properties.GetValues(objID, null)
        GetSupportedPropertyKeys properties objID|> Seq.collect (fun propertyKey -> 
               seq { 
                    let (PropertyName constName) = PDHeaderUtils.GetPropertyName propertyKey
                    let varenum = PDHeaderUtils.GetPropertyType propertyKey
                    yield try Some (constName, varenum, "GetBoolValue", string (getValue.GetBoolValue(ref propertyKey))) with ex -> None //printfn "bool  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetErrorValue", string (getValue.GetErrorValue(ref propertyKey))) with ex -> None //printfn "error  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetFloatValue", string (getValue.GetFloatValue(ref propertyKey))) with ex -> None //printfn "float  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetGuidValue", string (getValue.GetGuidValue(ref propertyKey))) with ex -> None //printfn " guid  : %s" ex.Message) 
                    //yield try Some (constName, varenum, "GetHashCode", string (getValue.GetHashCode())) with ex -> None //printfn "hash  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetIUnknownValue", string (getValue.GetIUnknownValue(ref propertyKey))) with ex -> None //printfn "unknown  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetKeyValue", string (getValue.GetKeyValue(ref propertyKey))) with ex -> None //printfn "keyvalue  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetSignedIntegerValue", string (getValue.GetSignedIntegerValue(ref propertyKey))) with ex -> None //printfn "si  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetSignedLargeIntegerValue", string (getValue.GetSignedLargeIntegerValue(ref propertyKey))) with ex -> None //printfn "lsi  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetStringValue", string (getValue.GetStringValue(ref propertyKey))) with ex -> None //printfn "string  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetUnsignedIntegerValue", string (getValue.GetUnsignedIntegerValue(ref propertyKey))) with ex -> None //printfn "ui  : %s" ex.Message) 
                    yield try Some (constName, varenum, "GetUnsignedLargeIntegerValue", string (getValue.GetUnsignedLargeIntegerValue(ref propertyKey))) with ex -> None //printfn "uli  : %s" ex.Message) 
                    //yield try Some (constName, varenum, "GetValue", string (getValue.GetValue(ref propertyKey))) with ex -> None //printfn "value  : %s" ex.Message) 
               })
        |> Seq.choose (fun x -> x)

    type TempType = Temp of seq<PDHeaderIndices.VARENUM * PropertyName * PortableDeviceApiLib._tagpropertykey * PortableContentID>

    let FilterByOriginalFilename properties (filterString:string) objID =          
        match GetSupportedPropertyKeys properties objID |> Seq.exists (fun tag -> tag = PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME) with
        | true -> 
            let (PropertyResult filename) = (PDUtils.readObjectProperty properties objID PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME)
            (filename.ToLower().Contains(filterString.ToLower()))
        | false -> false

    let GetTypeToMethodPropertyRates (device:PortableDevice) rootID filename = 
        let properties = device.Device.Content().Properties()
        let result = 
            PDContent.ListNodeIDs (device.Device.Content()) rootID true
            |> Seq.map UnbindContentID
            |> Seq.filter (FilterByOriginalFilename properties ".jpg")
            |> Seq.collect (BruteReadProperty(properties))
            |> (fun sq -> 
            query { 
                for (_, typeName, methodName, _) in sq do
                    groupBy (typeName, methodName) into grp
                    select (grp.Key, Seq.length grp)
            })
            |> Seq.map (fun ((varenum, str), count) -> sprintf "%A\t%s\t%i" varenum str count)
        System.IO.File.WriteAllLines(sprintf @"C:\Users\Ares\Documents\GitHubVisualStudio\mtp-fsharp\%s.txt" filename, result)
