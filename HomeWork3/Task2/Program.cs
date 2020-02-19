using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();
            ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil, badPupil);
            classRoom.GetInformation();
        }
    }
}
