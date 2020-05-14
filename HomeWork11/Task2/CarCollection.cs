using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class CarCollection<T> where T : Car
    {
        T[] array = new T[0];

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
        int count;
        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public void Clear()
        {
            array = new T[0];
        }
        public void AddCar(T car)
        {
            T[] cloudArray = new T[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                cloudArray[i] = array[i]; 
            }
            cloudArray[array.Length] = car;
            array = cloudArray;
        }



    }
}
