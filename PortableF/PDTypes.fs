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
    
    type DevicePropertyResult = 
        | PropertyResult of string
        | AccessError of string
    
    type SimplePropertyInfo =
        { categoryName : string
          propertyName : string
          result : DevicePropertyResult }
    
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
    
    (*
 * VARENUM usage key,
 *
 * * [V] - may appear in a VARIANT
 * * [T] - may appear in a TYPEDESC
 * * [P] - may appear in an OLE property set
 * * [S] - may appear in a Safe Array
 *
 *
 *  VT_EMPTY            [V]   [P]     nothing
 *  VT_NULL             [V]   [P]     SQL style Null
 *  VT_I2               [V][T][P][S]  2 byte signed int
 *  VT_I4               [V][T][P][S]  4 byte signed int
 *  VT_R4               [V][T][P][S]  4 byte real
 *  VT_R8               [V][T][P][S]  8 byte real
 *  VT_CY               [V][T][P][S]  currency
 *  VT_DATE             [V][T][P][S]  date
 *  VT_BSTR             [V][T][P][S]  OLE Automation string
 *  VT_DISPATCH         [V][T]   [S]  IDispatch *
 *  VT_ERROR            [V][T][P][S]  SCODE
 *  VT_BOOL             [V][T][P][S]  True=-1, False=0
 *  VT_VARIANT          [V][T][P][S]  VARIANT *
 *  VT_UNKNOWN          [V][T]   [S]  IUnknown *
 *  VT_DECIMAL          [V][T]   [S]  16 byte fixed point
 *  VT_RECORD           [V]   [P][S]  user defined type
 *  VT_I1               [V][T][P][s]  signed char
 *  VT_UI1              [V][T][P][S]  unsigned char
 *  VT_UI2              [V][T][P][S]  unsigned short
 *  VT_UI4              [V][T][P][S]  ULONG
 *  VT_I8                  [T][P]     signed 64-bit int
 *  VT_UI8                 [T][P]     unsigned 64-bit int
 *  VT_INT              [V][T][P][S]  signed machine int
 *  VT_UINT             [V][T]   [S]  unsigned machine int
 *  VT_INT_PTR             [T]        signed machine register size width
 *  VT_UINT_PTR            [T]        unsigned machine register size width
 *  VT_VOID                [T]        C style void
 *  VT_HRESULT             [T]        Standard return type
 *  VT_PTR                 [T]        pointer type
 *  VT_SAFEARRAY           [T]        (use VT_ARRAY in VARIANT)
 *  VT_CARRAY              [T]        C style array
 *  VT_USERDEFINED         [T]        user defined type
 *  VT_LPSTR               [T][P]     null terminated string
 *  VT_LPWSTR              [T][P]     wide null terminated string
 *  VT_FILETIME               [P]     FILETIME
 *  VT_BLOB                   [P]     Length prefixed bytes
 *  VT_STREAM                 [P]     Name of the stream follows
 *  VT_STORAGE                [P]     Name of the storage follows
 *  VT_STREAMED_OBJECT        [P]     Stream contains an object
 *  VT_STORED_OBJECT          [P]     Storage contains an object
 *  VT_VERSIONED_STREAM       [P]     Stream with a GUID version
 *  VT_BLOB_OBJECT            [P]     Blob contains an object 
 *  VT_CF                     [P]     Clipboard format
 *  VT_CLSID                  [P]     A Class ID
 *  VT_VECTOR                 [P]     simple counted array
 *  VT_ARRAY            [V]           SAFEARRAY*
 *  VT_BYREF            [V]           void* for local use
 *  VT_BSTR_BLOB                      Reserved for system use
 *)


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
