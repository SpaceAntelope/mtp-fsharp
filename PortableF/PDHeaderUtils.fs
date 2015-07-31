namespace PortableDevices

    module PDHeaderUtils =
        open PDGlobalTypes
    
        let GetGuidName guid = 
            match (PDHeaderIndices.GuidNameIndex.ContainsKey guid) with
            | true -> PDHeaderIndices.GuidNameIndex.[guid]
            | _ -> guid.ToString()
    
        let GetGuidPropVariants guid = 
            match (PDHeaderIndices.CategoryPropertiesIndex.ContainsKey guid) with
            | true -> PDHeaderIndices.CategoryPropertiesIndex.[guid]
            | _ -> Array.empty
    
        let GetPropertyName tag = 
            match (PDHeaderIndices.PropertyNameIndex.ContainsKey tag) with
            | true -> PropertyName PDHeaderIndices.PropertyNameIndex.[tag]
            | _ -> PropertyName (sprintf "%A %A" tag.fmtid tag.pid)
    
        let GetPropertyType tag = 
            match (PDHeaderIndices.PropertyTypeIndex.ContainsKey tag) with
            | true -> PDHeaderIndices.PropertyTypeIndex.[tag]
            | _ -> PDHeaderIndices.VARENUM.VT_UNKNOWN
    
        let GetPropertyName2 guid pv = GetPropertyName(new PortableDeviceApiLib._tagpropertykey(fmtid = guid, pid = pv))
        let GetPropertyType2 guid pv = GetPropertyType(new PortableDeviceApiLib._tagpropertykey(fmtid = guid, pid = pv))
        let (|MatchGuids|) (guid1 : System.Guid) (guid2 : System.Guid) = guid1.CompareTo(guid2) = 0
        let (|MatchPropertyKey|) (tag : PortableDeviceApiLib._tagpropertykey) = GetPropertyName tag

    module PDHeaderReflection = 
        open PDGlobalTypes
    
        let ListAllPropertyKeys = 
            System.Reflection.Assembly.GetExecutingAssembly().GetType("PortableDevices.PDHeader").GetMethods()
            |> Array.filter (fun info -> info.ReturnType.Name = "_tagpropertykey")
            |> Array.map (fun info -> 
                   { Name = info.Name
                     Tag = (info.Invoke(null, null) :?> PortableDeviceApiLib._tagpropertykey) })
    
        let ListAllGuids = 
            System.Reflection.Assembly.GetExecutingAssembly().GetType("PortableDevices.PDHeader").GetMethods()
            |> Array.filter (fun info -> info.ReturnType.Name = "Guid")
            |> Array.map (fun info -> 
                   { Name = CategoryName (info.Name.Substring(4))
                     Guid = info.Invoke(null, null) :?> System.Guid })
