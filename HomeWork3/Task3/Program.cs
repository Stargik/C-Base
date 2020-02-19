using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane(2, 4, 200, 2000, 2006, 3000, 200);
            Vehicle ship = new Ship(2, 4, 150, 200, 2000, 500, "Odessa");
            Vehicle Car = new Car(2, 4, 100, 90, 2011);
            Console.WriteLine("Plane");
            plane.GetInformation();
            Console.WriteLine("Ship");
            ship.GetInformation();
            Console.WriteLine("Car");
            Car.GetInformation();
        }
    }
}
