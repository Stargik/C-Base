using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                prices[i].name = Console.ReadLine();
                Console.Write("Market: ");
                prices[i].market = Console.ReadLine();
                Console.Write("Price: ");
                prices[i].price = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Information of market: ");
            string current = Console.ReadLine();
            int index = -1;
            try
            {
                
                for (int i = 0; i < prices.Length; i++)
                {
                    if (current == prices[i].market)
                    {
                        index = i;
                    }
                }
                if (index == -1)
                {
                    throw new Exception("Not found this market.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prices[index].name);
        }
    }
}
