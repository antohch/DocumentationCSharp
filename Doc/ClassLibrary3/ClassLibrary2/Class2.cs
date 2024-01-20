using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class2
    {
        public int c;
        public void AddValues(int a, int b)
        {
            c = a + b;
        }
        public static int GenerateRandom(int min, int max)
        {
            System.Random rand = new System.Random();
            return rand.Next(min, max);
        }
    }
}
