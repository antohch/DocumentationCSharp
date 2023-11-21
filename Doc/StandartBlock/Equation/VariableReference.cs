using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    internal class VariableReference : Expression
    {
        string _name;
        public VariableReference(string name)
        {
            _name = name;
        }

        public override double Evaluatie(Dictionary<string, object> vars)
        {
            object value = vars[_name] ?? throw new Exception($"Unkown variable: {_name}");
            return Convert.ToDouble(value);
        }
    }
}
