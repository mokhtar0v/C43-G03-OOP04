using Session4OOP.Interface_Example_02;
using Session4OOP.Interface_Example_03;
using Session4OOP.Interface_Example1;
using Session4OOP.Built_in_interfaces;

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

            #region Shallow Copy vs Deep Copy
            #region Shallow Copy
            int[] arr01 = [1, 2, 3];
            int[] arr02 = [4, 5, 6];
            Console.WriteLine($"{arr01.GetHashCode()}, {arr02.GetHashCode()}");
            arr02 = arr01; Console.WriteLine("After Shallow copy arr01->arr02");
            // this object [1,2,3] has now two references (arr01,arr02)
            //[4,5,6] has became unreachable object
            //this called shallow copy
            Console.WriteLine($"{arr01.GetHashCode()}, {arr02.GetHashCode()}");
            arr02[0] = 100;
            Console.WriteLine(arr01[0]);
            #endregion
            #region Deep Copy
            int[] arr03 = [1, 3, 5];
            int[] arr04 = [2, 4, 6];
            Console.WriteLine($"{arr01.GetHashCode()}, {arr02.GetHashCode()}");
            arr03 = (int[])arr04.Clone(); Console.WriteLine("Deep Copy arr03 -> (int[])arr04.Clone()");
            // deep copy
            //clone method will generate new object with new and different identity
            //this object will have same state (data) of the caller object
            Console.WriteLine($"{arr03.GetHashCode()}, {arr04.GetHashCode()}");
            arr04[0] = 100;
            Console.WriteLine(arr03[0]);

            #endregion
            #endregion

            #region Part 06
            string[] names01 = ["Ahmed", "Ali"];
            string[] names02 = ["Omar", "Abdo"];
            Console.WriteLine($"names01.GetHashCode(): {names01.GetHashCode()}, names02.GetHashCode(): {names02.GetHashCode()}");
            names02 = (string[])names01.Clone();
            Console.WriteLine($"names01.GetHashCode(): {names01.GetHashCode()}, names02.GetHashCode(): {names02.GetHashCode()}");
            #endregion

            #region Built-in interface IClonable
            Employee employee01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 8_000, department = new Department() { Code = 10101, Title = "Sales" } };
            Employee employee02 = new Employee() { Id = 20, Name = "Omar", Salary = 7_000, department = new Department() { Code = 20022, Title = "HR" } };

            Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");
            Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");

            employee02 = (Employee)employee01.Clone(); //deep copy using clone method
            employee02 = new Employee(employee01); // deep copy using constructor

            employee02.Salary = 2000;
            if (employee02.department is not null) 
                employee02.department.Title = "NEW"; 
            Console.WriteLine($"employee01.GetHashCode(): {employee01.GetHashCode()}");
            Console.WriteLine($"employee02.GetHashCode(): {employee02.GetHashCode()}");

            Console.WriteLine($"Employee01: {employee01}");
            Console.WriteLine($"Employee02: {employee02}");
            //Console.WriteLine(employee01.department?.Title); //sales
            #endregion

            #region Built-in interface ICompareable
            Employee[] employees =
            {
                new Employee() { Id = 1,Name = "Ahmed",Salary = 7_000 },
                new Employee() { Id = 2,Name = "Ali",Salary = 6_000 },
                new Employee() { Id = 3,Name = "Omar",Salary = 6_500 },
                new Employee() { Id = 4,Name = "Mohamed",Salary = 9_000 },

            };
            Array.Sort(employees, new IDComparer());
            foreach( Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion

            #region Built-in interface IComparer

            #endregion

        }
    }
}
