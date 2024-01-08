using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryCityDataConsole
{
    static class ExtraString
    {
        private static int i = 1, y = 0;
        public static void ExSt(this string s)
        {
            Console.WriteLine("{0} Extra = {1}, {2}", s, i, y);
        }
    }
}
