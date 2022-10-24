using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
           
            Console.WriteLine("Внесiть змiни в документ:");
            string editText = Console.ReadLine();
            using (FileStream edit = new FileStream("D:\\myfile.txt", FileMode.Open))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(editText);
                edit.Write(array, 0, array.Length);
                Console.WriteLine("Документ вiдредаговано");
            }
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї Експерт");
        }
    }
}
