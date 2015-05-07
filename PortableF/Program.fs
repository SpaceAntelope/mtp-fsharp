// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open PortableDeviceApiLib
open PortableDeviceTypesLib

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
        
    let deviceManager = PortableDeviceManagerClass()
    deviceManager.RefreshDeviceList()
    let deviceIDs = [|""|] 
    let deviceIDsCountRef = ref (uint32 0)

    deviceManager.GetDevices(deviceIDs , deviceIDsCountRef)
    printfn "result = %d %A" !deviceIDsCountRef deviceIDs
    //deviceManager.GetDevices(deviceIDs , &deviceIDsCountRef)
    //printfn "result = %d %A" deviceIDsCountRef deviceIDs

    System.Console.ReadLine()

    0 // return an integer exit code
