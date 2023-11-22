using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] a = new int[10];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = i * i;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }

                int[] a1 = new int[10];
                int[,] a2 = new int[10, 5];
                int[,,] a3 = new int[10, 5, 2];

                int[][] b = new int[3][];
                b[0] = new int[10];
                b[1] = new int[5];
                b[2] = new int[20];

                int[] c = new int[] { 1, 2, 3 };
                foreach (int item in c)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
