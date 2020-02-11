using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Figure
    {
        Point point1, point2, point3, point4, point5;
        string type;

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            this.type = "пятиугольник";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.type = "четырехугольник";
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.type = "треугольник";
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter;
            switch (type)
            {
                case "пятиугольник":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1);
                    Console.WriteLine($"Пятиугольник. Периметр: {perimeter}");
                    break;
                case "четырехугольник":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point1);
                    Console.WriteLine($"Четырехугольник. Периметр: {perimeter}");
                    break;
                case "треугольник":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point1);
                    Console.WriteLine($"Треугольник. Периметр: {perimeter}");
                    break;
                default:
                    break;
            }
        }
    }
}
