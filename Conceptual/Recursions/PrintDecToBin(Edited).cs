/*
 * C# Program to Print Binary Equivalent of an Integer using Recursion
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-print-binary-value/
 * Date Accessed: 04/04/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursions
{
    public class PrintDecToBin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Convert a Decimal Number to Binary");
            Console.WriteLine("--------------------------------------\n");
            // The ConversionTool class is instantiated
            ConversionTool binaryResult = new ConversionTool();

            // The user inputs a decimal number type as a string
            // which the program attempts to parse into an integer
            // Declared input to string for TryParse protection against
            // invalid input
            Console.WriteLine("Enter a decimal number: ");
            string _decimalNumber = (Console.ReadLine());
            int.TryParse(_decimalNumber, out int decimalNumber);

            // The input is then passed as a reference to the
            // Binary Conversion method in the Conversion Tool class
            // and the return is printed to the console
            Console.WriteLine("The binary equivalent of num is :");
            binaryResult.BinaryConversion(decimalNumber);

            Console.ReadLine();
        }
    }

    public class ConversionTool
    {
        public int BinaryConversion(int num)
        {
            int binaryNumber;

            // This if-else statement checks is the number is zero
            // and takes the remainder of the given number divided by 2
            // then uses recursion to print all valid binary digits
            if (num != 0)
            {
                binaryNumber = (num % 2) + 10 * BinaryConversion(num / 2);
                Console.Write(binaryNumber);
                return 0;
            }
            else
            {
                return 0;
            }

        }
    }
}
