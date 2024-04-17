namespace IndexConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = [
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumps",    // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            ];              // 9 (or words.Length) ^0
            Console.WriteLine(words[^1]);
            string[] quickBrownFox = words[1..4];
            foreach(var word in quickBrownFox)
            {
                Console.WriteLine($"< {word} >");
            }
            string[] lazyDog = words[^2..^0];
            foreach(var word in lazyDog)
            {
                Console.WriteLine(word);
            }

            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            string[] lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            foreach (var word in allWords)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in firstPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in lastPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Index the = ^3;
            Console.WriteLine(words[the]);
            Range phrase = 1..4;
            string[] text = words[phrase];
            foreach(var word in text)
            {
                Console.WriteLine(word);
            }

            int[] numbers = [.. Enumerable.Range(0, 100)];
            int x = 12;
            int y = 25;
            int z = 36;

            Console.WriteLine($"{numbers[^x]} is the same as {numbers[numbers.Length - x]}");
            Console.WriteLine($"{numbers[x..y].Length} is the same as {y - x}");

            Console.WriteLine("numbers[x..y] and numbers[y..z] are consecutive and disjoint:");
            Span<int> x_y = numbers[x..y];
            Span<int> y_z = numbers[y..z];
            Console.WriteLine($"\tnumbers[x..y] is {x_y[0]} through {x_y[^1]}, numbers[y..z] is {y_z[0]} through {y_z[^1]}");

            Console.WriteLine("numbers[x..^x] removes x elements at each end:");
            Span<int> x_x = numbers[x..^x];
            x_x[0] = 1212121212;
            int[] arr = numbers[0..^0];
            arr[x] = 1212323;
            Console.WriteLine($"\tnumbers[x..^x] starts with {x_x[0]} and ends with {x_x[^1]}");
            Console.WriteLine(numbers[12]);

            Console.WriteLine("numbers[..x] means numbers[0..x] and numbers[x..] means numbers[x..^0]");
            Span<int> start_x = numbers[..x];
            Span<int> zero_x = numbers[0..x];
            Console.WriteLine($"\t{start_x[0]}..{start_x[^1]} is the same as {zero_x[0]}..{zero_x[^1]}");
            Span<int> z_end = numbers[z..];
            Span<int> z_zero = numbers[z..^0];
            Console.WriteLine($"\t{z_end[0]}..{z_end[^1]} is the same as {z_zero[0]}..{z_zero[^1]}");

            Range implicitRange = 3..^5;

            Range explicitRange = new(
              new Index(3, false),
              new Index( 5, true));
            if (implicitRange.Equals(explicitRange))
            {
                Console.WriteLine($"{implicitRange} - {explicitRange}");
            }

            int[][] jagged =
[
   [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
   [10,11,12,13,14,15,16,17,18,19],
   [20,21,22,23,24,25,26,27,28,29],
   [30,31,32,33,34,35,36,37,38,39],
   [40,41,42,43,44,45,46,47,48,49],
   [50,51,52,53,54,55,56,57,58,59],
   [60,61,62,63,64,65,66,67,68,69],
   [70,71,72,73,74,75,76,77,78,79],
   [80,81,82,83,84,85,86,87,88,89],
   [90,91,92,93,94,95,96,97,98,99],
];

            var selectedRows = jagged[3..^3];

            foreach (var row in selectedRows)
            {
                var selectedColumns = row[2..^2];
                foreach (var cell in selectedColumns)
                {
                    Console.Write($"{cell}, ");
                }
                Console.WriteLine();
            }



            int[] sequence = Sequence(1000);

            for (int start = 0; start < sequence.Length; start += 100)
            {
                Range r = start..(start + 10);
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start} to {r.End}:    \tMin: {min},\tMax: {max},\tAverage: {average}");
            }

            for (int start = 0; start < sequence.Length; start += 100)
            {
                Range r = ^(start + 10)..^start;
                var (min, max, average) = MovingAverage(sequence, r);
                Console.WriteLine($"From {r.Start} to {r.End}:  \tMin: {min},\tMax: {max},\tAverage: {average}");
            }

            (int min, int max, double average) MovingAverage(int[] subSequence, Range range) =>
                (
                    subSequence[range].Min(),
                    subSequence[range].Max(),
                    subSequence[range].Average()
                );

            int[] Sequence(int count) => [.. Enumerable.Range(0, count).Select(x => (int)(Math.Sqrt(x) * 100))];






            string[] fruits = { "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };

            var query =
                fruits.Select((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });
            IEnumerable<string> queryFruits = fruits.Select((fruit, index) => fruit + " - " + index);

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }

            /*
             This code produces the following output:

             { index = 0, str =  }
             { index = 1, str = b }
             { index = 2, str = ma }
             { index = 3, str = ora }
             { index = 4, str = pass }
             { index = 5, str = grape }
            */

            var squares = Enumerable.Range(1, 10).Select(x => x * x);
            foreach(int num in squares)
            {
                Console.WriteLine(num);
            }

            var arrayOfFiveItem = new[] { 1, 2, 3, 4, 5 };
            var firstThreeITems = arrayOfFiveItem[..3];
            firstThreeITems[0] = 11;
            Console.WriteLine(string.Join(',', arrayOfFiveItem));
            Console.WriteLine(string.Join(',', arrayOfFiveItem));

        }
    }
}
