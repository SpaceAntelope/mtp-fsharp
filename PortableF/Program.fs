namespace PortableDevices

open PortableDeviceApiLib
open PortableDeviceTypesLib

module main = 
    open PDUtils
    open PDTypes
    
    [<EntryPoint>]
    let main argv = 
        printfn "%A" argv
        DeviceSequence |> Seq.iter (fun device -> 
                              printfn "%A" device
                              let conn = connectDevice device
                              printfn "Conn: %A" conn
                              let (DevicePropertyValue value) = readDeviceProperty device
                              printfn "Value: %s" value)
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
