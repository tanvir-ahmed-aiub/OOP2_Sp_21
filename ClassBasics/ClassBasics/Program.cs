using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBasics;

namespace ClassBasics2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Tanvir Ahmed", "1010110", 2.5F);
            s2.Name = "Sabbir";
            
            Console.WriteLine("Name is :" + s2.Name);
            Console.WriteLine("Cgpa is :" + s2.Cgpa);
            s2.ShowDetails();
        }
    }
}
