using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Chunk
{
    internal class Program
    {
        class NameList
        {
            public string[] FirstName;
            public string[] LastName;
        }
        static void Main(string[] args)
        {
            NameList nameList = new NameList();
            nameList.FirstName = new string[]{ "one", "two", "three", "five" };
            nameList.LastName = new string[]{ "LastNameone", "LastNametwo", "LastNamethree", "LastNamefive" };

            IEnumerable<string> query = nameList.FirstName.Concat(nameList.LastName.Select(x => x.ToString()));
        }
    }
}
