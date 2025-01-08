using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Interface_Example1
{
    internal class TypeA : IType
    {
        public int MyProperty {  get; set; } //automatic property in class/struct but called signature property in interface
        public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }

    }
}
