using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            List<int> query = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0 && i == 0)
                {
                    Forward(ref query, array[i], i);
                }
                if(i % 2 == 0 && i != array.Length - 1)
                {
                    Down(ref query, array[i], i);
                }
                if (i % 2 == 0 && i == array.Length - 1)
                {
                    Rev(ref query, array[i], i);
                }
            }

            return query.ToArray();
        }
        private static void Down(ref List<int> q, int[] array, int delta)
        {
            q.Add(array[array.Length-1]);
            
        }
        private static void Forward(ref List<int> q, int[] array, int delta)
        {
            for (int i = 0; i < array.Length; i++)
            {
                q.Add(array[i]);
            }
        }
        private static void Rev(ref List<int> q, int[] array, int delta)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                q.Add(array[i]);
            }
        }
    }
}
