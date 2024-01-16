using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionTest
{
    internal class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y==0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            double a = 98, b = 0;
            double result;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divide by {1} = {2}", a, b, result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            Console.ReadKey();
        }
    }
}
