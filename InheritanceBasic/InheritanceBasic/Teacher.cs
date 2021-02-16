using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Teacher:Person
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Teacher() { }
        public Teacher(string name, string fathersName, string dob,double salary)
        {
            this.Name = name;
            this.FathersName = fathersName;
            this.Dob = dob;
        }
        
    }
}
