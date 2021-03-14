using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science","CS");
            Department d2 = new Department("Electrical Engg.", "EEE");
            Student s1 = new Student("Tanvir Ahmed","s101",2.5f);
            Student s2 = new Student("Sabbir Ahmed", "s102", 2.6f);
            Student s3 = new Student("Rahim", "s103", 3.6f);

            d1.AddStudent(s1,s2,s3);
            
            s1.Department.ShowInfo();
            //d1.AddStudent(s2);
            d2.AddStudent(s3);

            d1.AllStudents();
            Console.WriteLine("****************");
            d2.AllStudents();
            /*s1.Department = d2;
            s1.ShowInfo();
            s1.Department = d1;
            s1.ShowInfo();
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s1.ShowInfo();*/

            //Console.WriteLine(s1.Department.Id);
        }
    }
}
