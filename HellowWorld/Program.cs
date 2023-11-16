using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            int j = (int)o;

            Console.WriteLine(j);
            Console.WriteLine(o);

            Console.WriteLine("Hellow World");

            Console.ReadKey();
        }
    }
}
