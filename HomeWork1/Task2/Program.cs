using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Высота: ");
            double side1 = Double.Parse(Console.ReadLine());
            Console.Write("Ширина: ");
            double side2 = Double.Parse(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь: {rectangle.Area} \nПериметр: {rectangle.Perimeter}");
        }
    }
}
