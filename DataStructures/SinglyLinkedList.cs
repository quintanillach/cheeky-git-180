using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    public class SinglyLinkedList
    {
        // Node class for single-linked list contains only a next value
        public class Node 
        {
            public string data { get; set; }
            public Node next { get; set; }

            // Overloaded constructor to set the value of the node
            public Node(string value)
            {
                data = value;
                next = null;
            }
        }

        // Declare the head of the list
        public Node first;

        // Default constructor with empty list
        public SinglyLinkedList()   // O(1)
        {
            first = null;
        }

        // Returns whether list is empty or not
        public bool IsEmpty()   // O(1)
        {
            return first == null;
        }

        // Add an element to the front of the list
        public void AddFirst(string value)  // O(1)
        {
            Node newNode = new Node(value);

            if (!IsEmpty()) // O(1)
            {
                // Assign the value of the next pointer to the current first node
                newNode.next = first;
            }

            // Set the newNode as the first
            first = newNode;    // O(1)
        }

        // Add an element to the end of the list
        public void AddLast(string value)   // O(n)
        {
            if (IsEmpty())  // O(1)
            {
                // Pass the value to the AddFirst method if empty list            
                AddFirst(value);    // O(1)
            }

            else
            {
                Node newNode = new Node(value);

                // Declare a node for tracking pointers and begin at first node
                Node current = first;

                while (current.next != null)    // O(n)
                {
                    // Iterate through the list until the last node is reached
                    current = current.next;
                }

                // Set the next pointer of the last node to be the newNode reference
                current.next = newNode;
            }
        }

        // Pass the first node as a reference and RemoveDuplicate values from the instance
        public void RemoveDuplicates(Node first)    // O(n^2)
        {
            // If list is empty there are no duplicates
            if (IsEmpty())  // O(1)
            {
                return;
            }

            // Current serves as a reference for comparison
            Node current = first;

            // If array contains only one element there are no duplicates
            while (current != null && current.next != null) // O(n)
            {
                Node runner = current;

                // Execute for all other nodes as runner reference
                while (runner.next != null)   // O(n)
                {
                    // Compare string values of each node
                    if (current.data.Equals(runner.data)) // O(1)
                    {
                        // Discard serves as a temporary Node for deletion
                        _ = runner.next;
                        runner.next = runner.next.next;

                        // Break from statement once a value is matched and deleted
                        break;
                    }
                    else
                    {
                        // Next node
                        runner = runner.next;
                    }
                }

                // Next iteration
                current = current.next;
            }

        }

        // Determine whether the list is a palindrome (same forward and backward)
        public static bool IsPalindrome(Node first) // O(n)
        {
            // Empty list is not a palindrome
            if (first == null)  // O(1)
            {
                return false;
            }

            // List of one node is a palindrome
            else if (first.next == null)    // O(1)
            {
                return true;
            }

            // Declare an indexer to track the nodes pushed to the stack
            Node index_1 = first;

            // Initialize a stack of the same type as the nodes
            Stack<string> myStack = new Stack<string>();

            // Push all the nodes onto the stack
            while (index_1 != null) // O(n)
            {
                myStack.Push(index_1.data); // O(1)
                index_1 = index_1.next;
            }

            // Declare a second indexer for the next loop
            Node index_2 = first;

            while (index_2 != null) // O(n)
            {
                // Temporary string holds the value at the top of the stack (the last node)
                string temp = myStack.Pop();    // O(1)

                // Compare the popped node with the first index and continue until not equal
                if (index_2.data.Equals(temp))  // O(1)
                {
                    index_2 = index_2.next;
                }
                else   // O(1)
                {
                    // If the node values do not match, the list is not a palindrome
                    return false;
                }
            }

            // All nodes matched and list is a palindrome
            return true;
        }

        // Print the list
        public void PrintList() // O(n)
        {
            Console.WriteLine("\n");

            if (IsEmpty())  //O(1)
            {
                Console.WriteLine("The list is empty...");
            }
            
            else
            {
                // Start from first node
                Node current = first;

                while (current != null) //O(n)
                {
                    // Print to console with space separation
                    Console.Write($"{current.data} ");

                    // Move to next node
                    current = current.next;
                }

                Console.WriteLine("\n");
            }
        }
    }
    
    

    public class MSSA_List
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList problem1 = new SinglyLinkedList();
            problem1.AddFirst("apple");
            problem1.AddLast("banana");
            problem1.AddLast("chocolate");
            problem1.AddLast("chocolate");
            problem1.AddLast("banana");
            problem1.AddLast("apple");

            problem1.PrintList();

            problem1.RemoveDuplicates(problem1.first);
            problem1.PrintList();

            if (SinglyLinkedList.IsPalindrome(problem1.first))
            {
                Console.WriteLine("Singly Linked List is a palindrome");
            }
            else
            {
                Console.WriteLine("Singly Linked List is not a palindrome");
            }
        }
    }
}
