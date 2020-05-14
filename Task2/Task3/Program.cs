using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Число1", "Значение1");
            dictionary.Add("Число2", "Значение2");
            dictionary.Add("Число3", "Значение3");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
