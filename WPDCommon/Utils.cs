using PortableDeviceApiLib;
using PortableDeviceTypesLib;
using PortableDeviceConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace WPDCommon
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PropVariant
    {
        [FieldOffset(0)]
        public short variantType;
        [FieldOffset(8)]
        public IntPtr pointerValue;
        [FieldOffset(8)]
        public byte byteValue;
        [FieldOffset(8)]
        public long longValue;
    }

    public static class Utils
    {
        public static void AppendFormatN(this StringBuilder str, string text, params object[] args)
        {
            str.AppendFormat(text + Environment.NewLine, args);
        }

        public static string[] DeviceIdArray(PortableDeviceManagerClass devMan)
        {
            UInt32 deviceCount = 0;
            devMan.RefreshDeviceList();
            devMan.GetDevices(null, ref deviceCount);
            var deviceIds = new string[deviceCount];
            devMan.GetDevices(deviceIds, ref deviceCount);

            return deviceIds;
        }

        public static void ConnectToDeviceWithClientInfo(string deviceID, PortableDeviceClass device)
        {
            var pValues = (PortableDeviceApiLib.IPortableDeviceValues) new PortableDeviceTypesLib.PortableDeviceValuesClass();

            // We have to provide at the least our name, version, revision
            pValues.SetStringValue(ref PortableDevicePKeys.WPD_CLIENT_NAME, "Sample Client");
            pValues.SetUnsignedIntegerValue(ref PortableDevicePKeys.WPD_CLIENT_MAJOR_VERSION, 1);
            pValues.SetUnsignedIntegerValue(ref PortableDevicePKeys.WPD_CLIENT_MINOR_VERSION, 0);
            pValues.SetUnsignedIntegerValue(ref PortableDevicePKeys.WPD_CLIENT_REVISION, 2);

            // We are now ready to open a connection to the device
            // We'll assume deviceID contains a valid WPD device path and connect to it
            device.Open(deviceID, pValues);

            //Console.WriteLine("Device probably connected");

            return;
            uint cnt = 0;
            //pValues.GetCount(ref cnt);
            //Console.WriteLine("Found {0} objects", cnt);

            //for (uint i = 0; i < cnt; i++)
            //{
            //    var pKey = new PortableDeviceApiLib._tagpropertykey();
            //    var pValueCom = new PortableDeviceApiLib.tag_inner_PROPVARIANT();
            //    pValues.GetAt(i, ref pKey, ref pValueCom);
            //    var pValue = MarshalPropVariant(pValueCom);

            //    Console.WriteLine(i + 1);
            //    Console.WriteLine("Key: {0}, {1}", pKey.fmtid, pKey.pid);
            //    Console.WriteLine("Value Type: {0}", pValue.variantType);
            //}
            
            
            //return true;
        }

        public static bool ConnectToDevice(string deviceID, PortableDeviceClass device)
        {
            var dvc = new PortableDeviceValuesClass();

            device.Open(
                deviceID,
                (PortableDeviceApiLib.IPortableDeviceValues)dvc//(PortableDeviceApiLib.IPortableDeviceValues)new PortableDeviceValuesClass()
            );
            
            Console.WriteLine(dvc.ToString());
            Console.WriteLine("Device probably connected");
            uint cnt = 0;
            dvc.GetCount(ref cnt);
            Console.WriteLine("Found {0} objects", cnt);

            for (uint i = 0; i < cnt; i++)
            {
                var pKey = new PortableDeviceTypesLib._tagpropertykey();
                var pValueCom = new PortableDeviceTypesLib.tag_inner_PROPVARIANT();
                dvc.GetAt(i, ref pKey, ref pValueCom);
                var pValue = MarshalPropVariant(pValueCom);

                Console.WriteLine(i + 1);
                Console.WriteLine("Key: {0}, {1}", pKey.fmtid, pKey.pid);
                Console.WriteLine("Value Type: {0}", pValue.variantType);
            }
            return true;
        }

        public static PropVariant MarshalPropVariant(PortableDeviceApiLib.tag_inner_PROPVARIANT prop)
        {
            IntPtr ptrValue = Marshal.AllocHGlobal(Marshal.SizeOf(prop));
            Marshal.StructureToPtr(prop, ptrValue, false);
            return (PropVariant)Marshal.PtrToStructure(ptrValue, typeof(PropVariant));
        }

        public static PropVariant MarshalPropVariant(PortableDeviceTypesLib.tag_inner_PROPVARIANT prop)
        {
            IntPtr ptrValue = Marshal.AllocHGlobal(Marshal.SizeOf(prop));
            Marshal.StructureToPtr(prop, ptrValue, false);
            return (PropVariant)Marshal.PtrToStructure(ptrValue, typeof(PropVariant));
        }

        public static string GetFunctionaCategories(PortableDeviceClass device)
        {
            PortableDeviceApiLib.IPortableDeviceCapabilities capabilities;
            PortableDeviceApiLib.IPortableDevicePropVariantCollection categories;
            uint elementNum = 0;

            device.Capabilities(out capabilities);
            capabilities.GetFunctionalCategories(out categories);

            categories.GetCount(ref elementNum);

            var str = new StringBuilder("Available functional categories:");

            for (uint i = 0; i < elementNum; i++)
            {
                var prop = new PortableDeviceApiLib.tag_inner_PROPVARIANT();
                categories.GetAt(i, ref prop);
                PropVariant pvValue = MarshalPropVariant(prop);
                Guid guid = (Guid)Marshal.PtrToStructure(pvValue.pointerValue, typeof(System.Guid));

                str.AppendFormatN("Variant type: {0}", pvValue.variantType);
                str.AppendFormatN("{0}: Value is \"{1}\"", (i + 1).ToString(), guid);

                PortableDeviceApiLib.IPortableDevicePropVariantCollection contentTypes;
                capabilities.GetSupportedContentTypes(ref guid, out contentTypes);

                uint contentTypesNum = 0;
                contentTypes.GetCount(ref contentTypesNum);

                str.AppendLine("\tAvailable content types:");

                for (uint j = 0; j < contentTypesNum; j++)
                {
                    var contentTypeCom = new PortableDeviceApiLib.tag_inner_PROPVARIANT();
                    contentTypes.GetAt(j, ref contentTypeCom);
                    PropVariant contentType = MarshalPropVariant(contentTypeCom);

                    str.AppendFormatN("\tVariant type: {0}", contentType.variantType);
                    str.AppendFormatN("\t{0}: Value is \"{1}\"", (j + 1).ToString(), (Guid)Marshal.PtrToStructure(contentType.pointerValue, typeof(System.Guid)));
                }
            }

            return str.ToString();
        }
    }
}
