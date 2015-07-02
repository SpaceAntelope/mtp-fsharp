namespace PortableDevices

module PDHeaderUtils = 
    open PortableDevices.PDHeader
    
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
        | true -> PDHeaderIndices.PropertyNameIndex.[tag]
        | _ -> tag.ToString()
    
    let GetPropertyType tag = 
        match (PDHeaderIndices.PropertyTypeIndex.ContainsKey tag) with
        | true -> PDHeaderIndices.PropertyTypeIndex.[tag]
        | _ -> tag.ToString()
    
    let GetPropertyName2 guid pv = GetPropertyName(new PortableDeviceApiLib._tagpropertykey(fmtid = guid, pid = pv))
    let GetPropertyType2 guid pv = GetPropertyType(new PortableDeviceApiLib._tagpropertykey(fmtid = guid, pid = pv))
    let (|MatchGuids|) (guid1 : System.Guid) (guid2 : System.Guid) = guid1.CompareTo(guid2) = 0
    let (|MatchPropertyKey|) (tag : PortableDeviceApiLib._tagpropertykey) = GetPropertyName tag
