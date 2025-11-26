using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class ElectronicStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine("Device added to store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine("Device removed from store.");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Devices in Store ---");
            foreach (var dev in devices)
            {
                dev.ShowInfo();                 

              
                if (dev is Laptop lp)
                {
                    lp.TurnOnBattery();
                }
                else if (dev is SmartPhone sp)
                {
                    sp.EnableCamera();
                }
                Console.WriteLine();
            }
        }
    }
}
