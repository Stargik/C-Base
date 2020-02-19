using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Ship : Vehicle
    {
        public int countPassenger;
        public string port;

        public Ship(double x, double y, int price, int speed, int release, int countPassenger, string port)
            : base(x, y, price, speed, release)
        {
            this.countPassenger = countPassenger;
            this.port = port;
        }

        public void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"countPassenger: {countPassenger}");
            Console.WriteLine($"port: {port}");
        }
    }
}
