using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class Owner
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car { Mark = "Toyota", Model = "Accord", Color = "Red", Year = 2006 },
                new Car { Mark = "Honda", Model = "Civic", Color = "Green", Year = 2008 },
                new Car { Mark = "Nissan", Model = "350Z", Color = "Blue", Year = 20010 },
            };
            var owners = new List<Owner>
            {
                new Owner {Model = "Civic", Name = "Artem", Telephone = "2222222222" },
                new Owner {Model = "350Z", Name = "Alex", Telephone = "3333333333" },
                new Owner {Model = "Accord", Name = "Ivan", Telephone = "4444444444" },
            };
            string name = Console.ReadLine();
            var query = from owner in owners
                        join car in cars
                        on owner.Model equals car.Model
                        where owner.Name == name
                        select new
                        {
                            Model = owner.Model,
                            Name = owner.Name,
                            Telephone = owner.Telephone,
                            Mark = car.Mark,
                            Color = car.Color,
                            Year = car.Year
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Telephone);
                Console.WriteLine(item.Mark);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.Year);
            }
        }
    }
}
