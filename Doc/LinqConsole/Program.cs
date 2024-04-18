using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            string longestName = fruits.Aggregate((longest, next) => next.Length > longest.Length ? next : longest);
            Console.WriteLine(longestName);

            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            int numEven = ints.Aggregate(0, (total, next) => next % 2 == 0 ? total + 1 : total);
            Console.WriteLine(numEven);

            int[] ints1 = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            int numEven1 = ints.Aggregate(0, (total, next) => ++total);
            Console.WriteLine(numEven1);

            string sentence = "the quick brown fox jumps over the lazy dog";
            string[] words = sentence.Split(' ');
            string reversed = words.Aggregate((workingSentence, next) => next + " " + workingSentence);
            Console.WriteLine(reversed);
        }
    }
}
