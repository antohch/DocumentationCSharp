using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }
}
