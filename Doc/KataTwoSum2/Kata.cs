using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
