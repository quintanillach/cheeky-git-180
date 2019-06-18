using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Lessons
{
    // User-defined Exception to display custom error message
    // for program-specific exception
    public class NegativeNumberException : Exception
    {
        // Default constructor prints a simple message
        public NegativeNumberException()
        {
            Console.WriteLine("Number is Negative");
        }
    }
    public class FactorOfThree
    {
        public static void Main(string[] args)
        {
            // Request user input for positive integer
            Console.WriteLine("Enter a number (positive integer) : ");

            // Try-catch block handles custom and built-in exceptions
            try
            {
                // Attempt to convert user input to an integer
                int number = Convert.ToInt32(Console.ReadLine());

                // Check if number is positive, else throw custom exception
                if (number < 0)
                {
                    throw new NegativeNumberException();
                }
                // If number is positive, check if divisible by three
                else if (number % 3 == 0)
                {
                    Console.WriteLine("The number is divisible by 3.");
                }
                // Otherwise print as NOT divisible by 3
                else
                {
                    Console.WriteLine("The number is NOT divisible by 3.");
                }

            }
            // FormatException thrown when input is not of acceptable type
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Custom exception for handling negative integers
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}