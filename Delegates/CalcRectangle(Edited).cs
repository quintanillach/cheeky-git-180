/*
 *  C# Program to illustrate the multicasting of delegates
 * Source: Geeks for Geeks
 * Source Author: SoM15242
 * Source URL: https://www.geeksforgeeks.org/c-sharp-delegates/
 * Date Accessed: 04/22/2019
 */

using System;

namespace Delegates
{
    class Rectangle
    {
        // The Area() and Perimeter() methods both accept
        // the same parameters for their functions
        // Refactored using string interpolation
        public void Area(double height, double width)
        {
            Console.WriteLine($"Area is: {(width * height)}");
        }

        public void Perimeter(double height, double width)
        {
            Console.WriteLine($"Perimeter is: {2 * (width + height)} ");
        }

        // The delegate is declared with the same signature
        // to safely encapsulate the methods above
        public delegate void RectDelegate(double height, double width);

        public static void Main(String[] args)
        {
            // The object 'rect' is instantiated using the default
            // constructor
            Rectangle rect = new Rectangle();

            // The delegate is called and passes the parameters
            // to the Area() method
            RectDelegate rectdele = new RectDelegate(rect.Area);

            // The delegate is called again and passes the parameters
            // to the Perimeter() method using a different syntax
            rectdele += rect.Perimeter;

            // Added user input to program to calculate multiple shapes
            // using an array to store the values of each shape

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Program to Calculate the Area and Perimeter for Rectangles");
            Console.WriteLine("-----------------------------------------------------------\n");

            Console.WriteLine("How many shapes are you calculating?");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] shapes = new double[n];

            // The foreach loop iterates through the array and saves
            // the value for each shape sequentially
            foreach (double shape in shapes)
            {
                Console.WriteLine("\nEnter the height of the rectangle : ");
                string _valueOne = (Console.ReadLine());
                if (Double.TryParse(_valueOne, out double ValueOne)) ;

                Console.WriteLine("\nEnter the width of the rectangle : ");
                string _valueTwo = (Console.ReadLine());
                if (Double.TryParse(_valueTwo, out double ValueTwo)) ;

                // Finally, the delegate is invoked for each shape
                // prints the results passed from the methods back
                // to the user
                rectdele.Invoke(ValueOne, ValueTwo);
                Console.WriteLine();
            }
        }
    }
}