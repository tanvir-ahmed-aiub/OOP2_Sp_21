using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string EngineNo { get; set; }

        public void ShowInfo() {
            Console.WriteLine("Name: " + Name );
            Console.WriteLine("Model: " + Model );
            Console.WriteLine("Engine No: " + EngineNo );
        }
    }
}
