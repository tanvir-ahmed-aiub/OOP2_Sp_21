﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticandPassValueRef
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public static int count;
        public Student() {
            count++;
        }

    }
}
