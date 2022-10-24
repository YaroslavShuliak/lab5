using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Оцiнки студента:");
        }
        public virtual void Read()
        {
            Console.WriteLine("Скiльки читає студент:");
        }
        public virtual void Write()
        {
            Console.WriteLine("Якою рукою пише студент:");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Скiльки вiдпочиває студент:");
        }
    }
}
