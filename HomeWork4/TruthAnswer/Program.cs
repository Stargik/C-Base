using System;

namespace TruthAnswer
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Record()
        {
            Console.WriteLine("Start recording");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause melody");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop melody");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }

    class Program
    {
        static void Main()
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            // Delay.
            Console.ReadKey();
        }
    }
}
