using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(12345678, "Aleksandr", "TehnoMagaz")
            {
                Article = "Computer",
                Quantity = 3
            };

            Console.WriteLine($"Price with NDS: {invoice.CountPrice(true)}");
            Console.WriteLine($"Price without NDS: {invoice.CountPrice(false)}");
        }
    }
}
