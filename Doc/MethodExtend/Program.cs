using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type dateType = typeof(DateTime);
            PropertyInfo prop = dateType.GetProperty("Now");
            var (isStatic, isRo, isIndexed, propType) = prop;
            Console.WriteLine($"\nThe {dateType.FullName}.{prop.Name} properyt:");
            Console.WriteLine($"PropertyType: {propType.Name}");
            Console.WriteLine($"Static: {isStatic}");
            Console.WriteLine($"Read-only: {isRo}");
            Console.WriteLine($"Indexed: {isIndexed}");
            
            Type listType = typeof(List<>);
            prop = listType.GetProperty("Item",
                                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var ( hasGetAndSet,  sameAccess,  accessibility,  getAccessibility,  setAccessibility) = prop;
            Console.Write($"\nAccessibility of the {listType.FullName}.{prop.Name} property: ");

            if (!hasGetAndSet | sameAccess)
            {
                Console.WriteLine(accessibility);
            }
            else
            {
                Console.WriteLine($"\n   The get accessor: {getAccessibility}");
                Console.WriteLine($"   The set accessor: {setAccessibility}");
            }


            Dictionary<string, int> snapshotCommitMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                ["https://github.com/dotnet/docs"] = 16_465,
                ["https://github.com/dotnet/runtime"] = 114_223,
                ["https://github.com/dotnet/installer"] = 22_436,
                ["https://github.com/dotnet/roslyn"] = 79_484,
                ["https://github.com/dotnet/aspnetcore"] = 48_386
            };
            foreach(var (repo, val) in snapshotCommitMap)
            {
                Console.WriteLine($"The {repo} repository had {val:N0} commits as of November 10th, 2021.");
            }

            DateTime? questionableDateTime = null;
            var (hasValue, value) = questionableDateTime;
            Console.WriteLine($"{{HasValue = {hasValue}, value = {value}}}");

            questionableDateTime = DateTime.Now;
            (hasValue, value) = questionableDateTime;
            Console.WriteLine($"{{HasValue = {hasValue}, value = {value}}}");
            Console.ReadKey();
        }
    }
}
