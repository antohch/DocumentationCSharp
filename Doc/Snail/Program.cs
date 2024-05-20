using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = 0b_101 ^ 0b_110;
            Console.WriteLine(x);
            int[][] ar =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            int[] array = SnailSolution.Snail(ar);

            foreach (int i in array)
            {
                Console.Write("{0} - ", i);
            }
            Console.WriteLine(array);

            Console.ReadKey();

        }
    }
}
