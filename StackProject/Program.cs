using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackMadeDll;

namespace StackProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new StackMade<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.ReadLine();
        }
    }
}
