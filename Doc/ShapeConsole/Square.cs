using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    public class Square : Shape
    {
        public Square(double length)
        {
            Side = length;
        }
        public double Side { get; }
        public override double Area => Math.Pow(Side, 2);

        public override double Perimeter => Side * 4;
        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
    }

    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area => Length * Width;

        public override double Perimeter => 2 * Length + 2 * Width;

        public double Length { get; }
        public double Width { get; }
        public bool IsSquare() => Length == Width;
        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length,2)+Math.Pow(Width,2)),2);
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius,2),2);

        public override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2);

        public double Radius { get; }
        public double Circumference => Perimeter;
        public double Diameter => Radius * 2;
    }
}
