/*
 * C# Program to check is a number is a power of two
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/csharp-program-to-find-whether-a-no-is-power-of-two/
 * Date Accessed: 05/04/2019
 */

using System;

// Implemented namespace and renamed class
namespace DataStuctures
{
    // Added public access modifier for testing
    public class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int x)
        {
            // The function in this method checks if the
            // given value is not zero and if the binary
            // values share common bits
            // Returns true if both conditions are true
            return x != 0 && ((x & (x - 1)) == 0);
        }

        public static void Main()
        {
            // Added title block to program
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine(" Check if a given number is a power of two : ");
            Console.WriteLine(" ---------------------------------------------\n"); ;

            // Added user input of multiple values to check
            // Write input to string and use TryParse to convert
            // string to int data type
            Console.WriteLine(" How many numbers are you checking?");
            string userCheck = (Console.ReadLine());
            int.TryParse(userCheck, out int elements);

            // Declared an integer array with a capacity
            // equal to the value above
            int[] numbersChecked = new int[elements];

            Console.WriteLine(" Enter the numbers : ");

            // The for loop iterates through the array and adds
            // elements through user input to each index
            // The user input is written to a string and
            // converted using TryParse before being assigned to
            // the index to ensure compatibility
            // The variables within the loop are overwritten each iteration
            for (int i = 0; i < numbersChecked.Length; i++)
            {
                Console.Write($" Number [{i + 1}] - ");
                string _eachNumber = (Console.ReadLine());
                int.TryParse(_eachNumber, out int eachNumber);
                numbersChecked[i] = eachNumber;
            }

            Console.WriteLine(" Results : ");

            // The foreach loop passes each element in the array above
            // to the isPowerOfTwo method and write the output
            // to separate lines
            foreach (int number in numbersChecked)
            {
                Console.WriteLine(IsPowerOfTwo(number) ? " Yes" : " No");
            }
        }
    }
}