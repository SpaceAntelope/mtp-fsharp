namespace PortableDevices

module PDInterfaceInstanceProvider = 
    open PortableDeviceApiLib
    
//    type IPortableDeviceDataStream =
//            abstract member GetObjectID : (string ref) -> int64
//            abstract member Cancel : int64

    type DummyStreamType() =
//        interface IPortableDeviceDataStream with
//            member GetObjectID
        interface (PortableDeviceApiLib.ISequentialStream) with        
            member this.RemoteRead(pv, cb, pcbRead) = raise (System.NotImplementedException("ISequentialStream.RemoteRead"))
            member this.RemoteWrite(pv, cb, pcbWritten) = raise (System.NotImplementedException("ISequentialStream.RemoteWrite"))
        interface (PortableDeviceApiLib.IStream) with        
            member this.Clone(ppstm) = raise (System.NotImplementedException("Clone"))
            member this.Commit(grfCommitFlags) = raise (System.NotImplementedException("Commit"))
            member this.LockRegion(libOffset, cb, dwLockType) = raise (System.NotImplementedException("LockRegion"))
            member this.RemoteCopyTo(pstm, cb, pcbRead, pcbWritten) = raise (System.NotImplementedException("RemoteCopyTo"))
            member this.RemoteRead(pv, cb, pcbRead) = raise (System.NotImplementedException("RemoteRead"))
            member this.RemoteSeek(dlibMove, dwOrigin, plibNewPosition) = raise (System.NotImplementedException("RemoteSeek"))
            member this.RemoteWrite(pv, cb, pcbWritten) = raise (System.NotImplementedException("RemoteWrite"))
            member this.Revert() = raise (System.NotImplementedException("Revert"))
            member this.SetSize(libNewSize) = raise (System.NotImplementedException("SetSize"))
            member this.Stat(pstatstg, grfStatFlag) = raise (System.NotImplementedException("Stat"))
            member this.UnlockRegion(libOffset, cb, dwLockType) = raise (System.NotImplementedException("UnlockRegion"))

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
