using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicReview
{
    class Program
    {
        enum Order {
            Ordered = 100,
            Received,
            Picked,
            Delivered
        }
        static void Swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
           
        }
        static int Add(params int[] a) {
            int sum=0;
            /*for (int i = 0; i < a.Length; i++) {
                sum += a[i];
            }*/
            foreach (int v in a) {
                sum += v;
            }
            return sum;
        }
       
        static void Main(string[] args)
        {
            int a =14;
            Console.WriteLine(a);
            Student s = new Student();
            s.Show();
            /*Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.name = "Tanvir";
            s1.id = "234324";
            s2.name = "sabbir";
            s2.id = "43535";*/
            /*int x = 10, y = 12;
            Console.WriteLine("x = {0} and y = {1}",x,y);
            Swap(ref x, ref y);
            Console.WriteLine("x = {0} and y = {1}", x, y);

            Add();
            Add(1, 2);
            Add(1);
            Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            int[] ar = { 1, 2, 3 };
            Add(ar);
            int status = (int)Order.Delivered;
            if (status == (int)Order.Delivered) {
                Console.WriteLine("OK");
            }*/



        }
    }
}
