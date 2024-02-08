using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStyle
{
    public delegate void Del(string message);
    internal class Program
    {
        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument: {0}", str);
        }
        public static void DelMethod2(string str)
        {
            Console.WriteLine("DelMethod2 argument: {0}", str);
        }
        static double ComputeDistance(double x1, double y1, double x2, double y2)
        {
            try
            {
                return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            }
            catch (System.ArithmeticException ex)
            {
                Console.WriteLine($"Arithmetic overflow or underflow: {ex}");
                throw;
            }
        }
        static void Main(string[] args)
        {
            Del exampleDel2 = DelMethod;
            exampleDel2 += DelMethod2;
            exampleDel2("Hey");

            Del exampleDel1 = new Del(DelMethod);
            exampleDel1("Hey");

            using (Font arial = new Font("Arial", 10.0f))
            {
                byte charset = arial.GdiCharSet;
            }

            Console.WriteLine("Ender a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            if ((divisor != 0) && (dividend / divisor) is var result)
            {
                Console.WriteLine("Quotient: {0}", result);
            }
            else
            {
                Console.WriteLine("Attempted divison by o ends up here.");
            }

            var message = "This is clearly a string.";
            var currentTemperature = 27;

            int numberOfIterations = Convert.ToInt32(Console.ReadLine());

            var phrase = "lalalalalalalalalalalalalala";
            var manyPhrases = new StringBuilder();
            for (var i =0; i < 1000; i++)
            {
                manyPhrases.Append(phrase);
            }
            Console.WriteLine(manyPhrases);

            foreach(char ch in "laugh")
            {
                if (ch == 'h')
                    Console.WriteLine("H");
                else
                    Console.WriteLine(ch);
            }

            Console.ReadKey();
        }
    }
}
