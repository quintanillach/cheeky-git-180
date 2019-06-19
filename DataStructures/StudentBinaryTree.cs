using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module4_Homework
{
    public class Student
    {
        // Backing fields for student information
        private string _name;
        private string _major;
        private string _homeState;

        // Properties for student information
        public string Name { get => _name; set => _name = value; }
        public string Major { get => _major; set => _major = value; }
        public string State { get => _homeState; set => _homeState = value; }

        // Custom constructor to force required information
        public Student(string name, string major, string homeState)
        {
            Name = name;
            Major = major;
            State = homeState;
        }
    }

    public class Tree
    {
        // Node class holds Student objects
        public class Node
        {
            public Student data;
            public Node left;
            public Node right;

            // Constructor must pass a Student object to be valid input into tree
            public Node(Student newStudent)
            {
                data = newStudent;
                left = null;
                right = null;
            }

            // Print the name of the student with space separation
            public void DisplayNode()
            {
                Console.Write($"{data.Name} ");
            }
        }

        // root node is null until assigned
        public Node root = null;

        // Check if Tree instance is empty
        public bool IsEmpty()
        {
            return root == null;
        }

        // Insert a new value into the tree while maintaining the BST structure
        // given student information 
        public void Insert(string studentName, string major, string homeState)
        {
            // Instantiate new student object with given information
            Student newStudent = new Student(studentName, major, homeState);

            // Declare a new node
            Node studentNode = new Node(newStudent);

            if (IsEmpty())
            {
                // Set the new student as the root Node if tree is currently empty
                root = studentNode;
            }
            else
            {
                // Set a current pointer to track comparisons
                Node current = root;
                Node parent;

                // Infinite loop
                while (true)
                {
                    parent = current;

                    // Compare the current node with the new student
                    if (current.data.Name.CompareTo(studentNode.data.Name) >= 0)
                    {
                        // Move new pointer to left if new student is before current in alphabetical order
                        current = current.left;

                        // Check for left node
                        if (current == null)
                        {
                            // Set new student as left node when left node is empty
                            parent.left = studentNode;

                            // End the loop
                            break;
                        }
                    }

                    else
                    {
                        // Otherwise move to the right of the tree
                        current = current.right;

                        if (current == null)
                        {
                            // Set new student as right when right is empty
                            parent.right = studentNode;

                            // End the loop
                            break;
                        }
                    }
                }
            }
        }

        // Overload the insert method with same exeuction as above
        public void Insert(Student newStudent)
        {
            Node newStudentNode = new Node(newStudent);

            if (IsEmpty())
                root = newStudentNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (current.data.Name.CompareTo(newStudentNode.data.Name) >= 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newStudentNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newStudentNode;
                            break;
                        }
                    }
                }
            }

        }

        // Print tree in alphabetical order
        public void PrintInOrder(Node myNode)
        {
            if (myNode == null)
                return;

            // Recursively call the print method for child nodes
            PrintInOrder(myNode.left);
            myNode.DisplayNode();
            PrintInOrder(myNode.right);
        }

        // Print tree with root first
        public void PrintPreOrder(Node myNode)
        {
            if (myNode == null)
                return;

            // Recursively call the print method for child nodes
            myNode.DisplayNode();
            PrintInOrder(myNode.left);
            PrintInOrder(myNode.right);
        }

        // Print tree with root last
        public void PrintPostOrder(Node myNode)
        {
            if (myNode == null)
                return;

            // Recursively call the print method for child nodes
            PrintInOrder(myNode.left);
            PrintInOrder(myNode.right);
            myNode.DisplayNode();

        }

        public bool Search(string studentName)
        {
            // Check if tree is empty
            if (IsEmpty())
                return false;
            else
            {
                // Set current pointer
                Node current = root;

                // Until the entire tree is searched
                while (current != null)
                {
                    // Check if current is the student we are looking for
                    if (current.data.Name == studentName)
                    {
                        return true;
                    }
                    // Otherwise move to appropriate subtrees
                    else if (current.data.Name.CompareTo(studentName) > 0)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }

                // If student is not found return false
                return false;
            }
        }

        // Calculate the height of the tree instance
        public int Height(Node myNode)
        {
            if (myNode == null)
                return 0;
            else
            {
                // Recursively call the height method to check subtrees
                int leftHeight = Height(myNode.left);
                int rightHeight = Height(myNode.right);

                // Increment the larger value
                if (leftHeight > rightHeight)
                    return (leftHeight + 1);
                else
                    return (rightHeight + 1);
            }
        }

        // Calculate the number of leaf nodes in the tree instance
        public int NumberOfLeafNodes(Node myNode)
        {
            if (myNode == null)
            {
                return 0;
            }

            // Leaf node
            else if (myNode.left == null && myNode.right == null)
            {
                return 1;
            }

            // Continue to next subtree
            else
            {
                return NumberOfLeafNodes(myNode.left) + NumberOfLeafNodes(myNode.right);
            }
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            Tree Students = new Tree();

            Student Bob = new Student("Bob", "Math", "Virginia");
            Student Alice = new Student("Alice", "Sociology", "Washington");
            Student Logan = new Student("Logan", "History", "Oregon");
            Student Chad = new Student("Chad", "Economics", "Massachussets");
            Student Hannah = new Student("Hannah", "Drama", "Tennessee");

            Students.Insert(Bob);
            Students.Insert(Alice);
            Students.Insert(Logan);
            Students.Insert(Chad);
            Students.Insert(Hannah);

            Students.PrintInOrder(Students.root);

            Students.Insert("Dave", "Psychology", "Wisconsin");

            Console.WriteLine("\n");
            Students.PrintInOrder(Students.root);
            Console.WriteLine("\n");


            Console.WriteLine($"The height of the tree is {Students.Height(Students.root)} nodes");
            Console.WriteLine($"The tree contains {Students.NumberOfLeafNodes(Students.root)} leaf nodes");
        }
    }

}