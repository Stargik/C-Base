using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindAndReplace("2");

            Book.Notes notes = new Book.Notes();
            notes.Note = "My ";
            notes.Note = "notes.";
            Console.WriteLine(notes.Note);
        }
    }
}
