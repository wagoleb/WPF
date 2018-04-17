using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class MySecondObject
    {
        public MySecondObject(Simulation simulation)
        {
            simulation.a += Print;
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg + "Second Object");
        }
    }
}
