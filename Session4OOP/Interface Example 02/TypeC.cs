using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Interface_Example_02
{
    class TypeC : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

    }
}
