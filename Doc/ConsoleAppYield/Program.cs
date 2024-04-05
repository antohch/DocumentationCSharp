namespace ConsoleAppYield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAwait();
        }
        static async void RunAwait()
        {
            await foreach (int n in GenerateNumbersAsync(5))
            {
                Console.Write(n);
                Console.Write(" ");
            }
        }
        static async IAsyncEnumerable<int> GenerateNumbersAsync(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return await ProduceNumberAsync(i);
            }
        }

        static async Task<int> ProduceNumberAsync(int seed)
        {
            await Task.Delay(1000);
            return 2 * seed;
        }

    }
}
