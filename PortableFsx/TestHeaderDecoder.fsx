#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceApiLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\InteropAssemblies\Interop.PortableDeviceTypesLib.dll"
#r @"C:\Users\Ares\Documents\visual studio 2013\Projects\PortableDevices\WPDCommon\bin\Debug\WPDCommon.dll"
#r @"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\bin\Debug\PortableF.exe"

open PortableDeviceApiLib
open PortableDeviceTypesLib
open WPDCommon
open System.IO
open PortableDevices
open System.Reflection

let sprintArray = Array.reduce (fun state item -> sprintf "%s\n%s" state item)
let printArray input = printfn "%s\n" (sprintArray input)

let tagPropKeys = 
    Assembly.LoadFile(@"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\PortableF\bin\Debug\PortableF.exe")
            .GetType("PortableDevices.PDHeader").GetMethods()
    |> Array.filter (fun info -> info.ReturnType.Name = "_tagpropertykey")
    |> Array.map (fun info -> info.Name, info.Invoke(null, null) :?> PortableDeviceApiLib._tagpropertykey)

let tryParsePropKey (name, (tag : PortableDeviceApiLib._tagpropertykey)) = 
    let result = PortableDevices.PDHeaderDecoder.GetPropertyName tag.fmtid tag.pid
    
    let report = 
        [| sprintf " source: %s" name
           sprintf "   guid: %A, %i" tag.fmtid tag.pid
           sprintf "prs res: %A" result |]
    if (name.Replace("get_", "")) <> (snd result) then (0, name, snd result, report)
    else (1, name, snd result, report)

let parseResults = 
    tagPropKeys
    |> Array.map tryParsePropKey
    |> Array.partition (fun (status, _, _, _) -> status = 1)

let report = 
    snd parseResults |> Array.mapi (fun i item -> 
                            let (status, source, result, report) = item
                            sprintf "%i\n%s\n" i (sprintArray report))

fst parseResults |> Array.length
snd parseResults |> Array.length
System.IO.File.WriteAllLines(@"C:\Users\Ares\Documents\Visual Studio 2013\Projects\PortableDevices\log.txt", report)
