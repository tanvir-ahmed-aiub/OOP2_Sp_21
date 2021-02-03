using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Sample
    {
        //fields
        public int x; 
        public int y;

        internal void ShowDetails() {
            Console.WriteLine("X = {0}\nY = {1}",x,y);
        }
    }
}
