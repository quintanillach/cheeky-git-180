/*
 * Purpose: C# Program to Read a String and find the Sum of all Digits in the String
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-progam-string-sum-digits/
 * Date Accessed: 03/31/2019
 */

using System;                                                                                   //Import System namespace

class program                                                                                   //Generic program name
{
    public static void Main()                                                                   //Main() method
    {
        char[] string1 = new char[20];                                                          //New  Char array 'string1'
        int count, nc = 0, sum = 0, n, i;                                                       //Declare multiple ints on the same line
        Console.WriteLine("Enter the Length of the sentence  :");                               //Display request for user input
        n = int.Parse(Console.ReadLine());                                                      //Convert user input from string to int
        Console.WriteLine("Enter the string1 containing both digits and alphabet :");           //Display request for string1 input
        for (i = 0; i < n; i++)                                                                 //for loop
        {
            string1[i] = Convert.ToChar(Console.Read());                                        //
        }
 
        for (count = 0; string1[count] != '\0'; count++)
        {
            if ((string1[count] >= '0') && (string1[count] <= '9'))
            {
                nc += 1;
                sum += (string1[count] - '0');
            }
        }
        Console.WriteLine("NO. of Digits in the string1 = {0}", nc);
        Console.WriteLine("Sum of all digits = {0}", sum);
        Console.ReadLine();
        Console.ReadLine();
    }
}
