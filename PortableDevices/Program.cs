using PortableDeviceApiLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint count = 0;
            //string[] deviceIds = null;
            //Utils.DeviceList(out deviceIds, out count);

            //Console.WriteLine("dev: {0} count: {1}", string.Join(", ", deviceIds), count);
            //Console.WriteLine();
            //Console.WriteLine("Press any key to continue.");
            //Console.ReadKey();

            //return;

            var collection = new PortableDeviceCollection();

            collection.Refresh();

            foreach (var device in collection)
            {
                device.Connect();
                Console.WriteLine(device.FriendlyName);

                //var folder = device.GetContents();
                //foreach (var item in folder.Files)
                //{
                //    DisplayObject(item);
                //}

                //device.Disconnect();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void DisplayObject(PortableDeviceObject portableDeviceObject)
        {
            Console.WriteLine(portableDeviceObject.Name);
            if (portableDeviceObject is PortableDeviceFolder)
            {
                DisplayFolderContents((PortableDeviceFolder)portableDeviceObject);
            }
        }

        public static void DisplayFolderContents(PortableDeviceFolder folder)
        {
            foreach (var item in folder.Files)
            {
                Console.WriteLine(item.Id);
                if (item is PortableDeviceFolder)
                {
                    DisplayFolderContents((PortableDeviceFolder)item);
                }
            }
        }
    }

    class Temp : PortableDeviceApiLib.IPortableDeviceValues
    {
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyValuesFromPropertyStore(IPropertyStore pStore)
        {
            throw new NotImplementedException();
        }

        public void CopyValuesToPropertyStore(IPropertyStore pStore)
        {
            throw new NotImplementedException();
        }

        public void GetAt(uint index, ref _tagpropertykey pKey, ref tag_inner_PROPVARIANT pValue)
        {
            throw new NotImplementedException();
        }

        public void GetBoolValue(ref _tagpropertykey key, out int pValue)
        {
            throw new NotImplementedException();
        }

        public void GetBufferValue(ref _tagpropertykey key, IntPtr ppValue, out uint pcbValue)
        {
            throw new NotImplementedException();
        }

        public void GetCount(ref uint pcelt)
        {
            throw new NotImplementedException();
        }

        public void GetErrorValue(ref _tagpropertykey key, out int pValue)
        {
            throw new NotImplementedException();
        }

        public void GetFloatValue(ref _tagpropertykey key, out float pValue)
        {
            throw new NotImplementedException();
        }

        public void GetGuidValue(ref _tagpropertykey key, out Guid pValue)
        {
            throw new NotImplementedException();
        }

        public void GetIPortableDeviceKeyCollectionValue(ref _tagpropertykey key, out IPortableDeviceKeyCollection ppValue)
        {
            throw new NotImplementedException();
        }

        public void GetIPortableDevicePropVariantCollectionValue(ref _tagpropertykey key, out IPortableDevicePropVariantCollection ppValue)
        {
            throw new NotImplementedException();
        }

        public void GetIPortableDeviceValuesCollectionValue(ref _tagpropertykey key, out IPortableDeviceValuesCollection ppValue)
        {
            throw new NotImplementedException();
        }

        public void GetIPortableDeviceValuesValue(ref _tagpropertykey key, out IPortableDeviceValues ppValue)
        {
            throw new NotImplementedException();
        }

        public void GetIUnknownValue(ref _tagpropertykey key, out object ppValue)
        {
            throw new NotImplementedException();
        }

        public void GetKeyValue(ref _tagpropertykey key, out _tagpropertykey pValue)
        {
            throw new NotImplementedException();
        }

        public void GetSignedIntegerValue(ref _tagpropertykey key, out int pValue)
        {
            throw new NotImplementedException();
        }

        public void GetSignedLargeIntegerValue(ref _tagpropertykey key, out long pValue)
        {
            throw new NotImplementedException();
        }

        public void GetStringValue(ref _tagpropertykey key, out string pValue)
        {
            throw new NotImplementedException();
        }

        public void GetUnsignedIntegerValue(ref _tagpropertykey key, out uint pValue)
        {
            throw new NotImplementedException();
        }

        public void GetUnsignedLargeIntegerValue(ref _tagpropertykey key, out ulong pValue)
        {
            throw new NotImplementedException();
        }

        public void GetValue(ref _tagpropertykey key, out tag_inner_PROPVARIANT pValue)
        {
            throw new NotImplementedException();
        }

        public void RemoveValue(ref _tagpropertykey key)
        {
            throw new NotImplementedException();
        }

        public void SetBoolValue(ref _tagpropertykey key, int Value)
        {
            throw new NotImplementedException();
        }

        public void SetBufferValue(ref _tagpropertykey key, ref byte pValue, uint cbValue)
        {
            throw new NotImplementedException();
        }

        public void SetErrorValue(ref _tagpropertykey key, int Value)
        {
            throw new NotImplementedException();
        }

        public void SetFloatValue(ref _tagpropertykey key, float Value)
        {
            throw new NotImplementedException();
        }

        public void SetGuidValue(ref _tagpropertykey key, ref Guid Value)
        {
            throw new NotImplementedException();
        }

        public void SetIPortableDeviceKeyCollectionValue(ref _tagpropertykey key, IPortableDeviceKeyCollection pValue)
        {
            throw new NotImplementedException();
        }

        public void SetIPortableDevicePropVariantCollectionValue(ref _tagpropertykey key, IPortableDevicePropVariantCollection pValue)
        {
            throw new NotImplementedException();
        }

        public void SetIPortableDeviceValuesCollectionValue(ref _tagpropertykey key, IPortableDeviceValuesCollection pValue)
        {
            throw new NotImplementedException();
        }

        public void SetIPortableDeviceValuesValue(ref _tagpropertykey key, IPortableDeviceValues pValue)
        {
            throw new NotImplementedException();
        }

        public void SetIUnknownValue(ref _tagpropertykey key, object pValue)
        {
            throw new NotImplementedException();
        }

        public void SetKeyValue(ref _tagpropertykey key, ref _tagpropertykey Value)
        {
            throw new NotImplementedException();
        }

        public void SetSignedIntegerValue(ref _tagpropertykey key, int Value)
        {
            throw new NotImplementedException();
        }

        public void SetSignedLargeIntegerValue(ref _tagpropertykey key, long Value)
        {
            throw new NotImplementedException();
        }

        public void SetStringValue(ref _tagpropertykey key, string Value)
        {
            throw new NotImplementedException();
        }

        public void SetUnsignedIntegerValue(ref _tagpropertykey key, uint Value)
        {
            throw new NotImplementedException();
        }

        public void SetUnsignedLargeIntegerValue(ref _tagpropertykey key, ulong Value)
        {
            throw new NotImplementedException();
        }

        public void SetValue(ref _tagpropertykey key, ref tag_inner_PROPVARIANT pValue)
        {
            throw new NotImplementedException();
        }
    }
}
