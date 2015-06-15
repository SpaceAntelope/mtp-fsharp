namespace PortableDevices

module PDInterfaceInstanceProvider = 
    open PortableDeviceApiLib
    open PortableDeviceTypesLib
    open System.Runtime.InteropServices
    
    let PortableDevicePropertiesDummyPointer = 
        fun () -> 
            { new IPortableDeviceProperties with
                  member this.Cancel() = printfn "Cancel"
                  member this.Delete(pszObjectID, pKeys) = printfn "Delete"
                  member this.GetPropertyAttributes(pszObjectID, key, ppAttributes) = printfn "GetPropertyAttributes"
                  member this.GetSupportedProperties(pszObjectID, ppKeys) = printfn "GetSupportedProperties"
                  member this.GetValues(pszObjectID, pKeys, ppValues) = printfn "GetValues"
                  member this.SetValues(pszObjectID, pValues, ppResults) = printfn "SetValues" }
    
    let PortableDeviceContentDummyPointer = 
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
    
    let PortableDeviceValuesDummyPointer = 
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
    
    let PortableDeviceKeyCollectionDummyPointer = 
        fun () -> 
            { new PortableDeviceApiLib.IPortableDeviceKeyCollection with
                  member this.Add(key) = printfn "Add"
                  member this.Clear() = printfn "Clear"
                  member this.GetAt(dwIndex, pKey) = printfn "GetAt"
                  member this.GetCount(pcElems) = printfn "GetCount"
                  member this.RemoveAt(dwIndex) = printfn "RemoveAt" }
    
    type PortableDeviceValuesWrapper() = 
            member this.sourceObject = new PortableDeviceTypesLib.PortableDeviceValuesClass()
            interface PortableDeviceApiLib.IPortableDeviceValues with
                member this.Clear() = this.sourceObject.Clear()
                member this.GetBoolValue(key, pValue) = 
                    let apiKey = ref (HelperFunctions.MarshalVariant<PortableDeviceTypesLib._tagpropertykey> key)
                    let apiValue = ref pValue
                    this.sourceObject.GetBoolValue(apiKey, apiValue)
            
                member this.GetUnsignedIntegerValue(key, pValue) = 
                    let apiKey = ref (HelperFunctions.MarshalVariant<PortableDeviceTypesLib._tagpropertykey> key)
                    let apiValue = ref pValue
                    let source = new PortableDeviceTypesLib.PortableDeviceValuesClass()
                    source.GetUnsignedIntegerValue(apiKey, apiValue)
            
                member this.CopyValuesFromPropertyStore(pStore) = printfn "CopyValuesFromPropertyStore"
                member this.CopyValuesToPropertyStore(pStore) = printfn "CopyValuesToPropertyStore"
                member this.GetAt(index, pKey, pValue) = printfn "GetAt"
                //member this.GetBoolValue(key, pValue) = printfn "GetBoolValue"
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
                //member this.GetUnsignedIntegerValue(key, pValue) = printfn "GetUnsignedIntegerValue"
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
                member this.SetValue(key, pValue) = printfn "SetValue"
