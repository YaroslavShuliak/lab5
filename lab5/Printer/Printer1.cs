using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Printer1 : Printer
    {
        public override void Print<T>(string value, T a)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Company: {value} Model: {a} ");
        }
    }
}
