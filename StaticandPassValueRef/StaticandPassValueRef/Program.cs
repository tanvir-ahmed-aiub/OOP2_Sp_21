using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticandPassValueRef
{
    class Program
    {
        static void Swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;   
        }
        static void SwapString( string a,  string b) {
            string temp = a;
            a = b;
            b = temp;
        }
        static void OutExample(out int a) {
            a = 5050;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            Console.WriteLine("x = {0} and y ={1}", x, y); //x = 10 and y = 12
            Swap( ref x, ref y);
            Console.WriteLine("x = {0} and y ={1}", x, y); //x = 12 and y = 10

            int a;
            //Console.WriteLine(a);
            OutExample(out a);
            Console.WriteLine(a);
            /*Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.Name = "Tanvir";
            s2.Name = "Sabbir";
            s3.Name = "Karim";
            Console.WriteLine("Created Student: " + Student.count);*/

           
        }
    }
}
