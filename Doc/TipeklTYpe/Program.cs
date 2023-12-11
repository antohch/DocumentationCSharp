using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipeklTYpe
{
    internal class Program
    {
        private static string[] name = { "Spencer", "Sally", "Doug" };

        public static string GetName(int ID)
        {
            if (ID < name.Length)
            {
                return name[ID];
            }
            else
            {
                return String.Empty;
            }
        }
        static void Main(string[] args)
        {
            float temperature;
            string name;
            MyClass myClass;
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GetName(1));

            Coords coords = new Coords(1, 10);
            Console.WriteLine($"{coords.x} - {coords.y}");

            var fileMode = new FileMode();
            fileMode = FileMode.Open;

            Console.WriteLine(((int)fileMode) == 3 ? "Op":"no");

            string s = "The answer is " + 5.ToString();
            Console.WriteLine(s);

            Type type = 12345.GetType();
            Console.WriteLine(type);

            List<string> stringList = new List<string>();
            stringList.Add("String example");

            string message = "This is a string of characters";
            object anotherMessage = "This is another string of characters";
            IEnumerable<char> someCharacters = "abcdefghijklmnopqrstuvwxyz";

            Console.ReadKey();
        }
    }
}
