using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Go
    {
        static void Main(string[] args)
        {
            Classroom clasroom = new Classroom();
            ExcelentPupil excelentpupil = new ExcelentPupil();
            GoodPupil goodpupil = new GoodPupil();
            BadPupil badpupil = new BadPupil();
            Console.WriteLine("Оберiть iм'я студента: Ozon, VJlink, Hovanskiy, Maddison");
            string student = Console.ReadLine();
            if (student == clasroom.Name)
            {
                excelentpupil.Study();
                excelentpupil.Read();
                excelentpupil.Write();
                excelentpupil.Relax();
            }
            else if (student == clasroom.Name2)
            {
                goodpupil.Study();
                goodpupil.Read();
                goodpupil.Write();
                goodpupil.Relax();
            }
            else if (student == clasroom.Name3)
            {
                badpupil.Study();
                badpupil.Read();
                badpupil.Write();
                badpupil.Relax();
            }
            else if (student == clasroom.Name1)
            {
                badpupil.Study();
                badpupil.Read();
                badpupil.Write();
                badpupil.Relax();
            }
        }
    }
}
