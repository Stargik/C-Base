using System;

namespace Task4
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
            
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "Не изменено";
            myStruct.change = "Не изменено";
            Console.WriteLine("myClass: " + myClass.change);
            Console.WriteLine("myStruct: " + myStruct.change);
            ClassTaker(myClass);
            StruktTaker(myStruct);
            //myStruct.change = "Changed";
            Console.WriteLine("myClass: " + myClass.change);
            Console.WriteLine("myStruct: " + myStruct.change);
        }
    }
}
