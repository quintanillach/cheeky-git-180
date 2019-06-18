using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Module_3
{
    public class Program
    {
        // Method to reverse the integers in a queue
        public static void ReverseQueue(Queue<int> Q)   // O(n)
        {
            // Initialize stack to store elements in LIFO order
            Stack<int> S = new Stack<int>();
            int current;

            // Check is queue is empty
            if (Q.Count() == 0) // O(1)
            {
                Console.WriteLine("Queue is empty...");
            }

            // Execute until queue is empty
            while (Q.Count() != 0) // O(n)
            {
                // Save first element in queue to current variable
                current = Q.Dequeue();

                // Push the element onto the stack
                S.Push(current);
            }

            // Pop off the stack and back into the original queue (in reverse order)
            while (S.Count() != 0)  // O(n)
            {
                Q.Enqueue(S.Pop());
            }
        }

        // Print the elements in a given queue
        public static void PrintQueue(Queue<int> Q) // O(n)
        {
            Console.WriteLine("\n");

            // Initialize an array of the same type and size as the queue
            int[] printArray = new int[Q.Count()];

            // Copy the elements to the new array
            Q.CopyTo(printArray, 0);    // O(n)

            // Display each element in the array with space-separation
            foreach(int element in printArray)  // O(n)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            // Initialize the queue and add elements
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(12);
            Q.Enqueue(24);
            Q.Enqueue(48);
            Q.Enqueue(96);
            
            // Print the elements in original order
            PrintQueue(Q);

            // Call the reverse method
            ReverseQueue(Q);

            // Print the elements in the new order
            PrintQueue(Q);
        }
    }
}