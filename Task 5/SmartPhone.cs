using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class SmartPhone : ElectronicDevice
    {
        public SmartPhone(string brand, decimal price) : base(brand, price) { }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is ENABLED.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Smartphone details:");
            Console.WriteLine("  Brand : " + getBrand());
            Console.WriteLine("  Price : $" + getPrice());
        }
    }
}
