using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDraw
{
    internal class Shape
    {
        public int x { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
}
