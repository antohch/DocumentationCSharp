using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    public abstract class Expression
    {
        public abstract double Evaluatie(Dictionary<string, object> vars);
    }
}
