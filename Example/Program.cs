using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Acme.Collection.Stack<int>();
            s.Push(1);
            s.Push(10);
            s.Push(100);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.ReadLine();
        }
    }
}
