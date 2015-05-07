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
}
