using System;
using System.Threading;
namespace Task13
{
    class ThreadProduction
    {
        static object locker = new object();
        int length, position;
        Random random;
        public ThreadProduction(int position)
        {
            this.random = new Random();
            this.length = random.Next(3, 10);
            this.position = position;
        }

        public void ShowThread()
        {
            while (true)
            {
                lock (locker)
                {
                    for (int currentCount = 0; currentCount < 40; currentCount++)
                    {
                        Console.CursorTop = 0;
                        Console.CursorLeft = position;

                        if (length >= currentCount)
                        {
                            for (int i = 0; i < currentCount; i++)
                            {

                                if (i == currentCount - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (i == currentCount - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                // Thread.Sleep(1000);

                            }
                        }
                        else if (currentCount > length)
                        {

                            for (int n = 0; n < currentCount - length; n++)
                            {
                                
                                    Console.WriteLine(new String(' ', position));
                                
                                

                            }
                            for (int i = 0; i < length; i++)
                            {

                                if (i == length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (i == length - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine(random.Next(0, 99));
                                    Console.ForegroundColor = ConsoleColor.White;
                                }


                            }
                        }

                        Thread.Sleep(100);
                    }
                }
                

            }





        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            for (int i = 0; i < 40; i++)
            {
                new Thread(new ThreadProduction(i*2).ShowThread).Start();
            }
            
        }
    }
}



