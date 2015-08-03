namespace PortableDevices

module PDGlobalTypes = 
    open PortableDeviceApiLib
    open System.Runtime.InteropServices
    
    type DeviceID = 
        | DeviceID of string
    
    type PortableDevice = 
        { DeviceID : DeviceID
          Device : PortableDeviceClass          
        }

    type ConnectedDevice = 
        { DeviceID : DeviceID
          Device : PortableDeviceClass
          Content : IPortableDeviceContent
          Properties : IPortableDeviceProperties
          Capabilities : IPortableDeviceCapabilities
          Resources : IPortableDeviceResources
        }

//    type ConnectDevice = PortableDevice -> ConnectedDevice    
//    type DisconnectDevice = ConnectedDevice -> PortableDevice    
//    type ReadDeviceProperty = ConnectedDevice -> DevicePropertyName -> Option<DevicePropertyResult>
//    type TransferToBackup = FilePath -> FilePath -> TransferStatus
    
    type PropertyName = 
        | PropertyName of string
    
    type CategoryName = 
        | CategoryName of string
    
    type PropertyValue = 
        | PropertyValue of string
        | PropertyValueGuid of System.Guid
        | PropertyValueBool of bool
        | PropertyValueString of string
        | PropertyValueInt32 of int32
        | PropertyValueInt64 of int64
        | PropertyValueUInt32 of uint32
        | PropertyValueUInt64 of uint64
        | PropertyValueFloat32 of float32
        | PropertyValueFloat64 of decimal //???
        | PropertyValueUnknown of obj
        | PropertyValueUChar of uint8
        | PropertyValueUnexpected of string
        | UnableToReadValue of exn
    
    type PropertyNameValue = 
        { PropertyName : PropertyName
          Value : PropertyValue }
    
    type PropertyNameTag = 
        { Name : string
          Tag : PortableDeviceApiLib._tagpropertykey }
    
    type CategoryNameGuid = 
        { Name : CategoryName
          Guid : System.Guid }
    
    type PortableContentID = 
        | FolderID of string
        | ObjectID of string
    
    let (|DeconstructContentID|) contentID = 
        match contentID with
        | FolderID objID -> objID
        | ObjectID objID -> objID

    let UnbindContentID item =
        match item with
        | FolderID objID -> objID
        | ObjectID objID -> objID

    type SupportedProperties = 
        | SupportedProperties of seq<PropertyNameValue>
    
    type SimplePropertyInfo = 
        { categoryName : string
          propertyName : PropertyName
          result : PropertyValue }
    
    [<StructLayout(LayoutKind.Explicit, Size = 16)>]
    type PropVariant = 
        new() = {  }
        [<DefaultValue; FieldOffset 0>]
        val mutable variantType : int16
        [<DefaultValue; FieldOffset 8>]
        val mutable pointerValue : System.IntPtr
        [<DefaultValue; FieldOffset 8>]
        val mutable byteValue : int8
        [<DefaultValue; FieldOffset 8>]
        val mutable longValue : int64
    
    type PropVariantInfo = 
        { propVariant : PropVariant
          guid : System.Guid
          variantType : int16 }
