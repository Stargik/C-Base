using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Plane : Vehicle
    {
        public int height, countPassenger;

        public Plane(double x, double y, int price, int speed, int release, int height, int countPassenger)
            : base(x, y, price, speed, release)
        {
            this.height = height;
            this.countPassenger = countPassenger;
        }

        public void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"countPassenger: {countPassenger}");
            Console.WriteLine($"height: {height}");
        }
    }
}
