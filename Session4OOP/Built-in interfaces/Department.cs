using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4OOP.Built_in_interfaces
{
    internal class Department : ICloneable
    {
        public int Code { get; set; }
        public string? Title { get; set; }

        public object Clone()
        {
            return new Department()
            {
                Code = this.Code,
                Title = this.Title
            };
        }
        public override string ToString()
        {
            return $"Department Code: {Code}, Title: {Title}";
        }
    }

}
