using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            using (FileStream s = File.OpenRead("D:\\myfile.txt"))
            {
                Console.WriteLine("Документ вiдкритий");
                byte[] array = new byte[s.Length];
                s.Read(array, 0, array.Length);
                string a = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(a);
            }
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версiї Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версiї Про");
        }
        static void Main(string[] args)
        {
            DocumentWorker documentworker = new DocumentWorker();
            ProDocumentWorker prodocumentworker = new ProDocumentWorker();
            ExpertDocumentWorker expertdocumentworker = new ExpertDocumentWorker();
            int pro = 1, exp = 2;
            int key = 0;
            Console.WriteLine("Ви маєте ключ доступу? так/нет");
            string k = Console.ReadLine();
            if (k == "так")
            {
                Console.WriteLine("Введiть код доступу:");
                key = int.Parse(Console.ReadLine());
            }
            documentworker.OpenDocument();
            if (key == pro || key == exp)
                prodocumentworker.EditDocument();
            else
                documentworker.EditDocument();
            if (key == exp)
                expertdocumentworker.SaveDocument();
            else if (key == pro)
                prodocumentworker.SaveDocument();
            else
                documentworker.SaveDocument();
        }
    }
}
