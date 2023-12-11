using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type widgetCustom = typeof(WidgetCustom);
            Type widgetType = typeof(Widget);

            object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);
            if (widgetClassAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
                Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");

            }

            object[] widgetClassAttributes2 = widgetCustom.GetCustomAttributes(typeof(HelpAttribute), false);
            if (widgetClassAttributes2.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)widgetClassAttributes2[0];
                Console.WriteLine($"WidgetCustom class help URL : {attr.Url} - Related topic : {attr.Topic}");

            }

            System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));
            object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);
            if (displayMethodAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
                Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
            }

            Console.ReadKey();
        }
    }
}
