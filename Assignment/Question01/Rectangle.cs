using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question01
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get { return Width * Height; } set { } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Width = {Width}, Height = {Height} and Area = {Area}");
        }
    }
}
