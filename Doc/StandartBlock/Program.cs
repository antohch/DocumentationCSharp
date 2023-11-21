using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    internal class Program
    {
        static int s_changeCount;
        static void ListChange(object sender, EventArgs e)
        {
            s_changeCount++;
        }
        static void DoWhanChanged(object sender, EventArgs e) 
        {
            Console.WriteLine("DoChange");
        }

        static void Main(string[] args)
        {
            int[] i = new int[]{ 0, 1, 2, 3 };
            Color c = new Color(255, 0, 0);
            Color c2 = Color.Black;
            Console.WriteLine(c.R);
            Console.WriteLine(Color.Green.G);
            Console.WriteLine($"{c2.R} {c2.G} {c2.B}");
            Console.WriteLine(c.ToString());

            Color.SwapExample();

            Color.OutUsage();

            Color.WriteLine(i);
            Color.WriteLine(4, 5, 6, 7);

            Entity.SetNextSeralNo(1000);
            Entity e1 = new Entity();
            Entity e2 = new Entity();
            Console.WriteLine(e1.GetSerialNo());
            Console.WriteLine(e2.GetSerialNo());
            Console.WriteLine(Entity.GetNextSerialNo());

            Console.WriteLine(new string('-',20));

            Expression e3 = new Operation(new VariableReference("x"), '+', new Constant(3));
            
            Expression e4 = new Operation(new VariableReference("x"), '*', 
                new Operation(new VariableReference("y"), '+', new Constant(2)));
            
            Dictionary<string, object> vars = new Dictionary<string, object>();
            vars["x"] = 3;
            vars["y"] = 5;
            Console.WriteLine(e4.Evaluatie(vars));
            vars["x"] = 1.5;
            vars["y"] = 9;
            Console.WriteLine(e4.Evaluatie(vars));

            Console.WriteLine(new string('-',20));

            OverloadingExamle.UsageExample();
            
            Console.WriteLine(new string('-',20));
            
            MyList<string> myList1 = new MyList<string>();
            MyList<string> myList2 = new MyList<string>();
            myList1.Changed += DoWhanChanged;
            myList1.Changed += (object obj, EventArgs e) => Console.WriteLine("DoWhanChanged2");
            myList1.add("a");
            myList1.add("b");
            Console.WriteLine($"{myList1[0]}, {myList1[1]}");
            Console.WriteLine(myList1.Equals(myList1));
            Console.WriteLine(myList1.Equals(myList2));
            Console.WriteLine(myList1 == myList2);

            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>(10);

            MyList<string> names = new MyList<string>();
            names.Changed += new EventHandler(ListChange);
            names.Capacity = 100;
            int iNames = names.Count;
            int jNames = names.Capacity;
            Console.WriteLine($"{iNames} {jNames}");
            names.add("Liz");
            names.add("Tom");
            names.add("Antony");
            names.add("Jon");
            for(int j = 0; j < names.Count; j++)
            {
                string s = names[j];
                names[j] = s.ToUpper();
                Console.WriteLine($"{j}. {names[j]}");
            }
            Console.WriteLine(s_changeCount);


            Console.ReadKey();

        }

    }
}
