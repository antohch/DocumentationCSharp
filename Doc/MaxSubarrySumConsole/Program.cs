

namespace MaxSubarrySumConsole
{
    public class Program
    {
        public static int MaxSequence(int[] arr)
        {
            int size = arr.Length;
            int max_so_far = int.MinValue, max_ending_here = 0;

            for(int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }
            return max_so_far;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }


    }

}


