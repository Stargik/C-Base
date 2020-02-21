using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
