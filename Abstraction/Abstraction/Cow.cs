using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cow eats by mouth");
        }

        public override void Sleep()
        {
            Console.WriteLine("Cow sleep by lying");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow walk on 4 legs");
        }
    }
}
