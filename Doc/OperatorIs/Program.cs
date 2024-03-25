namespace OperatorIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g = new Giraffe();
            var a = new Animal();

            FeedMammals(g);
            FeedMammals(a);

            SuperNova sn = new SuperNova();
            TestForMammal(g);
            TestForMammal(sn);

            Console.WriteLine(new string('-',30));

            int i = 5;
            PatternMatchingNullable(i);

            int? j = null;
            PatternMatchingNullable(j);

            double d = 9.72454;
            PatternMatchingNullable(d);

            PatterMatchingSwitch(i);
            PatterMatchingSwitch(j);
            PatterMatchingSwitch(d);

            Giraffe gr = new();
            UseIsOperator(gr);

            UseAsOperator(gr);

            UsePatternMatchingIs(gr);

            SuperNova sn1 = new();
            UseAsOperator(sn1);

            int i1 = 5;
            UseAsWithNullable(i1);

            double d1 = 9.7856;
            UseAsWithNullable(d1);
        }
        
        static void UseIsOperator(Animal a)
        {
            if (a is Mammal)
            {
                Mammal m = (Mammal)a;
                m.Eat();
            }
        }
        static void UsePatternMatchingIs(Animal a)
        {
            if (a is Mammal m)
            {
                m.Eat();
            }
        }
        static void UseAsOperator(object o)
        {
            Mammal? m = o as Mammal;
            if (m is not null)
            {
                Console.WriteLine(m.ToString());
            }
            else
            {
                Console.WriteLine($"{o.GetType()} is not a Mammal");
            }
        }
        static void UseAsWithNullable(System.ValueType val)
        {
            int? j = val as int?;
            if (j is not null)
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine("Could not conver " +val.ToString());
            }
        }

        static void PatternMatchingNullable(ValueType? val)
        {
            if (val is int j)
            {
                Console.WriteLine(j);
            }
            else if (val is null)
            {
                Console.WriteLine("val is a nullable type with the null value");
            }
            else
            {
                Console.WriteLine("Could not convert " + val.ToString());
            }
        }

        static void PatterMatchingSwitch(ValueType? val)
        {
            switch (val)
            {
                case int number:
                    Console.WriteLine(number);
                    break;
                case long number:
                    Console.WriteLine(number);
                    break;
                case float number:
                    Console.WriteLine(number);
                    break;
                case double number:
                    Console.WriteLine(number);
                    break;
                case null:
                    Console.WriteLine("val is a nullable type with the null value");
                    break;
            }
        }

        static void FeedMammals(Animal a)
        {
            if (a is Mammal m)
            {
                m.Eat();
            }
            else
            {
                Console.WriteLine($"{a.GetType().Name} is not a Mammal");
            }
        }
        static void TestForMammal(object o)
        {
            var m = o as Mammal;
            if (m != null)
            {
                Console.WriteLine(m.ToString());
            }
            else
            {
                Console.WriteLine($"{o.GetType().Name} is not a Mammal");
            }
        }
    }
    class Animal
    {
        public void Eat() { Console.WriteLine("Eating."); }
        public override string ToString()
        {
            return "I am a animal.";
        }
    }
    class Mammal : Animal { }
    class Giraffe : Mammal { }
    class SuperNova { }
}
