using System.Runtime.CompilerServices;

namespace QueryCityDataConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (city, pop, size) = QueryCityData("New York City");
            Example example = new Example();
            var (fname, lname) = example;
            string st = $"{fname} {lname}:";
            st.ExSt();
            Console.ReadLine();

        }
        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);
            return ("", 0, 0);
        }

    }
}