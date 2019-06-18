using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module4_Homework
{
    public class Student : IComparable
    {
        // You need to implement a Student class that stores name, major, and state of origin.
        private string _name;
        private string _major;
        private string _homeState;

        public string Name { get => _name; set => _name = value; }
        public string Major { get => _major; set => _major = value; }
        public string State { get => _homeState; set => _homeState = value; }

        public int CompareTo(object obj)
        {
            return _name.CompareTo(obj);
        }
    }

    //  Create a Tree class that implements the binary search tree(BST) methods shown below, and stores 
    //  objects of class Student.
    //  The students should be sorted alphabetically by names in the tree:
    public class Tree
    {
        public class Node
        {
            public Student data;
            public Node left;
            public Node right;
            public void DisplayNode()
            {
                Console.Write($"{data} ");
            }
        }

        public Node root = null;

        public bool IsEmpty()
        {
            return root == null;
        }

        //  Insert(a new value into the tree while maintaining the BST structure): 
        public void Insert(string studentName, string major, string homeState)
        {

        }

        //  Insert(a new value into the tree while maintaining the BST structure): 
        public void Insert(Student newStudent)
        {
            Node newStudentNode = new Node();
            newStudentNode.data = newStudent;

            if (IsEmpty())
                root = newStudentNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(newStudent) > 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newStudentNode;
                            break;
                        }
                    }
                }
            }

        }

        //  Traversal: PrintInOrder, PrintPreOrder, PrintPostOrder
        //  Search (for a value in the tree) : 
        public bool Search(string studentName)
        {

        }

        //  Height of Binary Tree:  
        public int Height()
        {

        }

        //  Number of leaf nodes: 
        public int NumberOfLeafNodes()
        {

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

}