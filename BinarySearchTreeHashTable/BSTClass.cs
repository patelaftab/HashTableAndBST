using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeHashTable
{
    internal class BinarySearchTreeClass
    {
        Node root;
        public void Insert(Node node)
        {
            root = InsertHelper(root, node);
        }
        public Node InsertHelper(Node root, Node node)
        {
            int data = node.data;
            if (root == null)
            {
                root = node;
                return root;
            }
            else if (data < root.data)
            {
                root.left = InsertHelper(root.left, node);
            }
            else
            {
                root.right = InsertHelper(root.right, node);
            }
            return root;
        }
        public void Display()
        {
            DisplayHelper(root);
        }
        public void DisplayHelper(Node root)
        {
            if (root != null)
            {
                DisplayHelper(root.left);
                Console.Write(root.data + " ");
                DisplayHelper(root.right);
                return;
            }
        }
    }
}
