using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIEnumerator
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
    }

    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
}
