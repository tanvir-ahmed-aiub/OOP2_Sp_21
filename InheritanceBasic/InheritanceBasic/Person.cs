using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string fathersName;

        public string FathersName
        {
            get { return fathersName; }
            set { fathersName = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public Person() {
            Console.WriteLine("Person Default");
        }
        public Person(string name) {
            this.name = name;
            Console.WriteLine("Person 1 parameter constructor");
        }
        public Person(string name, string fathersName, string dob) {
            this.name = name;
            this.fathersName = fathersName;
            this.dob = dob;
            Console.WriteLine("Person 3 parameter constructor");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Father's Name: " + fathersName);
            Console.WriteLine("Dob : " + dob);
        }
    }
}
