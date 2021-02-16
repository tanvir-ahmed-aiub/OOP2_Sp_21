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
        public Student() { }
        public Student(string name, string fathersName, string dob) {
            this.Name = name;
            this.FathersName = fathersName;
            this.Dob = dob;
        }
       



    }
}
