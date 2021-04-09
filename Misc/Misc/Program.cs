using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
           
            Console.WriteLine("The value is {0}", i.GetValueOrDefault());

            int age = 15;
            string vote = "";
            vote = age > 18 ? "Can cast vote" : "Can not cast vote";
            
            Console.WriteLine(vote);

            //Nullable<int> a;
            int? a;
            Object db = null;
            a = db == null ? 0 : (int)db;
            int j = a ?? 0;

            string k = "";
            string f = null;

            k = f ?? "empty";
            Console.WriteLine("Value of K: " + k);


            

            dynamic ab = "this is string";
            var aa = 10;




        }
    }
}
