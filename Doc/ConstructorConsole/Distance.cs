using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConsole
{
    public struct Distance(double dx, double dy)
    {
        public readonly double Magnitude => Math.Sqrt(dx * dx + dy * dy);
        public readonly double Direction => Math.Atan2(dy, dx);

        public void Translate(double deltaX, double deltaY)
        {
            dx += deltaX;
            dy += deltaY;
        }

        public Distance() : this(0, 0) { }
    }
}
