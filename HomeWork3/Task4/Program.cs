using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pro = 2468;
            const int exp = 1357;
            int key = 0;
            Console.WriteLine("Введите ключ доступа: ");
            string keyStr = Console.ReadLine();
            if (!String.IsNullOrEmpty(keyStr))
            {
                 key = Convert.ToInt32(keyStr);
            }
            
            DocumentWorker documentWorker = null;

            switch (key)
            {
                case pro:
                    documentWorker = new ProDocumentWorker();
                    break;
                case exp:
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
