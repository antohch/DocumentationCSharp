using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            Console.ReadKey();
        }
    }
}
