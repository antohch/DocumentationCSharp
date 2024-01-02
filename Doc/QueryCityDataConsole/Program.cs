namespace QueryCityDataConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (city, pop, size) = QueryCityData("New York City");

        }
        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);
            return ("", 0, 0);
        }
    }
}