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
    class PrintDecToBin
    {
        public static void Main(string[] args)
        {
            int num;
            ConversionTool result = new ConversionTool();
            Console.WriteLine("Enter a decimal number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary equivalent of num is :");
            result.binaryconversion(num);
            Console.ReadLine();
        }
    }
    public class ConversionTool
    {
        public int binaryconversion(int num)
        {
            int bin;
            if (num != 0)
            {
                bin = (num % 2) + 10 * binaryconversion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }

        }
    }
}
