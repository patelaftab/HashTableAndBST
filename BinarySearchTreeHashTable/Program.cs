using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hash Table And Binary Search Tree Problem");
            BinarySearchTreeClass BST = new BinarySearchTreeClass();
            BST.Insert(new Node(56));
            BST.Insert(new Node(30));
            BST.Insert(new Node(70));
            Console.Write("Binary Search Tree :");
            BST.Display();
            Console.ReadLine();
        }

    }
}
