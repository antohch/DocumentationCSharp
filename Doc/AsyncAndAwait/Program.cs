using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        static async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/");

            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished dlownloading.");

            File.WriteAllBytes("sit.html", content);

            return content.Length;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var i = RetrieveDocsHomePage();
            while(true)
            {
                Console.WriteLine("true"+ rnd.Next(0, 100));
            }

            Console.WriteLine(i.Result);

            Console.Read();
        }
    }
}
