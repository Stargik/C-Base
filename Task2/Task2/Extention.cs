using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    static class Extention
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }
}
