using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article[] articles = 
                { 
                    new Article {ProductName = "Computer", MarketName = "Comfy", Price = 20000 },
                    new Article {ProductName = "Telephone", MarketName = "Foxtrot", Price = 10000 },
                    new Article {ProductName = "TV", MarketName = "Eldorado", Price = 15000 },
                };

            Store store = new Store(articles);

            Console.Write("Product: ");
            string name = Console.ReadLine();
            Console.WriteLine(store[name]);
            Console.WriteLine(store[2]);
        }
    }
}
