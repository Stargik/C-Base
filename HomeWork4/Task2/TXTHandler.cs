using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Document TXT changed.");
        }

        public override void Create()
        {
            Console.WriteLine("Document TXT created.");
        }

        public override void Open()
        {
            Console.WriteLine("Document TXT opened.");
        }

        public override void Save()
        {
            Console.WriteLine("Document TXT saved.");
        }
    }
}
