/*
 * Purpose: C# Program to Compute Average for the Set of Values
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-average-values/
 * Date Accessed: 03/31/2019
 */
 
 
 //Import System namespace
using System;

namespace Basics
{
    class ComputeAverage
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Compute the Average of a Set of Values :");
            Console.WriteLine("-------------------------------------------------------------------------\n");

            // The original segment declared multiple integer variables on the same line
            // and did not use the declared variables until the end of the program.
            // This detracted from readability and easy identification of the
            // implementation, so the variables were moved from the one line
            // to just before they are implemented.
            int m = 0;
            int i = 0;

            // This function displays a request for user input of the amount of
            // terms in the set they want to compute. Then the input is converted
            // from the default data type of string to an integer and assigns
            // the value to the integer 'm'.
            Console.WriteLine("Enter the Number of Terms in the Array ");
            m = int.Parse(Console.ReadLine());

            // Here, an array 'a' of integers is created with the new keyword and
            // instantiated with 'm' number of elements. Then a requests for user
            // input assigns set of values to each index in the array based on an
            // iteration of int 'i'. This iteration sequentially assigns the inputted
            // values to the index without skipping or exceeding its length. The console
            // stops receiving input and proceeds to the next function only when the 
            // user inputs the stated number of elements.
            int[] a = new int[m];
            Console.WriteLine("Enter the Array Elements (Press enter after each element) : ");
            for (i = 0; i < m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            // Once the elements are received, the array is summed up one at a time
            // through iteration in the for loop. The sum is then divided by the
            // number of elements 'm' and printed to the console. Finally, the program
            // waits for the user to press Enter before terminating.
            int sum = 0;
            int avg = 0;
            for (i = 0; i < m; i++)
            {
                sum += a[i];
            }
            avg = sum / m;
            Console.WriteLine($"\nAverage is {avg}");
            Console.ReadLine();
        }
    }
}
