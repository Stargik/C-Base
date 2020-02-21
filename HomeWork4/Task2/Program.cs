using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set the document format: ");
            string format = Console.ReadLine();
            AbstractHandler handler = null;
            switch (format.ToUpper())
            {
                case "DOC":
                    handler = new DOCHandler();
                    break;
                case "TXT":
                    handler = new TXTHandler();
                    break;
                case "XML":
                    handler = new XMLHandler();
                    break;
                default:
                    Console.WriteLine("Format is not supported.");
                    break;
            }

            Console.WriteLine("Available action with document:");
            handler.Create();
            handler.Open();
            handler.Chenge();
            handler.Save();

        }
    }
}
