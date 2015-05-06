#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceApiLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceTypesLib.dll"
open PortableDeviceApiLib
open PortableDeviceTypesLib

let deviceManager = PortableDeviceManagerClass()
deviceManager.RefreshDeviceList
let deviceIDs = [|""|] 
let mutable deviceIDsCountRef = uint32 2
deviceManager.GetDevices(deviceIDs , &deviceIDsCountRef)
printfn "result = %d %A" deviceIDsCountRef deviceIDs
deviceManager.GetDevices(deviceIDs , &deviceIDsCountRef)
printfn "result = %d %A" deviceIDsCountRef deviceIDs


type ConnectionStatus =
| IsConnected 
| NotConnected

type PortableDevice = { DeviceID : string; ConnectionStatus : ConnectionStatus; }
    



let DeviceCollection = seq {
    let deviceManager = PortableDeviceManagerClass()
    let mutable deviceIDsCountRef : uint32 = uint32 0
    deviceManager.GetDevices([|""|], &deviceIDsCountRef)
    printfn "%A" deviceIDsCountRef

    let deviceCount = int deviceIDsCountRef
    printfn "%i %i %A" deviceCount deviceIDsCountRef deviceIDsCountRef
    
    if deviceCount <= 0 then failwith "No portable devices found."
    
    //Array.init deviceCount (fun i -> "")
    let deviceIDs = [|"";""|] 
    deviceManager.GetDevices(deviceIDs, &deviceIDsCountRef)
    
    for i = 0 to deviceCount-1 do
        yield {DeviceID = deviceIDs.[i]; ConnectionStatus = NotConnected}           
}

for device in DeviceCollection do
    printfn "%A" device