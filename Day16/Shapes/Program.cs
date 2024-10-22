using System;
using System.Linq;
using System.Collections.Generic;

namespace Shapes
{
    interface ICalc
    {
        public double GetArea();
        public double GetPerimeter();
    }
    class Circle : ICalc
    {
        public double Radius { get; set; }
        public double GetArea() => 3.14 * Radius * Radius;
        public double GetPerimeter() => 2 * 3.14 * Radius;
    }

    class Rectangle : ICalc
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double GetArea() => Length * Breadth;
        public double GetPerimeter() => 2 * (Length + Breadth);


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<ICalc>()
            {
                new Circle{Radius = 2.2},
                new Rectangle{Length = 14, Breadth = 6.1},
                new Rectangle{Length = 12, Breadth = 8}
            };

            foreach(var shape in shapes)
            {
                System.Console.WriteLine($"Area : {shape.GetArea()}     Perimeter : {shape.GetPerimeter()}");
            }


        }
    }

}