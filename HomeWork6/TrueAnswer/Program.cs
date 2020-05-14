using System;

namespace TrueAnswer
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }

    public class Note
    {
        string text = "";
        public string Text
        {
            get { return text; }
            set
            {
                if (text != "")
                    text += "\n";
                text += value;
            }

        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
            FindAndReplaceManager.FindNext("Hello");

            // Delay.
            Console.ReadKey();
        }
    }
}
