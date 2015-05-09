#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceApiLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceTypesLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\WPDCommon\bin\Debug\WPDCommon.dll"

open PortableDeviceApiLib
open PortableDeviceTypesLib
open WPDCommon
open System.IO

module InterfaceInstanceProvider = 
    let PortableDevicePropertiesInstance = 
        fun () -> 
            { new IPortableDeviceProperties with
                  member this.Cancel() = printfn "Cancel"
                  member this.Delete(pszObjectID, pKeys) = printfn "Delete"
                  member this.GetPropertyAttributes(pszObjectID, key, ppAttributes) = printfn "GetPropertyAttributes"
                  member this.GetSupportedProperties(pszObjectID, ppKeys) = printfn "GetSupportedProperties"
                  member this.GetValues(pszObjectID, pKeys, ppValues) = printfn "GetValues"
                  member this.SetValues(pszObjectID, pValues, ppResults) = printfn "SetValues" }
    
    let PortableDeviceContentInstance = 
        fun () -> 
            { new IPortableDeviceContent with
                  member this.Cancel() = printfn "Cancel"
                  member this.Copy(pObjectIDs, pszDestinationFolderObjectID, ppResults) = printfn "Copy"
                  member this.CreateObjectWithPropertiesAndData(pValues, ppData, pdwOptimalWriteBufferSize, ppszCookie) = 
                      printfn "CreateObjectWithPropertiesAndData"
                  member this.CreateObjectWithPropertiesOnly(pValues, ppszObjectID) = 
                      printfn "CreateObjectWithPropertiesOnly"
                  member this.Delete(dwOptions, pObjectIDs, ppResults) = printfn "Delete"
                  member this.EnumObjects(dwFlags, pszParentObjectID, pFilter, ppenum) = printfn "EnumObjects"
                  member this.GetObjectIDsFromPersistentUniqueIDs(pPersistentUniqueIDs, ppObjectIDs) = 
                      printfn "GetObjectIDsFromPersistentUniqueIDs"
                  member this.Move(pObjectIDs, pszDestinationFolderObjectID, ppResults) = printfn "Move"
                  member this.Properties(ppProperties) = printfn "Properties"
                  member this.Transfer(ppResources) = printfn "Transfer" }
    
    let PortableDeviceValuesInstance = 
        fun () -> 
            { new PortableDeviceApiLib.IPortableDeviceValues with
                  member this.Clear() = printfn "Clear"
                  member this.CopyValuesFromPropertyStore(pStore) = printfn "CopyValuesFromPropertyStore"
                  member this.CopyValuesToPropertyStore(pStore) = printfn "CopyValuesToPropertyStore"
                  member this.GetAt(index, pKey, pValue) = printfn "GetAt"
                  member this.GetBoolValue(key, pValue) = printfn "GetBoolValue"
                  member this.GetBufferValue(key, ppValue, pcbValue) = printfn "GetBufferValue"
                  member this.GetCount(pcelt) = printfn "GetCount"
                  member this.GetErrorValue(key, pValue) = printfn "GetErrorValue"
                  member this.GetFloatValue(key, pValue) = printfn "GetFloatValue"
                  member this.GetGuidValue(key, pValue) = printfn "GetGuidValue"
                  member this.GetIPortableDeviceKeyCollectionValue(key, ppValue) = 
                      printfn "GetIPortableDeviceKeyCollectionValue"
                  member this.GetIPortableDevicePropVariantCollectionValue(key, ppValue) = 
                      printfn "GetIPortableDevicePropVariantCollectionValue"
                  member this.GetIPortableDeviceValuesCollectionValue(key, ppValue) = 
                      printfn "GetIPortableDeviceValuesCollectionValue"
                  member this.GetIPortableDeviceValuesValue(key, ppValue) = printfn "GetIPortableDeviceValuesValue"
                  member this.GetIUnknownValue(key, ppValue) = printfn "GetIUnknownValue"
                  member this.GetKeyValue(key, pValue) = printfn "GetKeyValue"
                  member this.GetSignedIntegerValue(key, pValue) = printfn "GetSignedIntegerValue"
                  member this.GetSignedLargeIntegerValue(key, pValue) = printfn "GetSignedLargeIntegerValue"
                  member this.GetStringValue(key, pValue) = printfn "GetStringValue"
                  member this.GetUnsignedIntegerValue(key, pValue) = printfn "GetUnsignedIntegerValue"
                  member this.GetUnsignedLargeIntegerValue(key, pValue) = printfn "GetUnsignedLargeIntegerValue"
                  member this.GetValue(key, pValue) = printfn "GetValue"
                  member this.RemoveValue(key) = printfn "RemoveValue"
                  member this.SetBoolValue(key, value) = printfn "SetBoolValue"
                  member this.SetBufferValue(key, pValue, cbValue) = printfn "SetBufferValue"
                  member this.SetErrorValue(key, value) = printfn "SetErrorValue"
                  member this.SetFloatValue(key, value) = printfn "SetFloatValue"
                  member this.SetGuidValue(key, value) = printfn "SetGuidValue"
                  member this.SetIPortableDeviceKeyCollectionValue(key, pValue) = 
                      printfn "SetIPortableDeviceKeyCollectionValue"
                  member this.SetIPortableDevicePropVariantCollectionValue(key, pValue) = 
                      printfn "SetIPortableDevicePropVariantCollectionValue"
                  member this.SetIPortableDeviceValuesCollectionValue(key, pValue) = 
                      printfn "SetIPortableDeviceValuesCollectionValue"
                  member this.SetIPortableDeviceValuesValue(key, pValue) = printfn "SetIPortableDeviceValuesValue"
                  member this.SetIUnknownValue(key, pValue) = printfn "SetIUnknownValue"
                  member this.SetKeyValue(key, value) = printfn "SetKeyValue"
                  member this.SetSignedIntegerValue(key, value) = printfn "SetSignedIntegerValue"
                  member this.SetSignedLargeIntegerValue(key, value) = printfn "SetSignedLargeIntegerValue"
                  member this.SetStringValue(key, value) = printfn "SetStringValue"
                  member this.SetUnsignedIntegerValue(key, value) = printfn "SetUnsignedIntegerValue"
                  member this.SetUnsignedLargeIntegerValue(key, value) = printfn "SetUnsignedLargeIntegerValue"
                  member this.SetValue(key, pValue) = printfn "SetValue" }
    
    let PortableDeviceKeyCollectionInstance = 
        fun () -> 
            { new PortableDeviceApiLib.IPortableDeviceKeyCollection with
                  //interface PortableDeviceTypesLib.IPortableDeviceKeyCollection with        
                  member this.Add(key) = printfn "Add"
                  member this.Clear() = printfn "Clear"
                  member this.GetAt(dwIndex, pKey) = printfn "GetAt"
                  member this.GetCount(pcElems) = printfn "GetCount"
                  member this.RemoveAt(dwIndex) = printfn "RemoveAt" }

