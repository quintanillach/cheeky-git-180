/*
 * C# Program to Implement Binary Search Tree using Linked List
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-binary-search-tree-linked-list/
 * Date Accessed: 04/24/2019
 */
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    // The Node class contains the standard left
    // and right elements of a Binary Search tree
    // Implemented private fields and public properties
    public class Node
    {
        private int item;
        private Node leftc;
        private Node rightc;

        public int Item { get => item; set => item = value; }
        public Node Leftc { get => leftc; set => leftc = value; }
        public Node Rightc { get => rightc; set => rightc = value; }

        // The Display method prints the item to the console
        public void Display()
        {
            Console.Write("[");
            Console.Write(Item);
            Console.Write("]");
        }
    }
    public class Tree
    {
        // Declares a Node object 'root'
        public Node root;

        // The default constructor assigns the default value
        // to the above object
        public Tree()
        { 
            root = null; 
        }

        public Node ReturnRoot()
        {
            return root;
        }

        // The Insert() method contains the logic for adding items
        // to the Node object with an integer parameter
        public void Insert(int id)
        {
            // The default constructor is instantiated
            // and assigns the parameter as the value of the
            // Item property of the Node object
            Node newNode = new Node();
            newNode.Item = id;

            // The if statement evaluates the 'root' Node object
            // for the default value and assigns the value of the newNode
            // object to the root object
            if (root == null)
                root = newNode;

            // When the root object does not contain the default value
            // the else block instantiates other Node objects within
            // the Binary Search tree and executes the method
            // for sorting items in the structure through swapping values
            // based on value of the element
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.Item)
                    {
                        current = current.Leftc;
                        if (current == null)
                        {
                            parent.Leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Rightc;
                        if (current == null)
                        {
                            parent.Rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }

        // These methods print the values of the items in the
        // Root object when called
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Item + " ");
                Preorder(Root.Leftc);
                Preorder(Root.Rightc);
            }
        }

        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.Leftc);
                Console.Write(Root.Item + " ");
                Inorder(Root.Rightc);
            }
        }

        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.Leftc);
                Postorder(Root.Rightc);
                Console.Write(Root.Item + " ");
            }
        }
    }
    sealed class LinkedListBinarySearch
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(99);
            theTree.Insert(91);            
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}