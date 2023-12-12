namespace PersonObject
{
    public class Person
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
            Person person1 = new Person("Leopold", 6);
            Console.WriteLine("person1 Name={0} and Age={1}", person1.Name, person1.Age);

            Person person2 = person1;
            person2.Name = "Molly";
            person2.Age = 5;
            Console.WriteLine("person1 Name={0} and Age={1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name={0} and Age={1}", person1.Name, person1.Age);
        }
    }
}