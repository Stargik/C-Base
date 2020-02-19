using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        Pupil pupil1, pupil2, pupil3, pupil4;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = new Pupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = new Pupil();
            this.pupil4 = new Pupil();
        }

        public void GetInformation()
        {
            Console.WriteLine("Ученик 1:");
            pupil1.Read();
            pupil1.Study();
            pupil1.Write();
            pupil1.Relax();

            Console.WriteLine("Ученик 2:");
            pupil2.Read();
            pupil2.Study();
            pupil2.Write();
            pupil2.Relax();

            Console.WriteLine("Ученик 3:");
            pupil3.Read();
            pupil3.Study();
            pupil3.Write();
            pupil3.Relax();

            Console.WriteLine("Ученик 4:");
            pupil4.Read();
            pupil4.Study();
            pupil4.Write();
            pupil4.Relax();
        }
    }
}
