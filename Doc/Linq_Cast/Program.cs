using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query = fruits.Cast<string>().OrderBy(x => x).Select(x => x);

            foreach(string fruit in query)
            {
                Console.WriteLine(fruit);
            }

            IEnumerable sequence = Enumerable.Range(0, 10);
            var doubles = from int item in sequence
                          select (double)item;
            foreach(double item in doubles)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
