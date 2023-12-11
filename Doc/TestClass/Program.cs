using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    internal class Class1
    {
        static int Main(string[] args)
        {
            Console.WriteLine(args.Length);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello");
            sb.AppendLine("World");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            return 0;
        }
    }
}
