using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Printer
    {
        public virtual void Print<T>(string value, T a)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Company: {value} Model: {a}");
        }
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Printer1 printer1 = new Printer1();
            Printer2 printer2 = new Printer2();
            printer.Print<int>("Canon", 3440);
            printer1.Print<string>("HP", "SENSYS_MFU");
            printer2.Print<double>("XEROX", 1.3);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
