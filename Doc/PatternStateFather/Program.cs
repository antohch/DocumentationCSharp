﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Father father = new Father();


            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("");
                Console.Write("Сын принес: ");

                Mark mark = (Console.ReadKey().KeyChar.ToString() == "5") ? mark = Mark.Five : mark = Mark.Two;

                Console.WriteLine("");

                father.FindOut(mark);
            }
        }
    }
}
