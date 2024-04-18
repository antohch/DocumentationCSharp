using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
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
            Pet[] pets = { new Pet { Name = "Barley", Age = 10 },
                           new Pet { Name = "Boots", Age = 1 },
                           new Pet { Name = "Whiskers", Age = 4} };

            bool allStartWithB = pets.All(pet => pet.Name.StartsWith("B"));

            Console.WriteLine("{0} start with B", allStartWithB ? "All": "Not all");
        
            List<Person> people = new List<Person> 
                { 
                    new Person { LastName = "Hass",
                                Pets = new Pet[] { new Pet { Name = "Barley", Age = 10},
                                                   new Pet { Name = "Boots", Age = 14},
                                                   new Pet { Name = "Whiskers", Age = 6} } },
                    new Person { LastName = "Fakhouri",
                                Pets = new Pet[] { new Pet { Name = "Snowball", Age = 1},
                                                   new Pet { Name = "Belle", Age = 8},
                                                   new Pet { Name = "Wooky", Age = 6} } },
                    new Person { LastName = "Philips",
                                Pets = new Pet[] { new Pet { Name = "Barny", Age = 6},
                                                   new Pet { Name = "Koot", Age = 11},
                                                   new Pet { Name = "Rover", Age = 13} } }
                };

            IEnumerable<string> names = from person in people
                                       where person.Pets.All(pet => pet.Age > 5)
                                       select person.LastName;

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }



            string namesWithPetOld = "";
            foreach (var person in people)
            {
                if (person.Pets.All(pet => pet.Age > 5))
                    namesWithPetOld +=  person.LastName + " ";
            }
            namesWithPetOld = namesWithPetOld.Trim();
            Console.WriteLine(namesWithPetOld);

            Console.Read();
        }
    }
}
