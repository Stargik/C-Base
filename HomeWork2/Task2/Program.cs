using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(25, 30, 0.5);
            Console.WriteLine(converter.UahToEur(60)); 
            Console.WriteLine(converter.UahToUsd(50)); 
            Console.WriteLine(converter.UahToRub(30)); 
            Console.WriteLine(converter.EurToUah(1)); 
            Console.WriteLine(converter.UsdToUah(1)); 
            Console.WriteLine(converter.RubToUah(1)); 
        }
    }
}
