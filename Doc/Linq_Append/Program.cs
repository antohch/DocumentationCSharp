using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            numbers.Append(5);
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine(string.Join(", ", numbers.Append(5)));

            List<int> newNumbers = numbers.Append(5).ToList();
            Console.WriteLine(string.Join(", ", newNumbers));
        }
    }
}
