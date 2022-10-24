using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Cтудент вчиться на 5");
        }
        public override void Read()
        {
            Console.WriteLine($"Студент читає 40 сторiнок в день ");
        }
        public override void Write()
        {
            Console.WriteLine($"Студент пише лiвою рукою");
        }
        public override void Relax()
        {
            Console.WriteLine($"Студент вiдпочиває 2 години");
        }
    }
}
