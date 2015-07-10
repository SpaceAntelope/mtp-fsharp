namespace PortableDevices

module PDGlobalTypes = 
    open PortableDeviceApiLib
    open System.Runtime.InteropServices
    
    type FilePath = 
        | DevicePath of string
        | BackupPath of string
    
    type TransferStatus = 
        | Complete
        | Error
        | Stalled
        | Unknown
    
    type DevicePropertyName = 
        | DevicePropertyName of string
    
    type DevicePropertyResult = 
        | PropertyResult of string
        | AccessError of string
    
    type DeviceID = 
        | DeviceID of string
    
    type PortableDevice = 
        { DeviceID : DeviceID
          Device : PortableDeviceClass }
    
    type ConnectedDevice = 
        | ConnectedDevice of PortableDevice
    
    type ConnectionStatus = 
        | Connected of ConnectedDevice
        | NotConnected of PortableDevice
    
    type ConnectDevice = PortableDevice -> ConnectionStatus
    
    type DisconnectDevice = ConnectedDevice -> ConnectionStatus
    
    type ReadDeviceProperty = ConnectedDevice -> DevicePropertyName -> Option<DevicePropertyResult>
    
    type TransferToBackup = FilePath -> FilePath -> TransferStatus
    
    type PropertyName = PropertyName of string

    type CategoryName = CategoryName of string

    type PropertyValue<'a> =  PropertyValue of 'a

    type PropertyValue' =
    | PropertyValueGuid of System.Guid
    | PropertyValueInt of int
    | PropertyValueString of string

    type PropertyNameValue' = 
        { PropertyName : PropertyName
          Value : PropertyValue' }

    type PropertyNameValue<'a> = 
        { Name : string
          Value : PropertyValue<'a> }
 
    type PropertNameTag = 
        { Name : string
          Tag : PortableDeviceApiLib._tagpropertykey }

    type CategoryNameGuid =
        { Name : CategoryName
          Guid : System.Guid }
    
    type SupportedProperties = 
        | SupportedProperties of seq<PropertyNameValue'>
    
      type SimplePropertyInfo = 
        { categoryName : string
          propertyName : PropertyName
          result : DevicePropertyResult }
    
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

