using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDraw
{
    internal class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
