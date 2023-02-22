using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBinarySearch
{
    public class BinarySearchTreeUsingLoop
    {
        public Node? root;

        public bool InsertNode(int data)
        {
            /*
             * create newNode
             * if(root == null) root = newNode
             * temp = newNode
             * while(true)
             * if (newNode == temp) return false 
             * if(data > node.data) to right
             * if(data < node.data) to left
             * 
             */

                Node newNode = new Node(data);
                if (root == null)
                {
                    root = newNode;
                    return true;
                }
                Node temp = root;
                while (true)
                {
                    if (newNode.Data == temp.Data) return false;
                    if (newNode.Data < temp.Data)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = newNode;
                            return true;
                        }
                        temp = temp.Left;
                    }
                    else
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = newNode;
                            return true;
                        }
                        temp = temp.Right;
                    }
                }
            }//end InsertNode method
    }
}
