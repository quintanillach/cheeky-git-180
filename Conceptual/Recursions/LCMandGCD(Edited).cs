/* 
 * C# program to find the least common multiplier and the greatest common denominator of a pair of numbers
 * Source: W3Resource
 * Source Author: 
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-12.php
 * Date Accessed: 04/05/2019
 */


using System;
using System.Text;

namespace Recursions
{
    class LCMandGCD
    {
        public static void Main()
        {
            // These variables are declared up front using the
            // long data type rather than the normal integer
            // for a larger minimum and maximum value.
            long hcf, lcm;
            Console.WriteLine("\n\n Recursion : Find the LCM and GCD of two numbers :");
            Console.WriteLine("------------------------------------------------------");

            // Refactored the input as strings to use TryParse() methods
            // The console displays a request for two numbers
            // and converts them from strings to long integers
            // using the TryParse method for protection against
            // invalid user input.
            Console.Write(" Input the first number : ");
            string num1 = (Console.ReadLine());
            long.TryParse(num1, out long Num1);
            Console.Write(" Input the second number : ");
            string num2 = (Console.ReadLine());
            long.TryParse(num2, out long Num2);

            // Here the Main() method passes the output from the TryParse
            // as paramters for the GCD() method and assigns the method
            // return values to the local variable 'hcf'
            hcf = GCD(Num1, Num2);
            lcm = (Num1 * Num2) / hcf;

            // Refactored these console.writeline functions using string interpolation
            // for readability and concision
            Console.WriteLine($"\n The GCD of {Num1} and {Num2} = {hcf}");
            Console.WriteLine($" The LCM of {Num1} and {Num2} = {lcm}\n");
        }

        // The GCD() method takes the Num1 and Num2 inputs from above
        // as parameters. The if statement then evaluates the input
        // for zero values and returns the values specified depending on if the
        // conditions are true or false. The return is then passed back to
        // the caller.
        static long GCD(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
    }
}