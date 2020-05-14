using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate myDate1 = new MyDate(2006, 12, 20);
            MyDate myDate2 = new MyDate(2005, 10, 20);
            Console.WriteLine(myDate1 == myDate2);
            myDate1 = myDate1 + 20;
            Console.WriteLine(myDate1.year + "." + myDate1.month + "." + myDate1.day);
        }
    }
}
