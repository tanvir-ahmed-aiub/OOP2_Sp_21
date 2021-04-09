using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Toyots : Car, IBasicCar
    {
        public void Accelerate()
        {
            Console.WriteLine("Toyota accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Toyota Braking");
        }

        public void Start()
        {
            Console.WriteLine("Toyota starting");
        }
    }
}
