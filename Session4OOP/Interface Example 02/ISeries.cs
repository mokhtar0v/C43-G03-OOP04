using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Interface_Example_02
{
    interface ISeries
    {
        int Current {  get; set; }
        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }
    }
}
