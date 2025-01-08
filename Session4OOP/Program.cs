using Session4OOP.Interface_Example1;

namespace Session4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IType reference;
            //declare for reference of type IType, contains garbage value
            //this reference can refer to an object of any type implementing IType interface
            //reference = new IType(); -> Invalid
            reference = new TypeA();
            reference.MyProperty = 10;
            reference.MyMethod();
            reference.print();
        }
    }
}
