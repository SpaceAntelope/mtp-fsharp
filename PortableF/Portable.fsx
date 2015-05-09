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

//
type TransferStatus = Complete | Error | Stalled | Unknown
type DevicePropertyName = DevicePropertyName of string
type DevicePropertyValue = DevicePropertyValue of string
type DeviceID = DeviceID of string
type PortableDevice = { DeviceID : DeviceID; Device : PortableDeviceClass }
type ConnectionStatus<'a> =
    | Connected of 'a
    | Disconnected of 'a

type ConnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>
type DisconnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>
type ReadDeviceProperty = PortableDevice -> DevicePropertyName -> DevicePropertyValue
type TransferToBackup = FilePath-> FilePath -> TransferStatus

let connectDevice : ConnectDevice = 
    fun device -> 
        match Utils.ConnectToDevice(string device.DeviceID, device.Device) with
        | true -> Connected device 
        | _ -> Disconnected device

let disconnectDevice : DisconnectDevice = 
    fun device -> 
        device.Device.Close()
        Disconnected device

let DeviceCollection = seq {
    let deviceManager = PortableDeviceManagerClass()
    let deviceIDs = Utils.DeviceIdArray(deviceManager)
    
    if deviceIDs.Length <= 0 then failwith "No portable devices found."
    
    for i = 0 to deviceIDs.Length-1 do
        yield { DeviceID = DeviceID deviceIDs.[i]; Device = PortableDeviceClass()}
}


for device in DeviceCollection do
    printfn "%A" device
    match connectDevice device with
    | Connected dev ->  printfn "Connection successful"
    | Disconnected dev -> printfn "Could not connect."


let (|Even|Odd|) n =
    if n % 2 = 0 then Even n
    else Odd n
 
let testNum n =
    match n with
    | Even k-> printfn "%i is even" k
    | Odd l -> printfn "%i is odd" l;;
 
testNum 123124



let (|First5|) s = (string s).Substring(0,5)

let f = function 
| First5 g -> printfn "%s" g

f "1231431"

let f = function 
| Connected