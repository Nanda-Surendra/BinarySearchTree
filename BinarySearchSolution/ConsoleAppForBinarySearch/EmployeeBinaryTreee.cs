using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBinarySearch
{
    public class EmployeeBinaryTreee
    {
        public static void InsertNode(EmployeeNode root, Employee value)
        {
            if (value.CompareTo(root.Data) == -1)
            {
                if (root.Left == null)
                {
                    root.Left = new EmployeeNode(value);
                }
                else
                {
                    InsertNode(root.Left, value);
                }
            }
            else if (value.CompareTo(root.Data) == 1)
            {
                if (root.Right == null)
                {
                    root.Right = new EmployeeNode(value);
                }
                else
                {
                    InsertNode(root.Right, value);
                }
            }
        }//end Insert Node

        public static void SortTreeAscending(Node root, List<Node> allNodes)
        {
            //Implement the logic
        }



    }
}
