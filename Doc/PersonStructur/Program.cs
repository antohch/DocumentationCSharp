using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStructur
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alex", 9);
            Console.WriteLine("person1 Name={0} and Age={1}", person1.Name, person1.Age);
            Person person2 = person1;
            person2.Name = "Toha";
            person2.Name = "Alex";
            person2.Age = 10;
            person2.Age = 9;
            Console.WriteLine("person2 Name={0} and Age={1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name={0} and Age={1}", person1.Name, person1.Age);
            if(person2.Equals(person1))
            {
                Console.WriteLine("Person1 equals person2");
            }
            Console.ReadKey();
        }
    }
}
