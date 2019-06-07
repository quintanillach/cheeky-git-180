/*
 * C# Program to Implement Stack with Push and Pop operations
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-stack-push-pop/
 * Date Accessed: 04/24/2019
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Implemented namespace for repo
// Renamed members using Pascal case
namespace DataStructures
{
    public class StackPushPop
    {
        public static void Main(string[] args)
        {
            // The Stack class object is instantiated using
            // the default constructor
            Stack stackOne = new Stack();

            // The while loop will always be true, which keeps
            // the thread alive and allows the stack memory
            // to be accessible until exited by the user
            while (true)
            {
                // The menu will display constantly until the user
                // selects the exit case. As the user pushes and pops
                // elements from the stack, the changes are saved to the
                // stackOne object
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");

                // Changed Convert.ToInt32 to TryParse for
                // protection against exceptions
                string _choice = (Console.ReadLine());
                int.TryParse(_choice, out int choice);

                // The switch-case block executes a method within the Stack class
                // which correlates to the stack operations
                // Implemented string interpolation
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        stackOne.Push(Console.ReadLine());
                        break;
 
                    case 2: Console.WriteLine($"Top element is: {stackOne.Peek}");
                        break;
 
                    case 3: Console.WriteLine($"Element removed: {stackOne.Pop}");
                        break;
 
                    case 4: stackOne.Display();
                        break;
 
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
 
    // The StackADT interface contains empty methods for
    // the inheriting class to implement
    // Changed fields to read-only properties
    interface StackADT
    {
        Boolean isEmpty { get; }

        void Push(Object element);
        Object Pop { get; }

        Object Peek { get; }

        void Display();
    }

    // The Stack class inherits from the StackADT interface
    public class Stack : StackADT
    {
        // This is the backing field for the StackSize property
        private int StackSize;

        public int StackSizeSet
        {
            get { return StackSize1; }
            set { StackSize1 = value; }
        }

        public int top;

        Object[] item;

        // The default constructor sets the default stack
        // capacity to 10 and instantiates the item[]
        // array with the elements based on the default capacity
        public Stack()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }

        // The second Stack() constructor is an example of
        // method overloading with this paramterized constructor
        // instantiating the item[] if another capacity is specified
        // by the caller
        public Stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }

        // The isEmpty method returns true if no elements are present
        // in the item[] array
        public bool isEmpty
        {
            get
            {
                if (top == -1) return true;

                return false;
            }
        }

        // The if else statement in the Push method ensures
        // the number of elements does not exceed the specified capacity
        // and adds elements to the item[]
        public void Push(object element)
        {
            if (top == (StackSize1 - 1))
            {
                Console.WriteLine("Stack is full!");
            }
 
            else
            {
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        // The Pop  checks if the stack is empty
        // and executes a popping operation (removes top element)
        // when it is not. The Pop property is readonly
        public object Pop
        {
            get
            {
                if (isEmpty)
                {
                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {

                    return item[top--];
                }
            }
        }

        // Th Peek property executes exactly as the Pop property
        // except it executes a Peek operation on the stack
        public object Peek
        {
            get
            {
                if (isEmpty)
                {

                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {
                    return item[top];
                }
            }
        }

        public int StackSize1 { get => StackSize; set => StackSize = value; }

        // Prints the elements in the item[] array
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
 
                Console.WriteLine($"Item {(i + 1)}: {item[i]}");
            }
        }
    }
}