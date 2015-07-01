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
    
    let GetPropertyName guid pv = 
        let tag = new PortableDeviceApiLib._tagpropertykey(fmtid = guid, pid = pv)
        match (PDHeaderIndices.PropertyNameIndex.ContainsKey tag) with
        | true -> PDHeaderIndices.PropertyNameIndex.[tag]
        | _ -> tag.ToString()
    
    let GetPropertyName2 tag = 
        match (PDHeaderIndices.PropertyNameIndex.ContainsKey tag) with
        | true -> PDHeaderIndices.PropertyNameIndex.[tag]
        | _ -> tag.ToString()
    
    let (|MatchGuids|) (guid1 : System.Guid) (guid2 : System.Guid) = guid1.CompareTo(guid2) = 0
    let (|MatchPropertyKey|) (tag : PortableDeviceApiLib._tagpropertykey) = GetPropertyName2 tag
