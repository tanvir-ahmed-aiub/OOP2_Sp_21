using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int,string> s = new Stack<int,string>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            s.Pop();
            s.Pop();
            Console.WriteLine(s.Top());
            s.ShowStack();
            Stack<string> s2 = new Stack<string>();
            s2.Push("tanvir");
            s2.Push("sabbir");
            s2.Push("rahim");
            s2.Push("karim");

        }
    }
}
