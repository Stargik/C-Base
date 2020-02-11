using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Название");
            book.AuthorField = "Автор";
            book.ContentField = "Контент";
            book.Show();

        }
    }
}
