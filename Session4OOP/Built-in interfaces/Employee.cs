using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Built_in_interfaces
{
    class Employee : ICloneable
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
    }
}
