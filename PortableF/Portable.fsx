//#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceApiLib.dll"
//#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceTypesLib.dll"
//#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\WPDCommon\bin\Debug\WPDCommon.dll"
//
//open PortableDeviceApiLib
//open PortableDeviceTypesLib
//open WPDCommon
//open System.IO
//open InterfaceInstanceProvider
//   
//
//

let x input = printfn "%A" input
let y input = printfn "%A" input
let z = 10 |> y |> x

let x' = 10
let result = lazy (x' + 10)
printfn "%A" result

seq {
    for i in 1..5 do
        yield i
        yield! seq { yield 10 - i }
        yield! Seq.empty
} |> Seq.length//Seq.iter (fun item -> printfn "%A" item)
//
//
//DeviceCollection |> Seq.iter (fun device -> 
//                        printfn "%A" device
//                        let conn = connectDevice device
//                        printfn "Conn: %A" conn
//                        let (DevicePropertyValue value) = readDeviceProperty device
//                        printfn "Value: %s" value)
////printfn "Connection successful %A" (readDeviceProperty device))
////                        match connectDevice device with
////                        | Connected dev -> printfn "Connection successful %A" (readDeviceProperty dev)
////                        | Disconnected dev -> printfn "Could not connect.")
