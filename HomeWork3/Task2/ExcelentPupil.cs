using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Ученик отлично учится.");
        }

        public override void Read()
        {
            Console.WriteLine("Ученик отлично читает.");
        }

        public override void Write()
        {
            Console.WriteLine("Ученик отлично пишет.");
        }

        public override void Relax()
        {
            Console.WriteLine("Ученик редко отдыхает.");
        }
    }
}
