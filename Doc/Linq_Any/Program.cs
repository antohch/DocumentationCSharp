using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Any
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
    }
    class Person
    {
        public string LastName { get; set; }
        public Pet[] Pets { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2 };
            bool hasElements = numbers.Any();

            Console.WriteLine("The list {0} empty", hasElements ? "is not" : "is");


            List<Person> people = new List<Person>
                { new Person { LastName = "Haas",
                               Pets = new Pet[] { new Pet { Name="Barley", Age=10 },
                                                  new Pet { Name="Boots", Age=14 },
                                                  new Pet { Name="Whiskers", Age=6 }}},
                new Person { LastName = "Fakhouri",
                               Pets = new Pet[] { new Pet { Name = "Snowball", Age = 1}}},
                new Person { LastName = "Antebi",
                               Pets = new Pet[] { }},
                new Person { LastName = "Philips",
                               Pets = new Pet[] { new Pet { Name = "Sweetie", Age = 2},
                                                  new Pet { Name = "Rover", Age = 13}} }
                };

            IEnumerable<string> names = from person in people
                                        where person.Pets.Any()
                                        select person.LastName;
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Pet[] pets =
                { new Pet { Name="Barley", Age=8, Vaccinated=true },
                  new Pet { Name="Boots", Age=4, Vaccinated=false },
                  new Pet { Name="Whiskers", Age=1, Vaccinated=false } };

            bool unVaccinated = pets.Any(p => p.Age > 1 && p.Vaccinated);
            Console.WriteLine("Unvaccinated {0}",unVaccinated);

            IEnumerable<string> nameUnVPet = from pet in pets
                                  where pet.Age > 1 && !pet.Vaccinated
                                  select pet.Name;

            foreach(var nameP in nameUnVPet)
            {
                Console.WriteLine("{0} unvaccinated", nameP);
            }

            Console.ReadKey();
        }
    }
}
