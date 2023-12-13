namespace ConsoleBaseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();

            BaseClass A = (BaseClass)B;
            A.DoWork();

            B b = new B();
            b.DoWork();
            C c = new C();
            c.DoWork();
            D d = new D();
            d.DoWork();

            Derived di = new Derived();
            di.DoWork();
        }
    }
}