using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area { get { return Math.PI * Math.Pow(Radius, 2); } set { } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Radius = {Radius}, Area = {Area}");
        }
    }
}
