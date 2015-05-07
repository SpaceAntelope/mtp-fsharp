#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceApiLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceTypesLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\WPDCommon\bin\Debug\WPDCommon.dll"

open PortableDeviceApiLib
open PortableDeviceTypesLib
open WPDCommon
open System.IO


type FilePath = 
| DevicePath of string
| BackupPath of string

//let (|Connected|Disconnected|) (DeviceID : DeviceID) =
    //if ( )

type TransferStatus = Complete | Error | Stalled | Unknown
type PropertyName = PropertyName of string
type PropertyValue = PropertyValue of string
type DeviceID = DeviceID of string

type ReadDeviceProperty = PortableDevice -> PropertyName -> PropertyValue
type TransferToBackup = FilePath-> FilePath -> TransferStatus



type PortableDevice = { DeviceID : DeviceID; Device : PortableDeviceClass }
    
let DeviceCollection = seq {
    let deviceManager = PortableDeviceManagerClass()
    let deviceIDs = Utils.DeviceIdArray(deviceManager)
    
    if deviceIDs.Length <= 0 then failwith "No portable devices found."
    
    for i = 0 to deviceIDs.Length-1 do
        yield deviceIDs.[i]
}



for device in DeviceCollection do
    printfn "%s" device


