using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Figure
    {
        Point[] points;
        string type;

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.points = new Point[5];
            this.points[0] = point1;
            this.points[1] = point2;
            this.points[2] = point3;
            this.points[3] = point4;
            this.points[4] = point5;
            
            this.type = "пятиугольник";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.points = new Point[4];
            this.points[0] = point1;
            this.points[1] = point2;
            this.points[2] = point3;
            this.points[3] = point4;
            this.type = "четырехугольник";
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            this.points = new Point[3];
            this.points[0] = point1;
            this.points[1] = point2;
            this.points[2] = point3;
            this.type = "треугольник";
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0d;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(this.points[0], points[this.points.Length - 1]);
            Console.WriteLine($"Тип: {this.type}\nПериметр: {perimeter}");

        }
    }
}
