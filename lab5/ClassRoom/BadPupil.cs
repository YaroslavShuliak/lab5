using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Cтудент вчиться на 2");
        }
        public override void Read()
        {
            Console.WriteLine("Студент не читає");
        }
        public override void Write()
        {
            Console.WriteLine("Студент пише правою рукою");
        }
        public override void Relax()
        {
            Console.WriteLine("Студент вiдпочиває 6 годин");
        }
    }
}
