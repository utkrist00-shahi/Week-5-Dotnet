using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Motorcycle : Vehicle
    {
        public string Type { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Type: " + Type);
        }
    }
}
