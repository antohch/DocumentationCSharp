using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
    public class Widget
    {
        [Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features",
        Topic = "Display")]
        public void Display(string text) { }
    }
    [Help("My example 3")]
    public class WidgetCustom
    {
        
        public void ShowDoSomething()
        {
            Console.WriteLine("DoSomething");
        }
        
        public void ShowDoSomething2()
        {
            Console.WriteLine("DoSomething");
        }
    }
}
