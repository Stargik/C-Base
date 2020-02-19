using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Ученик хорошо учится.");
        }

        public override void Read()
        {
            Console.WriteLine("Ученик хорошо читает.");
        }

        public override void Write()
        {
            Console.WriteLine("Ученик хорошо пишет.");
        }

        public override void Relax()
        {
            Console.WriteLine("Ученик иногда отдыхает.");
        }
    }
}
