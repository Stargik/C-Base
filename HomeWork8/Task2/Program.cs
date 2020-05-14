using System;

namespace Task2
{
    enum Colors
    {
        red = 1,
        blue = 2,
        yellow = 3,
        green = 4
    }
    static class CustomPrinter
    {
        public static void Print(string stroka, int color)
        {
            Colors codeColor = (Colors)color;
            switch (codeColor)
            {
                case Colors.red:
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.blue:
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.green:
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine(stroka);
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string mes = Console.ReadLine();
            Console.Write("Введите номер цвета: ");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            CustomPrinter.Print(mes, color);
            
        }
    }
}
