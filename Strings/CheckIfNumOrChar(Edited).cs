/*
 * C# program to check the whether the character is number or character
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/c-sharp-string-properties/
 * Date Accessed: 04/26/2019
 */

using System;

// Added custom namespace
namespace Strings
{
    // Added a public access modifier
    public class CheckIfNumOrChar
    {
        public static void Main()
        {
            // Added title block
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Check If String Elements Are Numbers or Characters : ");
            Console.WriteLine("-------------------------------------------------------\n");

            // Added user input for string
            Console.WriteLine("Enter a string : ");
            string str = (Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    Console.WriteLine($"{str[i]} is a number.");
                }
                else
                {
                    Console.WriteLine($"{str[i]} is a character.");
                }
            }
        }
    }
}