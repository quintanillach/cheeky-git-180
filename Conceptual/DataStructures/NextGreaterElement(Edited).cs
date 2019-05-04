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

            currentStack.Top = -1;

            int element, next;

            currentStack.Push(arr[0]);

            // Moved int declaration to within the for loop for terseness
            for (int i = 1; i < n; i++)
            {
                next = arr[i];

                if (currentStack.Empty == false)
                {
                    element = currentStack.Pop();

                    while (element < next)
                    {
                        Console.WriteLine(element + " --> " + next);
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
                Console.WriteLine(element + " -- " + next);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(" ---------------------------------------------------------------");
            Console.WriteLine(" Print the next greater element for each element in an array : ");
            Console.WriteLine(" ---------------------------------------------------------------\n");
            int[] stackArray = new int[] { 11, 13, 21, 3 };
            int arrayLength = stackArray.Length;
            PrintNextGreatestElement(stackArray, arrayLength);
        }
    }
}