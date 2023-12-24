namespace PersonCortege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("John", "Quincy", "Admas", "Boston", "MA");
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}");
        }
    }
}