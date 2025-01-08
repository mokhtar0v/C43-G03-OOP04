using Session4OOP.Interface_Example_02;
using Session4OOP.Interface_Example_03;
using Session4OOP.Interface_Example1;

namespace Session4OOP
{
    internal class Program
    {
        static void PrintTenNumberFromSeries(ISeries series)
        {
            if (series is null) return;
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Interface Example 01
            IType reference;
            //declare for reference of type IType, contains garbage value
            //this reference can refer to an object of any type implementing IType interface
            //reference = new IType(); -> Invalid
            reference = new TypeA();
            reference.MyProperty = 10;
            reference.MyMethod();
            reference.print();
            #endregion

            #region Interface Example 02
            TypeB seriesByTwo = new TypeB();
            PrintTenNumberFromSeries(seriesByTwo);

            TypeC seriesByThree = new TypeC();
            PrintTenNumberFromSeries(seriesByThree);


            #endregion

            #region Interface Example 03
            Airplane airplane = new Airplane();

            IMovable movable = airplane;
            movable.Forward();

            IFlyable flyable = airplane;
            flyable.Forward();
            #endregion
        }
    }
}
