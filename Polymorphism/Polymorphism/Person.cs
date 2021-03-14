﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get;  set; }
        public string Dob { get;  set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, string id, string dob,int age) {
            Name = name;
            Id = id;
            Dob = dob;
            Age = age;
        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Dob: " + Dob);
        }
        virtual public void VotingEligibility() {
            if (Age >= 18)
            {
                Console.WriteLine("Person can cast vote.");
            }
            else {
                Console.WriteLine("Person can not cast vote as your age is < 18");
            }
        }


    }
}
