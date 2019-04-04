/*
 * C# Program to Print Binary Equivalent of an Integer using Recursion
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-print-binary-value/
 * Date Accessed: 04/04/2019
 */
using System;                                                             //Import System namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program                                                             //class
{
    public static void Main(string[] args)                                //Main method 
    {     
        int num;                                                          //Declare 'num' integer
        prog pg = new prog();                                             //Invoke 'prog' method
        Console.WriteLine("Enter a decimal number: ");                    //Display request for user to input a decimal number
        num = int.Parse(Console.ReadLine());                              //Convert user input from string to integer and assign to 'num'
        Console.WriteLine("The binary equivalent of num is :");           //Output the conversion from decimal form to binary form
        pg.binaryconversion(num);                                         //
        Console.ReadLine();                                               //Wait for user to press button to close the program
    }
}
public class prog
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
