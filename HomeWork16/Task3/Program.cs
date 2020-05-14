using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.A = 2;
            house.B = 4;
            House house1 = house.Clone() as House;
            House house2 = house.DeepClone() as House;
            Console.WriteLine(house.GetHashCode() + ": " + house.A + " " + house.B);
            Console.WriteLine(house1.GetHashCode() + ": " + house1.A + " " + house1.B);
            Console.WriteLine(house2.GetHashCode() + ": " + house2.A + " " + house2.B);
            house.A = 8;
            house2.A = 6;
            Console.WriteLine(house.GetHashCode() + ": " + house.A + " " + house.B);
            Console.WriteLine(house1.GetHashCode() + ": " + house1.A + " " + house1.B);
            Console.WriteLine(house2.GetHashCode() + ": " + house2.A + " " + house2.B);
        }
    }
}
