using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class FindAndReplaceManager
    {
        public static void FindAndReplace(string finderStr)
        {
            Book book = new Book(10);
            book.FindAndReplace(finderStr);
        }
    }
}
