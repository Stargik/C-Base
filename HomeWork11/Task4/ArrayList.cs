using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ArrayList
    {
        object[] array = new object[0];

        public object this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public void Add(object item)
        {
            
            object[] cloudArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                cloudArray[i] = array[i];
            }
            cloudArray[array.Length] = item;
            array = cloudArray;
        }
        public int Count
        {
            get
            {
                return array.Length;
            }
        }
    }
}
