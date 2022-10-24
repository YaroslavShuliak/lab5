using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Printer2 : Printer
    {
        public override void Print<T>(string value, T a)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Company: {value} Model: {a}");
        }
    }
}
