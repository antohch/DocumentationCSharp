namespace KataTwoSum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());
        }
    }
}
