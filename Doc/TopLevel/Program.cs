using System.Text;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
StringBuilder sb = new();
sb.AppendLine("Hellow ");
sb.AppendLine("World");
Console.WriteLine(sb.ToString());
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();
if (args.Length > 0)
{
    foreach(var arg in args)
    {
        Console.WriteLine(arg);
    }
}
else
{
    Console.WriteLine("no");
}

Console.WriteLine("Hello");
await Task.Delay(1000);
Console.WriteLine(" World!!");



public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("HW");
    }
}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("HWNamespace");
        }
    }
}