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
    public class WeightSort
    {

        public static string orderWeight(string strng)
        {
            // your code
            string[] weight = strng.Split(' ');
            int[] ints = new int[weight.Length];
            for (int i = 0; i < weight.Length; i++)
            {
                ints[i] = Int32.Parse(weight[i]);
            }
            Array.Reverse(ints);
            for (int i = 0; i < ints.Length; i++)
            {


                for (int j = i + 1; j < ints.Length; j++)
                {
                    int sum1 = 0;

                    string strItem = ints[i].ToString();
                    char[] chars = strItem.ToCharArray();
                    for (int k = 0; k < chars.Length; k++)
                    {
                        sum1 += Int32.Parse(chars[k].ToString());
                    }


                    int sum2 = 0;

                    strItem = ints[j].ToString();
                    chars = strItem.ToCharArray();
                    for (int k = 0; k < chars.Length; k++)
                    {
                        sum2 += Int32.Parse(chars[k].ToString());
                    }

                    if (sum1 > sum2)
                    {
                        int tmp = ints[i];
                        ints[i] = ints[j];
                        ints[j] = tmp;
                    }
                    else if (sum1 == sum2)
                    {
                        if (ints[i] > ints[j])
                        {
                            int tmp = ints[i];
                            ints[i] = ints[j];
                            ints[j] = tmp;
                        }
                    }

                }

            }
            for (int i = 0; i < ints.Length; i++)
            {
                weight[i] = ints[i].ToString();
            }
            return String.Join(' ', weight);
        }
    }
}

