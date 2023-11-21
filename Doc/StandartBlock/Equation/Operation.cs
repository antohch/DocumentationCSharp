using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    internal class Operation : Expression
    {
        Expression _left;
        char _op;
        Expression _right;
        public Operation(Expression left, char op, Expression right)
        {
            _left = left;
            _op = op;
            _right = right;
        }

        public override double Evaluatie(Dictionary<string, object> vars)
        {
            double x = _left.Evaluatie(vars);
            double y = _right.Evaluatie(vars);
            switch (_op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;

                default: throw new Exception("Unkown operation");
            }
        }
    }
}
