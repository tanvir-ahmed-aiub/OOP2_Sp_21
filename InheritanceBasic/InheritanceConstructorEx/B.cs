using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorEx
{
    class B : A
    {
        public B():this("")
        {
            Console.WriteLine("Default: B");
        }
        public B(string a) : base() {
            Console.WriteLine("1 parameter: B");
        }
    }
}
