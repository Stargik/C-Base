using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(2, 4, 2, 4);
            Block block2 = new Block(2, 4, 2, 4);
            Block block3 = new Block(3, 4, 3, 4);
            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2);
            Console.WriteLine(block3);
            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine(block1.Equals(block3));
        }
    }
}
