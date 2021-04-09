using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Human : Animal
    {
        public void Earning() {
            Console.WriteLine("Can do business or service");
        }

        public override void Eat()
        {
            Console.WriteLine("Humans eat with both hands");
        }

        public override void Sleep()
        {
            Console.WriteLine("Humans sleep by lying");
        }

        public override void Walk()
        {
            Console.WriteLine("Humans walk with 2 legs");
        }
    }
}
