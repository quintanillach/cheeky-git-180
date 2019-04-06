/*
 * C# Program to Demonstrate IndexOutOfRange Exception
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-indexoutofrange-exception/
 * Date Accessed: 03/31/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Difference
{
    // Renamed the classes and methods using Pascal case per .NET conventions
    class ArrayOutOfIndex
    {
        public void CalculatedDifference()
        {
            int difference = 0;
            // This program initializes an array of integers using the new keyword
            // but in the original program, the length specified was used inside the
            // initialization. This is unnecessary since the array elements are already
            // declared on the same line and no new elements are added later.
            int [] number= new int[] {1,2,3,4,5};

            // This program uses the try-catch statement to handle exceptions and prevent
            // the program from crashing. The try block guards the code which may cause
            // the errors. In this case, the array 'number' only contains five elements
            // which makes it very likely that an user would input a value outside of
            // its bounds. The code inside of the try block for this program checks if
            // the initial number is within the scope of the array and prints the result
            // when possible. The catch clause underneath then handles values outside of
            // the range of the array by displaying the message based on the exception
            // parameters.
            try
            {
                for (int init = 1; init <= 5; init++)
                {
                    difference = difference - number[init];
                }
                // The original program used the '+' operator to concatenate the
                // string and the 'difference' variable. I decided to use the '$'
                // character to take advantage of the string interpolation and improve
                // readability. The function still performs the same action as before.
                Console.WriteLine($"The difference of the array is: {difference}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class ClassMain
    {
        static void Main(string [] args)
        {
        // This constructor instantiates the ArrayOutOfIndex object and passes
        // the object to the CalculatedDifference Method. The program then 
        // waits for the user to press Enter before terminating.
        ArrayOutOfIndex obj = new ArrayOutOfIndex();
        obj.CalculatedDifference();
        Console.ReadLine();
        }
}
}
