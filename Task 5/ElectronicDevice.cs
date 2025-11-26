using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private decimal price;
        public string getBrand() { return brand; }
        public void setBrand(string b) { brand = b; }

        public decimal getPrice() { return price; }
        public void setPrice(decimal p) { price = p; }

        public ElectronicDevice(string brand, decimal price)
        {
            this.brand = brand;
            this.price = price;
        }

        public abstract void ShowInfo();
    }
}
