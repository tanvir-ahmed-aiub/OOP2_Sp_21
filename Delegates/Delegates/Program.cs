using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Calc(int a, int b);

        public  static void Add(int a, int b) {
            Console.WriteLine("Sum is" +(a + b));
        }
        public static void Sub(int a, int b) {
            Console.WriteLine("Sub is" + (a - b));
        }
        public static void Multiply(int a, int b) {
            Console.WriteLine("Multiply " + (a * b));
        }
        static void Main(string[] args)
        {
            int a = 12, b = 23;
            //Add(a, b);

            Calc calculator = Add; //defining the delegate
            //calculator(a,b);

            calculator += Sub;
            calculator += Multiply;
            //calculator(a, b);
            calculator(a, b);
            Console.WriteLine("***********");
            calculator(12, 10);
            Console.WriteLine("***********");
            calculator -= Multiply;
            calculator(45, 15);

            Person p = new Person();

            calculator += p.Age;
            Console.WriteLine("***********");
            calculator(45,12);





        }
    }
}
