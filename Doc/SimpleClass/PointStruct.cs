using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public struct PointStruct
    {
        public double X { get; } 
        public double Y { get; }
        public PointStruct(double x, double y) => (X,Y) = (x,y);
    }
}
