using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Book
    {
        
        public class Notes
        {
            string note;
            public string Note 
            {
                get
                {
                    return note;
                }
                set
                {
                    if (note == null)
                        note = value;
                    else
                        note += "\n" + value;
                } 
            }
        }

        string[] content;
        public Book(int strCount)
        {
            content = new string[strCount];
            for (int i = 0; i < content.Length; i++)
            {
                content[i] = i.ToString();
            }
        }

        public void FindAndReplace(string finderStr)
        {
            string result = "Строку не найдено.";
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == finderStr)
                {
                    result = "Строка найдена: " + content[i];
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
