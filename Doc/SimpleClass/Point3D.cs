using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Point3D : Point
    {
        public int Z { get; }
        public Point3D(int x, int y, int z) : base(x, y) 
        {
            Z = z;
        }
    }
}
