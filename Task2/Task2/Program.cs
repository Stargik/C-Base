using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                myList.Add(i);
            }

            foreach (var item in myList)
            {
                Console.WriteLine((int)item);
            }

            int[] arr = myList.GetArray();
            foreach (var item in arr)
            {
                Console.WriteLine((int)item);
            }
        }
    }
}
