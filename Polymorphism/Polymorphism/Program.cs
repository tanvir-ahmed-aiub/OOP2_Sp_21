using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir","545","31/12/1940",19,3.00f,154);
            s1.ShowInfo();

            Person p = new Person("Sabbir","454","21.12.2020",17);
            p.ShowInfo();
            Console.WriteLine("***********************");
            Person p2 = new Student("Karim", "546", "31/12/1940",20, 3.00f, 154);
            p2.ShowInfo();
            Console.WriteLine("***********************");
           

            Person p3 = new Student("Tanvir", "545", "31/12/1940", 19, 2.90f, 154);
            p3.VotingEligibility();

        }
    }
}
