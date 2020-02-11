using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Rectangle
    {
        double side1, side2;
        public double Area { get; }
        public double Perimeter { get; }
        

        
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.Area = AreaCalculator();
            this.Perimeter = PerimeterCalculator();
        }

        public double AreaCalculator()
        {
            return this.side1 * this.side2;
        }

        public double PerimeterCalculator()
        {
            return (this.side1 + this.side2) * 2;
        }
    }
}
