using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    internal class PairParam<TFirst, TSecond>
    {
        public TFirst X { get; }
        public TSecond Y { get; }
        public PairParam(TFirst first, TSecond second) => (X, Y) = (first, second);
    }
}