type FilePath = 
    | DevicePath of string
    | BackupPath of string

//
type TransferStatus = 
    | Complete
    | Error
    | Stalled
    | Unknown

type DevicePropertyName = 
    | DevicePropertyName of string

type DevicePropertyValue = 
    | DevicePropertyValue of string

type DeviceID = 
    | DeviceID of string

type PortableDevice = 
    { DeviceID : DeviceID
      Device : PortableDeviceClass }

type ConnectionStatus<'a> = 
    | Connected of 'a
    | Disconnected of 'a

type ConnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>

type DisconnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>

type ReadDeviceProperty = ConnectionStatus<PortableDevice> -> DevicePropertyName -> Option<DevicePropertyValue>

type TransferToBackup = FilePath -> FilePath -> TransferStatus

let connectDevice : ConnectDevice = 
    fun device -> 
        let (DeviceID devID) = device.DeviceID
        //device.Device.Open(devID, devVal )
        Utils.ConnectToDevice(devID, device.Device) |> printfn "Connection Status: %b"
        Connected device

let disconnectDevice : DisconnectDevice = 
    fun device -> 
        device.Device.Close()
        Disconnected device

let readProperty : ReadDeviceProperty = 
    fun device propName -> 
        match device with
        | Connected dev -> Some(DevicePropertyValue(sprintf "%A %A" dev.DeviceID propName))
        | _ -> None

let readDeviceProperty (device : PortableDevice) = 
    let mutable content = InterfaceInstanceProvider.PortableDeviceContentInstance()
    let mutable properties = InterfaceInstanceProvider.PortableDevicePropertiesInstance()
    let mutable propertyValues = InterfaceInstanceProvider.PortableDeviceValuesInstance()
    let mutable property = new PortableDeviceApiLib._tagpropertykey()
    let mutable propertyValue = ""
    device.Device.Content(&content)
    content.Properties(&properties)
    properties.GetValues("DEVICE", null, &propertyValues)
    property.fmtid <- new System.Guid(int 0x26D4979A, int16 0xE643, int16 0x4626, byte 0x9E, byte 0x2B, byte 0x73, 
                                      byte 0x6D, byte 0xC0, byte 0xC9, byte 0x2F, byte 0xDC)
    property.pid <- uint32 12
    propertyValues.GetStringValue(&property, &propertyValue)
    DevicePropertyValue propertyValue

let DeviceCollection = 
    seq { 
        let deviceManager = PortableDeviceManagerClass()
        let deviceIDs = Utils.DeviceIdArray(deviceManager)
        if deviceIDs.Length <= 0 then failwith "No portable devices found."
        for i = 0 to deviceIDs.Length - 1 do
            yield { DeviceID = DeviceID deviceIDs.[i]
                    Device = PortableDeviceClass() }
    }

DeviceCollection |> Seq.iter (fun device -> 
                        printfn "%A" device
                        let conn = connectDevice device
                        printfn "Conn: %A" conn
                        let (DevicePropertyValue value) = readDeviceProperty device
                        printfn "Value: %s" value)
//printfn "Connection successful %A" (readDeviceProperty device))
//                        match connectDevice device with
//                        | Connected dev -> printfn "Connection successful %A" (readDeviceProperty dev)
//                        | Disconnected dev -> printfn "Could not connect.")
