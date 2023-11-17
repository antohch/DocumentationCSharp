using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 20);
            Point point2 = new Point(30, 40);
            
            Console.WriteLine(point1.X + " " + point1.Y);
            Console.WriteLine(point2.X + " " + point2.Y);
            
            Console.WriteLine(new string('-',20));
            
            var factory = new PointFactory(10);
            foreach (var point in factory.CreatePoints()) 
            {
                Console.WriteLine($"{point.X}, {point.Y}");
            }
            
            Console.WriteLine(new string('-',20));

            var pairParam = new PairParam<int, string>(1, "Two");
            Console.WriteLine($"{pairParam.X}, {pairParam.Y}");

            Console.WriteLine(new string('-',20));

            Point a = new Point(10, 20);
            Point b = new Point3D(10, 20, 30);

            Console.WriteLine($"{a.X}, {a.Y}");
            Console.WriteLine($"{b.X}, {b.Y}, {((Point3D)b).Z}");

            Console.WriteLine(new string('-',20));

            PointStruct pointStruct1 = new PointStruct(10.5, 20.5);
            PointStruct pointStruct2 = new PointStruct();
            Console.WriteLine($"{pointStruct1.X}, {pointStruct1.Y}");
            Console.WriteLine($"{pointStruct2.X}, {pointStruct2.Y}");

            Console.WriteLine(new string('-',20));

            EditBox editBox1 = new EditBox();
            IControl control = editBox1;
            IDataBound dataBound = editBox1;


            var turnip = SomeRootVegetable.Turnip;
            var spring = Seasons.Spring;
            var startingOnEqunox = Seasons.Spring | Seasons.Autumn;
            var theYear = Seasons.All;
            Console.WriteLine($"{turnip}");
            Console.WriteLine($"{spring}");
            Console.WriteLine($"{startingOnEqunox}");
            Console.WriteLine($"{theYear}");

            Console.WriteLine(new string('-',20));

            int? optionalInt = default;
            Console.WriteLine(optionalInt);
            optionalInt = 5;
            Console.WriteLine(optionalInt);

            //string? optionalString = default;
            //optionalString = "Hellow World";

            Console.WriteLine(new string('-',20));

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"{t2.Sum}, {t2.Count}");
            Console.ReadKey();
        }
    }
}
