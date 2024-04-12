using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUP
{
    public static class Utilities
    {
        public static async Task ShowConsoleAnimation(string[] animations)
        {
            for (int i = 0; i < 20; i++)
            {
                foreach (string s in animations)
                {
                    Console.Write(s);
                    await Task.Delay(50);
                    Console.Write("\b\b\b");
                }
            }
            Console.WriteLine();
        }
    }
}
