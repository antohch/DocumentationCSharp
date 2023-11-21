using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    internal class Constant : Expression
    {
        double _value;
        public Constant(double value)
        {
            _value = value;
        }

        public override double Evaluatie(Dictionary<string, object> vars)
        {
            return _value;
        }
    }
}
