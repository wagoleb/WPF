using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Simulation
    {
        public int CurrentTime { get; set; }
        public void simulate()
        {
            while (this.CurrentTime < 10)
            {
                if ((this.CurrentTime % 2) == 0)
                {
                    Console.WriteLine(this.CurrentTime);
                    raiseCurrentTimeIsEven("Current time is even ! ");
                }
                System.Threading.Thread.Sleep(250);
                CurrentTime++;
            }
        }

        public Simulation()
        {
            this.CurrentTime = 0;
        }

        public void raiseCurrentTimeIsEven(string msg)
        {
            if (a != null)
            {
                a(msg);
            }

        }
        public delegate void OnEventThatCurrentTimeIsEven(string msg);

        // private OnEventThatCurrentTimeIsEven _listOfSubscribers;

        public event OnEventThatCurrentTimeIsEven a;
        /*
        {
            add { _listOfSubscribers += value; }
            remove { _listOfSubscribers -= value; }
        }
        */
    }
}
