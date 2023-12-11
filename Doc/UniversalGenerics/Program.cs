namespace UniversalGenerics
{
    internal class Program
    {
        static IEnumerable<int> ProduceEvent(int upto)
        {
            for (int i = 0; i < upto; i++)
            {
                yield return i; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GenericList<string> list = new GenericList<string>();
            list.AddHead("A");
            list.AddHead("B");
            list.AddHead("C");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Class1 classList = new Class1();
            classList.Add("a");
            classList.Add("b");
            classList.Add("c");
            foreach (var item in classList)
            {
                Console.WriteLine(item);
            }
            foreach(var i in ProduceEvent(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}