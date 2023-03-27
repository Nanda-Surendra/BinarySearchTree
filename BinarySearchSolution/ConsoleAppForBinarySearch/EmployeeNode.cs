using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBinarySearch
{
    public class EmployeeNode
    {
        public Employee Data { get; set; }
        public EmployeeNode? Left { get; set; }
        public EmployeeNode? Right { get; set; }
        public EmployeeNode(Employee data)
        {
            this.Data = data;
        }
    }
}
