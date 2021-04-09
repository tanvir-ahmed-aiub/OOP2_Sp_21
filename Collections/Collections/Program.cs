using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "Tanvir";
            p2.Name = "Sabbir";

            Course c1 = new Course();
            c1.Name = "cs";
            Course c2 = new Course();
            c2.Name = "eee";

            var temp = (Course)al[3];

            al.Add(p1);
            al.Add(p2);
            al.Add(c1);
            al.Add(c2);

            foreach (dynamic p in al) {
                Console.WriteLine(p.Name);
            }


            //boxing unboxing
            int a = 10;
            object obj = a; //boxing
            int b = (int)obj; //unboxing

            Person p4 = new Person();
            object obj2 = p4; //boxing
            Console.WriteLine(obj2.GetType());
            if(obj2 is Course)
            {
                var p5 = (Course)obj2;
            }
                

        }
    }
}
