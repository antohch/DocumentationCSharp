using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            father.FindOut(Mark.Five);
            father.FindOut(Mark.Five);
            father.FindOut(Mark.Five);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Five);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Two);
            father.FindOut(Mark.Five);
            father.FindOut(Mark.Five);

            Console.ReadKey();
        }
    }
}
