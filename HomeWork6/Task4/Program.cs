using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 7, 3, 7, 4, 2, 0, 1 };
            arr.MySort();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
