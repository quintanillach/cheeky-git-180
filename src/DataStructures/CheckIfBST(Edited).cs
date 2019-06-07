/*
 * C# Program to check if a binary tree is a binary search tree
 * Source: Geeks for Geeks
 * Source Author: Shrikant13
 * Source URL: https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/
 * Date Accessed: 05/04/2019
 */

using System;

// Added namespace for repo
namespace DataStructures
{
    public class Node
    {
        public int data;
        // The default constructor is called and two object
        // are instantiated
        public Node left, right;

        // An alternate constructor accepts parameters and assigns
        // values to the fields using the value of the parameter
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // An object of type Node is instantiated as the root (base)
        // of the tree
        public Node root;

        // Returns a boolean value passed from the IsBSTUtil method
        public virtual bool BST
        {
            get
            {
                return IsBSTUtil(root, int.MinValue, int.MaxValue);
            }
        }

        public virtual bool IsBSTUtil(Node node, int min, int max)
        {
            // First if statement returns true if node is null
            // based on common rules for BSTs
            if (node == null)
            {
                return true;
            }

            // Checks if the given element exceeds the 
            // limits of the int type
            if (node.data < min || node.data > max)
            {
                return false;
            }

            // Uses recursion to evaluate child nodes
            return (IsBSTUtil(node.left, min, node.data - 1) && IsBSTUtil(node.right, node.data + 1, max));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Check is a binary tree is classified as a BST");
            Console.WriteLine("-----------------------------------------------\n");
            // The default constructor is called for BinaryTree
            // instantiating the tree
            BinaryTree tree = new BinaryTree();

            // The root field value is assigned and a node
            // within the tree is declared
            tree.root = new Node(4);

            // New nodes are added calling the left and right
            // fields from the Node class
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            if (tree.BST)
            {
                Console.WriteLine("IS BST");
            }
            else
            {
                Console.WriteLine("Not a BST");
            }
        }
    }
}