using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name: ");
                workers[i].name = Console.ReadLine();
                Console.Write("Position: ");
                workers[i].position = Console.ReadLine();
                try
                {
                    Console.Write("Date of register: ");
                    int registerDate = Int32.Parse(Console.ReadLine());
                    if (registerDate > DateTime.Now.Year)
                    {
                        throw new Exception(workers[i].name);
                    }
                    workers[i].registerDate = registerDate;
                    
                }
                catch (Exception e)
                {

                    Console.WriteLine("It`s not true date.");
                    Console.WriteLine(e.Message);
                }
                
            }

        }
    }
}
