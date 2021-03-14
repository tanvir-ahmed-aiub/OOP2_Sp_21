using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
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
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        Department department;
        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        Course[] courses;
        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }


        public Student() { }
        public Student(string name, string id, float cgpa) {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
            //department.ShowInfo();

        }
        public void AddCourse(params Course[] courses) {
            foreach (Course c in courses) {
                this.courses[courseCount++] = c;

            }
        }
        public void PrintAllCourses() {
            for (int i = 0; i < courseCount; i++) {
                courses[i].ShowInfo();
            }
        }



    }
}
