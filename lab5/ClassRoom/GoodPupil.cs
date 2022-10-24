using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Cтудент вчиться на 4");
        }
        public override void Read()
        {
            Console.WriteLine("Студент читає 15 сторiнок в день ");
        }
        public override void Write()
        {
            Console.WriteLine("Студент пише правою рукою");
        }
        public override void Relax()
        {
            Console.WriteLine("Студент вiдпочиває 4 години");
        }
    }
}
