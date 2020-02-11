using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 5);
            Point point2 = new Point(8, 5);
            Point point3 = new Point(8, 3);
            Point point4 = new Point(0, 3);
            Figure figure = new Figure(point1, point2, point3, point4);
            figure.PerimeterCalculator();
        }
    }
}
