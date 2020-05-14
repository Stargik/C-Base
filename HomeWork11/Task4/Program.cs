using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("string");
            arrayList.Add(true);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList[0].GetType());
            Console.WriteLine(arrayList[0]);
        }
    }
}
