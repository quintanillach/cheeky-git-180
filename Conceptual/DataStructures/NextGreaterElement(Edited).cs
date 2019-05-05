/*
 * C# solution to print next greater element using stack
 * Source: Geeks for Geeks
 * Source Author: Shrikant13
 * Source URL: https://www.geeksforgeeks.org/next-greater-element/
 * Date Accessed: 04/30/2019
 */

using System;

namespace DataStructures
{
    public class Stack
    {
        // Encapsulated fields and implemented properties
        private int top;
        private int[] items = new int[100];

        public int Top { get => top; set => top = value; }
        public int[] Items { get => items; set => items = value; }

        // The Push method adds elements to the Items stack
        // only if the stack is not full
        // The virtual keyword allows this method to be
        // overrode
        public virtual void Push(int x)
        {
            if (Top == 99)
            {
                Console.WriteLine("Stack full");
            }
            else
            {
                Items[++Top] = x;
            }
        }

        // The Pop method removes the top element
        // in the Items stack if called as long as the
        // stack is not empty
        public virtual int Pop()
        {
            if (Top == -1)
            {
                Console.WriteLine("Underflow error");
                return -1;
            }
            else
            {
                int element = Items[Top];
                Top--;
                return element;
            }
        }

        // The Empty method uses the tuple to return a boolean
        // value based on whether the stack is empty
        public virtual bool Empty
        {
            get
            {
                return (Top == -1) ? true : false;
            }
        }
    }

    public class NextGreatestElement
    {
        public static void PrintNextGreatestElement(int[] arr, int n)
        {
            // The default constructor for the Stack class
            // is called and an object Stack is instantiated
            Stack currentStack = new Stack();

            // The Top property is set to -1 to indicate an empty stack
            currentStack.Top = -1;

            int element, next;

            // The zero index for the parameter passed by the caller
            // is added to the stack
            currentStack.Push(arr[0]);

            // Moved int declaration to within the for loop for terseness
            // This for loop iterates through the passed array and assigns
            // a value to the next variable for each element
            for (int i = 1; i < n; i++)
            {
                next = arr[i];

                // The if statement executes when the stack is not empty
                if (currentStack.Empty == false)
                {
                    element = currentStack.Pop();

                    // The rest of the for loop compares the values in the
                    // stack and prints the element if the next element is
                    // larger than the current one
                    while (element < next)
                    {
                        Console.WriteLine($"{element} --> {next}");
                        if (currentStack.Empty == true)
                        {
                            break;
                        }
                        element = currentStack.Pop();
                    }

                    if (element > next)
                    {
                        currentStack.Push(element);
                    }
                }

                currentStack.Push(next);
            }

            while (currentStack.Empty == false)
            {
                element = currentStack.Pop();
                next = -1;
                Console.WriteLine($"{element} -- {next}");
            }
        }

        public static void Main(string[] args)
        {
            // Added title block
            Console.WriteLine(" ---------------------------------------------------------------");
            Console.WriteLine(" Print the next greater element for each element in an array : ");
            Console.WriteLine(" ---------------------------------------------------------------\n");

            // Added user input to program
            Console.Write("Enter the number of elements : ");
            string numberElements = (Console.ReadLine());
            int.TryParse(numberElements, out int n);
            int[] stackArray = new int[n];

            Console.WriteLine("Enter each element - ");

            // Added for loop to save elements to the array
            // and used TryParse for protection
            for (int i = 0; i < stackArray.Length; i++)
            {
                string s = (Console.ReadLine());
                int.TryParse(s, out int j);
                stackArray[i] = j;
            }

            int arrayLength = stackArray.Length;

            // Calls the PrintNextGreatestElement and passes the array
            PrintNextGreatestElement(stackArray, arrayLength);
        }
    }
}