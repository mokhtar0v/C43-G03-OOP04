using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Interface_Example1
{
    internal interface IType
    {
        //public is the deafula access modifier inside the interface
        //private access modifier is not allowed for the signatures 

        //what u can write inside interface
        /// 1.signature for property
        public int MyProperty { get; set; }
        /// 2.signature for method
        public void MyMethod();
        ///  3.default implemented method
        public void print()
        {
            Console.WriteLine("Default implemented method");
        }
        /// 4.static members
        /// //4.1 static fields
        /// //4.2 static properties
        /// //4.3 static methods
        /// //4.4 static events

    }
}
