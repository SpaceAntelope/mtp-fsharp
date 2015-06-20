namespace PortableDevices

open PortableDeviceApiLib

module PDTypes = 
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
    
    type DevicePropertyValue = 
        | DevicePropertyValue of string
        | ElementNotFound of string

    type DevicePropertyResult = 
        { categoryName : string
          name : DevicePropertyName
          value : DevicePropertyValue }
    
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
    
    type ReadDeviceProperty = ConnectedDevice -> DevicePropertyName -> Option<DevicePropertyValue>
    
    type TransferToBackup = FilePath -> FilePath -> TransferStatus
    
    type VARENUM = 
        | VT_EMPTY = 0us
        | VT_NULL = 1us
        | VT_I2 = 2us
        | VT_I4 = 3us
        | VT_R4 = 4us
        | VT_R8 = 5us
        | VT_CY = 6us
        | VT_DATE = 7us
        | VT_BSTR = 8us
        | VT_DISPATCH = 9us
        | VT_ERROR = 10us
        | VT_BOOL = 11us
        | VT_VARIANT = 12us
        | VT_UNKNOWN = 13us
        | VT_DECIMAL = 14us
        | VT_I1 = 16us
        | VT_UI1 = 17us
        | VT_UI2 = 18us
        | VT_UI4 = 19us
        | VT_I8 = 20us
        | VT_UI8 = 21us
        | VT_INT = 22us
        | VT_UINT = 23us
        | VT_VOID = 24us
        | VT_HRESULT = 25us
        | VT_PTR = 26us
        | VT_SAFEARRAY = 27us
        | VT_CARRAY = 28us
        | VT_USERDEFINED = 29us
        | VT_LPSTR = 30us
        | VT_LPWSTR = 31us
        | VT_RECORD = 36us
        | VT_INT_PTR = 37us
        | VT_UINT_PTR = 38us
        | VT_FILETIME = 64us
        | VT_BLOB = 65us
        | VT_STREAM = 66us
        | VT_STORAGE = 67us
        | VT_STREAMED_OBJECT = 68us
        | VT_STORED_OBJECT = 69us
        | VT_BLOB_OBJECT = 70us
        | VT_CF = 71us
        | VT_CLSID = 72us
        | VT_VERSIONED_STREAM = 73us
        | VT_BSTR_BLOB = 0xfffus
        | VT_VECTOR = 0x1000us
        | VT_ARRAY = 0x2000us
        | VT_BYREF = 0x4000us
        | VT_RESERVED = 0x8000us
        | VT_ILLEGAL = 0xffffus
        | VT_ILLEGALMASKED = 0xfffus
        | VT_TYPEMASK = 0xfffus
    
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
//[StructLayout(LayoutKind.Explicit, Size = 16)]
//    public struct PropVariant
//    {
//        [FieldOffset(0)]
//        public short variantType;
//        [FieldOffset(8)]
//        public IntPtr pointerValue;
//        [FieldOffset(8)]
//        public byte byteValue;
//        [FieldOffset(8)]
//        public long longValue;
//    }