// type PortableDeviceValuesWrapper =
//            member this.sourceObject = new PortableDeviceTypesLib.PortableDeviceValuesClass()
//            interface PortableDeviceApiLib.IPortableDeviceValues with
//                member this.Clear() = this.sourceObject.Clear()
//                member this.CopyValuesFromPropertyStore(pStore) = this.sourceObject.CopyValuesFromPropertyStore(PortableDeviceTypesLib.IPropertyStore pStore)
//                member this.CopyValuesToPropertyStore(pStore) = this.sourceObject.CopyValuesToPropertyStore(pStore)
//                member this.GetAt(index, pKey, pValue) = this.sourceObject.GetAt(index, pKey, pValue)
//                member this.GetBoolValue(key, pValue) = this.sourceObject.GetBoolValue(key, pValue)
//                member this.GetBufferValue(key, ppValue, pcbValue) = this.sourceObject.GetBufferValue(key, ppValue, pcbValue)
//                member this.GetCount(pcelt) = this.sourceObject.GetCount(pcelt)
//                member this.GetErrorValue(key, pValue) = this.sourceObject.GetErrorValue(key, pValue)
//                member this.GetFloatValue(key, pValue) = this.sourceObject.GetFloatValue(key, pValue)
//                member this.GetGuidValue(key, pValue) = this.sourceObject.GetGuidValue(key, pValue)
//                member this.GetIPortableDeviceKeyCollectionValue(key, ppValue) = this.sourceObject.GetIPortableDeviceKeyCollectionValue(key, ppValue)
//                member this.GetIPortableDevicePropVariantCollectionValue(key, ppValue) = this.sourceObject.GetIPortableDevicePropVariantCollectionValue(key, ppValue)
//                member this.GetIPortableDeviceValuesCollectionValue(key, ppValue) = this.sourceObject.GetIPortableDeviceValuesCollectionValue(key, ppValue)
//                member this.GetIPortableDeviceValuesValue(key, ppValue) = this.sourceObject.GetIPortableDeviceValuesValue(key, ppValue)
//                member this.GetIUnknownValue(key, ppValue) = this.sourceObject.GetIUnknownValue(key, ppValue)
//                member this.GetKeyValue(key, pValue) = this.sourceObject.GetKeyValue(key, pValue)
//                member this.GetSignedIntegerValue(key, pValue) = this.sourceObject.GetSignedIntegerValue(key, pValue)
//                member this.GetSignedLargeIntegerValue(key, pValue) = this.sourceObject.GetSignedLargeIntegerValue(key, pValue)
//                member this.GetStringValue(key, pValue) = this.sourceObject.GetStringValue(key, pValue)
//                member this.GetUnsignedIntegerValue(key, pValue) = this.sourceObject.GetUnsignedIntegerValue(key, pValue)
//                member this.GetUnsignedLargeIntegerValue(key, pValue) = this.sourceObject.GetUnsignedLargeIntegerValue(key, pValue)
//                member this.GetValue(key, pValue) = this.sourceObject.GetValue(key, pValue)
//                member this.RemoveValue(key) = this.sourceObject.RemoveValue(key)
//                member this.SetBoolValue(key, Value) = this.sourceObject.SetBoolValue(key, Value)
//                member this.SetBufferValue(key, pValue, cbValue) = this.sourceObject.SetBufferValue(key, pValue, cbValue)
//                member this.SetErrorValue(key, Value) = this.sourceObject.SetErrorValue(key, Value)
//                member this.SetFloatValue(key, Value) = this.sourceObject.SetFloatValue(key, Value)
//                member this.SetGuidValue(key, Value) = this.sourceObject.SetGuidValue(key, Value)
//                member this.SetIPortableDeviceKeyCollectionValue(key, pValue) = this.sourceObject.SetIPortableDeviceKeyCollectionValue(key, pValue)
//                member this.SetIPortableDevicePropVariantCollectionValue(key, pValue) = this.sourceObject.SetIPortableDevicePropVariantCollectionValue(key, pValue)
//                member this.SetIPortableDeviceValuesCollectionValue(key, pValue) = this.sourceObject.SetIPortableDeviceValuesCollectionValue(key, pValue)
//                member this.SetIPortableDeviceValuesValue(key, pValue) = this.sourceObject.SetIPortableDeviceValuesValue(key, pValue)
//                member this.SetIUnknownValue(key, pValue) = this.sourceObject.SetIUnknownValue(key, pValue)
//                member this.SetKeyValue(key, Value) = this.sourceObject.SetKeyValue(key, Value)
//                member this.SetSignedIntegerValue(key, Value) = this.sourceObject.SetSignedIntegerValue(key, Value)
//                member this.SetSignedLargeIntegerValue(key, Value) = this.sourceObject.SetSignedLargeIntegerValue(key, Value)
//                member this.SetStringValue(key, Value) = this.sourceObject.SetStringValue(key, Value)
//                member this.SetUnsignedIntegerValue(key, Value) = this.sourceObject.SetUnsignedIntegerValue(key, Value)
//                member this.SetUnsignedLargeIntegerValue(key, Value) = this.sourceObject.SetUnsignedLargeIntegerValue(key, Value)
//                member this.SetValue(key, pValue) = this.sourceObject.SetValue(key, pValue) 
//(PortableDeviceApiLib.IPortableDeviceValues)new PortableDeviceValuesClass()
