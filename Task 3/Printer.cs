using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine($"String message: {message}");
        }

        public void Print(int number)
        {
            Console.WriteLine($"Integer number: {number}");
        }

        public void Print(string message, int count)
        {
            Console.WriteLine($"Repeating '{message}' {count} times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"- {message}");
            }
        }
    }
}
