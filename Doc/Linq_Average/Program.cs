using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long?[] longs = { null, 10007L, 1L, 567L };
            double? average = longs.Average();
            Console.WriteLine(average);

            string[] fruits = { "aaa", "aaaaaaa", "aa" };
            double averStr = fruits.Average( fruit => fruit.Length);
            Console.WriteLine(averStr);

            string[] numbers = { "11000", "10", "58" };
            double averStrNum = numbers.Average(s => long.Parse(s));
            Console.WriteLine(averStrNum);

            Console.ReadLine();
        }
    }
}
