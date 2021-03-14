using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student : Person
    {
        public float Cgpa { get;  set; }
        public int Credit { get; set; }


        public Student() { }
        public Student(string name, string id, string dob,int age,float cgpa, int credit) :base(name,id,dob,age) {
            Cgpa = cgpa;
            Credit = credit;
        }
        new public void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine("Cgpa: " + Cgpa);
            Console.WriteLine("Credit: " + Credit);
        }
        public void Demo() { }
        override public void VotingEligibility()
        {
            if (Age >= 18 && Cgpa > 3.00)
            {
                Console.WriteLine("Student can cast vote.");
            }
            else {
                Console.WriteLine("Student can not cast vote as your cgpa is < 3.00");
            }
        }

    }
}
