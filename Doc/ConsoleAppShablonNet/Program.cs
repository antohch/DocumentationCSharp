namespace ConsoleAppShablonNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? message = "Message";
            if (message is null)
            {
                Console.WriteLine(message);
            }
            List<string> list = new List<string>();
            list.Add("Message");

            Console.WriteLine(MidPoint(list));
        }
        public static T MidPoint<T>(IEnumerable<T> sequence) 
        { 
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) 
                {
                    halfLength = 0;
                }
                return sequence.Skip(halfLength).First();
            }
        }
    }
}