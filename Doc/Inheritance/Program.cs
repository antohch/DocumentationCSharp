using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    public class SimpleClass { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic |
                                 BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
            foreach (MemberInfo member in members )
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null )
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                string output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }

        }

    }
}
