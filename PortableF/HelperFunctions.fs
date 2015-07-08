namespace PortableDevices
//
//open System
//
module HelperFunctions = 
    open System.Runtime.InteropServices
    open PDGlobalTypes

    let MarshalPropVariant (prop : PortableDeviceApiLib.tag_inner_PROPVARIANT) =
        let ptrValue = Marshal.AllocHGlobal(Marshal.SizeOf(prop));
        Marshal.StructureToPtr(prop, ptrValue, false);
        Marshal.PtrToStructure(ptrValue,  typedefof<PropVariant>) :?> PropVariant 

    let MarshalVariant<'Target> (prop : obj) =
        let ptrValue = Marshal.AllocHGlobal(Marshal.SizeOf(prop));
        Marshal.StructureToPtr(prop, ptrValue, false);
        Marshal.PtrToStructure(ptrValue,  typedefof<'Target>) :?> 'Target 