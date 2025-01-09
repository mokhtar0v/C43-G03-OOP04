using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Built_in_interfaces
{
    class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? department { get; set; }

        public Employee() { }
        public Employee(Employee EmpCopy)
        {
            this.Id = EmpCopy.Id;
            this.Name = EmpCopy.Name;
            this.Salary = EmpCopy.Salary;
            this.department = (Department?) EmpCopy?.department?.Clone();
        }
        public object Clone()
        {
            return new Employee(this);
            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    //Name = (string?)this.Name?.Clone(),
            //    Salary = this.Salary,
            //    department = (Department?) this.department?.Clone()
            //};
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary:c}, Department: {department}";
        }

        public int CompareTo(object? obj)
        {
            Employee? other = (Employee?)obj; //Explicit and Unsafe casting
            // we can prevent this casting by inherit generic IComparable interface
            return this.Salary.CompareTo(other?.Salary);
            ////if (other is null) return 1;
            //if (this.Salary > other?.Salary || other is null) return 1;
            //else if (this.Salary < other?.Salary) return -1;
            //return 0;
        }
    }
}
