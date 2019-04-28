/*
 * C# Program to Print Even and Odd Ranges
 * Source Author: W3Resource
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-6.php
 * Date Accessed: 04/24/2019
 */

using System;

namespace Recursion
{
    public class PrintEvenAndOdd
    {
        public static void Main()
        {
            Console.WriteLine(" -------------------------------------------------------------");
            Console.Write("\n Recursion : Print even or odd numbers in a given range :");
            Console.Write(" -------------------------------------------------------------\n");

            // Refactored n as string to implement TryParse for protection
            // against invalid input
            Console.Write(" Input the range to print starting from 1 : ");
            string n = (Console.ReadLine()); 
            int.TryParse(n, out int maxRange);

            Console.WriteLine($"\n All even numbers from 1 to {maxRange} are : ");
            // The EvenAndOdd method is called with two as the first even value
            EvenAndOdd(2, maxRange);

            Console.WriteLine($"\n\n All odd numbers from 1 to {maxRange} are : ");
            // The EvenAndOdd method is called with one as the first odd value
            EvenAndOdd(1, maxRange);
            Console.WriteLine("\n\n");

            return;
        }

        // The EvenAndOdd method receives the parameters from the caller (Main)
        public static void EvenAndOdd(int startingValue, int maxRange)
        {
            // If the maxRange is less than the
            // starting value, return to the caller
            if (startingValue > maxRange)
            {
                return;
            }
            Console.Write($" {startingValue}  ");

            // The method calls back upon itself iterating by two until
            // the maxRange is less than the next iteration
            EvenAndOdd(startingValue + 2, maxRange);
        }
    }
}