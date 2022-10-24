using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            FileInfo edit = new FileInfo("D:\\myfile.txt");
            Console.WriteLine($"Минуле розширення документа: {edit.Extension}");
            var newextension = System.IO.Path.ChangeExtension("D:\\myfile.txt", ".docx");
            File.Move("D:\\myfile.txt", System.IO.Path.ChangeExtension("D:\\myfile.txt", ".doc"));
            Console.WriteLine($"Документ збережений в новому форматi {edit.Extension}");
        }
    }
}
