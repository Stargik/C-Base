using System;

namespace Task4
{

    interface IMyList<T>
    {
        void SetValue(T value);
        int Length { get; }
        T this[int index] { get; }
    }

    class MyList<T> : IMyList<T>
    {
        private T[] arr = null;
        public MyList()
        {
            arr = new T[0];
        }

        public T this[int index]
        {
            get { return arr[index]; }
        }

        public void SetValue(T value)
        {
            T[] cloudArr = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                cloudArr[i] = arr[i];
            }
            cloudArr[arr.Length] = value;
            arr = cloudArr;
        }
        public int Length
        {
            get { return arr.Length; }
        }

    }

    static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] ts = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                ts[i] = list[i];
            }
            return ts;
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.SetValue("Hello");
            myList.SetValue("Hello");
            myList.SetValue("Hello");
            myList.SetValue("Hello");
            myList.SetValue("Hello");

            string[] arr = myList.GetArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
