using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBinarySearch
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id; Name = name;
        }

        public int CompareTo(Employee? other)
        {
            int comparison = 0;

            if(this.Name.CompareTo(other.Name) < 0)
            {
                comparison = -1;
            }
            else if(this.Name.CompareTo(other.Name) > 0)
            {
                comparison = 1;
            }
            else
            {
                comparison = 0;
            }
            return comparison;
        }
    }
}
