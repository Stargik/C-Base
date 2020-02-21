using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select the mode: ");
            string mode = Console.ReadLine();
            Player player = new Player();
            
            switch (mode.ToLower())
            {
                case "record":
                    Console.WriteLine("Available action in this mode:");
                    IRecodable recodable = player;
                    recodable.Record();
                    recodable.Pause();
                    recodable.Stop();
                    break;
                case "play":
                    Console.WriteLine("Available action in this mode:");
                    IPlayable playable = player;
                    playable.Play();
                    playable.Pause();
                    playable.Stop();
                    break;
                default:
                    Console.WriteLine("The mode is not exist.");
                    break;
            }

            
        }
    }
}
