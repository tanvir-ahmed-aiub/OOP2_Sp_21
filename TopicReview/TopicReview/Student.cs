using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicReview
{
    class Student
    {
        public string name;
        public string id;
        //Department dept;
        public static int maxCredit;
        string[] emails;
        public readonly int credit = 148;
        public const int dummy = 35435;
        //Course[] courses;
        public Student() {
            credit = 148;
        }
        public Student(int a, int b) { }
        public void Show()
        {
            Console.WriteLine(maxCredit);
        }

    }
}
