using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KataTwoSum2
{
    public class Kata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (target == numbers[i] + numbers[j])
                        return new int[] { i, j };
                }
            }

            return new int[0];
        }
    }



    public class WeightSort
    {
        public static string orderWeight(string s)
        {
            return string.Join(" ", s.Split(' ')
                .OrderBy(n => n.ToCharArray()
                .Select(c => (int)char.GetNumericValue(c)).Sum())
                .ThenBy(n => n));
        }
    }

}


