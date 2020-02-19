using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        public double x, y;
        public int price, speed, release;

        public Vehicle()
        {
        }
        public Vehicle(double x, double y, int price, int speed, int release)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.release = release;
        }
        
        public void GetInformation()
        {
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
            Console.WriteLine($"price: {price}");
            Console.WriteLine($"speed: {speed}");
            Console.WriteLine($"release: {release}");
        }
    }
}
