using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

public class MyQueue
{
    // First stack contains the "queue"
    Stack<int> mainStack = new Stack<int>();

    // Second stack is used for holding variables during queuing process
    Stack<int> secondStack = new Stack<int>();

    // Add elements to the "queue"
    public void Enqueue(int value)  // O(n)
    {
        // Check if first stack is empty
        if (mainStack.Count() == 0)
        {
            // Simply push the value to the empty stack
            mainStack.Push(value);  // O(1)
        }
        else
        {
            // Pop all integer off the stack
            while (mainStack.Count() != 0)  // O(n)
            {
                // Push each integer from first stack to the second stack
                secondStack.Push(mainStack.Pop());
            }

            // Push the new value to the main stack
            mainStack.Push(value);  // O(1)
        }

        // Pop the integers off the second stack
        while (secondStack.Count() != 0)    // O(n)
        {
            // Push each integer back to the main stack
            mainStack.Push(secondStack.Pop());
        }
    }

    public void Dequeue()   // O(1)
    {
        // Check if stack is empty
        if (mainStack.Count() == 0) // O(1)
        {
            Console.WriteLine("Queue is empty...");
        }

        else
        {
            // Simply pop the first integer
            mainStack.Pop();    // O(1)
        }
    }

    public void Print() // O(n)
    {
        // Check if stack is empty
        if (mainStack.Count() == 0) // O(1)
        {
            Console.WriteLine("Queue is empty...");
        }

        else
        {
            // Use temporary array to hold integers
            int[] temp = new int[mainStack.Count()];

            // Copy elements rather than pop to avoid data loss
            mainStack.CopyTo(temp, 0);  // O(n)

            // Print each element in the array with space-separation
            for (int i = 0; i < temp.Length; i++)   // O(n)
            {
                Console.Write($"{temp[i]} ");
            }

            Console.WriteLine("\n");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Invoke default constructor for MyQueue
        MyQueue Q = new MyQueue();

        // Add elements into the "queue"
        Q.Enqueue(10);
        Q.Enqueue(20);
        Q.Enqueue(30);
        Q.Enqueue(40);
        Q.Enqueue(50);
        Q.Enqueue(60);

        // Print the original stack
        Q.Print();

        // Demonstrate the dequeue method
        Q.Dequeue();
        Q.Print();
    }
}