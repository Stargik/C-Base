using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    static class ExstensionMethod
    {
        static public void MySort(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        int buf = arr[j];
                        arr[j] = arr[i];
                        arr[i] = buf;
                    }
                }
            }
        }
    }
}
