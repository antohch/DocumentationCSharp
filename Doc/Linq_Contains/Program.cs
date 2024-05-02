namespace Linq_Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };
            string fruit = "mango";

            bool hasMango = fruits.Contains(fruit);
            Console.WriteLine("The array {0} contain '{1}'.", hasMango ? "does": "does not", fruit);

            Console.ReadKey();
        }
    }
}
