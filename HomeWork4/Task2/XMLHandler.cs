using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Document XML changed.");
        }

        public override void Create()
        {
            Console.WriteLine("Document XML created.");
        }

        public override void Open()
        {
            Console.WriteLine("Document XML opened.");
        }

        public override void Save()
        {
            Console.WriteLine("Document XML saved.");
        }
    }
}
