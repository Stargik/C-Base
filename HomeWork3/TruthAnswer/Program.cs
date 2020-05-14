using System;

namespace TruthAnswer
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в других форматах");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "prof":
                    doc = new ProDocumentWorker();
                    break;
                case "expert":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("Ключ неверен");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }

    }
}
