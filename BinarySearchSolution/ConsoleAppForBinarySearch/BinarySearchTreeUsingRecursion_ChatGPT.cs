using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBinarySearch
{
    public class BinarySearchTreeUsingRecursion_ChatGPT
    {
        public static void InsertNode(Node root, int value)
        {
            if (value < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = new Node(value);
                }
                else
                {
                    InsertNode(root.Left, value);
                }
            }
            else if (value > root.Data)
            {
                if (root.Right == null)
                {
                    root.Right = new Node(value);
                }
                else
                {
                    InsertNode(root.Right, value);
                }
            }
        }

        public static void SortTreeAscending(Node root, List<Node> allNodes)
        {
            //Implement the logic
        }

        public static void SortTreeDescending(Node root, List<Node> allNodes)
        {
            //Implement the logic
        }
    }
}
