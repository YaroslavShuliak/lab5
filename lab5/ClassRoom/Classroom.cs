using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class Classroom
    {
        private string name = "Ozon";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string name1 = "VJlink";
        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }
        private string name2 = "Hovanskiy";
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }
        private string name3 = "Maddison";
        public string Name3
        {
            get { return name3; }
            set { name3 = value; }
        }
        public Classroom()
        {
            ExcelentPupil excelentpupil = new ExcelentPupil();
            GoodPupil goodpupil = new GoodPupil();
            BadPupil badpupil = new BadPupil();
            excelentpupil.Study();
            excelentpupil.Read();
            excelentpupil.Write();
            excelentpupil.Relax();
            Console.WriteLine("\t");
            goodpupil.Study();
            goodpupil.Read();
            goodpupil.Write();
            goodpupil.Relax();
            Console.WriteLine("\t");
            badpupil.Study();
            badpupil.Read();
            badpupil.Write();
            badpupil.Relax();
            Console.WriteLine("\t");
        }
    }
}
