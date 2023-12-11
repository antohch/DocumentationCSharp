using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            car.Year = "1999";
            car2.Year = "1999";
            Console.WriteLine(car.Equals(car2));

            Console.ReadLine();
        }
    }
}
