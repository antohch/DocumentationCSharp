using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public override string ToString() => GetType().Name;
        public static double GetArea(Shape shape) => shape.Area;
        public static double GetPerimeter(Shape shape) => shape.Perimeter;
    }
}
