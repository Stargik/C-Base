using System;

namespace Task3
{
    interface IDictionary<TKey, TValue>
    {
        void SetElement(TKey key, TValue value);
        string this[int key] { get; }
        int Count { get; }
    }
    class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        TKey[] keys = new TKey[0];
        TValue[] values = new TValue[0];

        public string this [int key]
        {
            get
            {
                    return keys[key] + " = " + values[key];
            }
        }
        public void SetElement(TKey key, TValue value)
        {
            TKey[] cloudKeys = new TKey[keys.Length + 1];
            TValue[] cloudValues = new TValue[values.Length + 1];
            for (int i = 0; i < keys.Length; i++)
            {
                cloudValues[i] = values[i];
                cloudKeys[i] = keys[i];
            }
            cloudValues[values.Length] = value;
            cloudKeys[keys.Length] = key;
            values = cloudValues;
            keys = cloudKeys;
        }

        public int Count
        {
            get
            {
                return keys.Length;
            }
        } 
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.SetElement("привет", "hello");
            myDictionary.SetElement("пока", "goodbye");
            Console.WriteLine(myDictionary.Count);
            Console.WriteLine(myDictionary[0]);
            Console.WriteLine(myDictionary[1]);
        }
    }
}
