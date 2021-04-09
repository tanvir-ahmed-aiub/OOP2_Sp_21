using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        string size;
        public string Name { get; set; }
        public string Age { get; set;}
        abstract public void Eat();
        abstract public void Sleep();
        abstract public void Walk();
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
        }
    }
}
