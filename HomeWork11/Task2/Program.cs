using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.AddCar(new Car("Toyota", 2010));
            carCollection.AddCar(new Car("Ford", 2012));
            carCollection.AddCar(new Car("Nissan", 2014));
            Console.WriteLine($"Name: {carCollection[1].name}\nYear: {carCollection[1].year}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(carCollection.Count);
            Console.WriteLine(new string('-', 30));
            carCollection.Clear();
            Console.WriteLine(carCollection.Count);
        }
    }
}
