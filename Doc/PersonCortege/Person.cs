﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCortege
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }  
        public Person(string fname, string mname, string lname, string cityName, string stateName)
        {
            FirstName = fname;
            LastName = lname;
            MiddleName = mname;
            City = cityName;
            State = stateName;
        }
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName; 
            lname = LastName;
        }
        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }
        public void Deconstruct(out string fname, out string lname, out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
}
