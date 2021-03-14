using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Student:Person
    {
        
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private int creditCpl;
        public int CreditCpl
        {
            get { return creditCpl; }
            set { creditCpl = value; }
        }
        public Student() : base("","","") {
            Console.WriteLine("Student Default");
        }
        public Student(string name) : base(name){
            Console.WriteLine("Student 1 parameter");
        }
        public Student(string name, string fatherName, string dob) : base() {
            Console.WriteLine("Student 3 parameter constructor");
        }
        public Student(string name, string fathersName, string dob,float cgpa) {
            this.Name = name;
            this.FathersName = fathersName;
            this.Dob = dob;
        }
    }
}
