using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    public class Student
    {
        string name;
        string id;
        float cgpa;
       // readonly int credit = 148; //fixed
        readonly int credit; //fixed
        const string department = "CSE";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Cgpa
        { 
            get { return cgpa; }
        }
        public int Credit {
            get { return credit; }
            
        }



        public Student() {
            Console.WriteLine("Default Constructor");
            credit = 148;
        }
        public Student(string name, string id, float cgpa) {
            Console.WriteLine("Parameterized Constructor called");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            credit = 148;
        }
        internal void ShowDetails() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
        }
    }
}
