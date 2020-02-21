using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Document DOC changed.");
        }

        public override void Create()
        {
            Console.WriteLine("Document DOC created.");
        }

        public override void Open()
        {
            Console.WriteLine("Document DOC opened.");
        }

        public override void Save()
        {
            Console.WriteLine("Document DOC saved.");
        }
    }
}
