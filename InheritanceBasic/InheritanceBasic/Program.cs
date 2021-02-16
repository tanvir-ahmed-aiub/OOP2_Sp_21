using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir Ahmed", "Nazim Uddin", "10-01-2021");
            s1.ShowInfo();
            Teacher t1 = new Teacher("Tanvir Ahmed", "Nazim Uddin", "10-01-2021", 10000);
            t1.ShowInfo();
        }
    }
}
