using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Post worker = Post.Manager;
            int hours = 100;
            Accauntant accauntant = new Accauntant();
            if (accauntant.AskForBonus(worker, hours))
            {
                Console.WriteLine("Положена премия.");
            }
            else
            {
                Console.WriteLine("Старайся больше.");
            }
        }
    }
}
