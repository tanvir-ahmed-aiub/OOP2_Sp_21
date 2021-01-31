using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            bool hasVal = true;
            Console.WriteLine(a );
            Console.WriteLine(hasVal);
            Console.WriteLine("The value of a is: " + a);
            Console.WriteLine("The value of a is {0} and hasval is {1}",a,hasVal);*/
            byte a = 8; //a cup of tea
            int b = a; //an empty kettlee

            int c = 8; //a kettlee containing a cup of tea
            byte d = (byte)c; //an empty cup

            double f = 8.5;
            float g = 8.4f;
            Console.WriteLine("f = {0} and g={1}", f, g);

            int num1 = 10;
            int num2 = 15;

            Console.WriteLine("Addition is :"+ (num1 + num2));
            Console.WriteLine("Subtraction is : {0}", (num1 - num2));
            Console.WriteLine("Division is :" + (num1 / num2));
            Console.WriteLine("Multiplication is : {0}", (num1 * num2));



        }
    }
}
