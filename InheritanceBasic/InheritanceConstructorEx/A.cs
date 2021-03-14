using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorEx
{
    class A
    {
        public A():this(10,12) {
            Console.WriteLine("Default: A");
        }
        public A(int a)  {
            Console.WriteLine("1 Parameter: A");
        }
        public A(int a, int b):this(15){
            Console.WriteLine("2 Parameter: A");
        }
    }
}
