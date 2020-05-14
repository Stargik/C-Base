using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class MyList<T> :  IEnumerable<T>
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
        public void Add(T car)
        {
            T[] cloudArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                cloudArray[i] = array[i];
            }
            cloudArray[array.Length] = car;
            array = cloudArray;
        }

        int position = -1;
        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
