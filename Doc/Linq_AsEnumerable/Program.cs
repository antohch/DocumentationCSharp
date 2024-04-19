using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_AsEnumerable
{
    class Clump<T> : List<T>
    {
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("In Clump's implementation of Where().");
            return Enumerable.Where(this, predicate);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clump<string> fruitCLump = new Clump<string> { "apple", "passionfruit", "banana",
            "mango", "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query1 = fruitCLump.Where(fruit => fruit.Contains("o"));


            IEnumerable<string> query2 = fruitCLump.AsEnumerable().Where(fruit => fruit.Contains("o"));
            Console.ReadKey();
        }
    }
}
