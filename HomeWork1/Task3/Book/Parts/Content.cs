using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Content
    {
        private string field = null;

        public string Field
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Field);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
