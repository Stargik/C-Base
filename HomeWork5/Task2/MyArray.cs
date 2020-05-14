using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class MyArray
    {
        int[] arr = null;
        public MyArray(int count)
        {
            Random random = new Random();
            arr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 20);
                Console.Write(arr[i] + ", ");
            }
        }
            public void MinValue()
            {
                int minIndex = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    minIndex = arr[minIndex] <= arr[i] ? minIndex : i;
                }
                Console.WriteLine(arr[minIndex]);
            }

            public void MaxValue()
            {
                int maxIndex = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    maxIndex = arr[maxIndex] >= arr[i] ? maxIndex : i;
                }
                Console.WriteLine(arr[maxIndex]);
            }

            public void SumValue()
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine(sum);
            }

            public void SrAr()
            {
                double result;
                double sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                result = sum / arr.Length;
                Console.WriteLine(result);
            }

            public void ShowNotPair()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
            }
        
    }
}
