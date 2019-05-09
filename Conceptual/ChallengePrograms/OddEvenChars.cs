/*
 * C# program to print the even and odd characters in a string
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-review-loop/problem
 * Date Accessed: 04/06/2019
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeProblems
{
    public class OddEvenChars
    {
        public static void Main(String[] args)
        {
            // Title block
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Challenge program to print each even and odd character of a given string");
            Console.WriteLine("-------------------------------------------------------------------------\n");

            // User inputs number of test cases
            // Convert from string to int using TryParse
            Console.WriteLine("How many test cases?");
            string testCases = (Console.ReadLine());
            int.TryParse(testCases, out int test);

            // Strings are stored in an array
            string[] strings = new string[test];
            int p = 0;

            // while loop adds user input string to each array index
            while (p < test)
            {
                Console.Write($"String {p} : ");
                strings[p] = (Console.ReadLine());
                p++;
            }

            // Iterate through string array
            foreach (string s in strings)
            {
                string evens = "";
                string odds = "";
                bool isEven = true;

                // Determine odd characters from even in the string
                // by treating the string as an array of characters
                // and assign the value to the local variables
                for (int i = 0; i < s.Length; i++)
                {
                    if (isEven) evens += s[i];
                    else odds += s[i];

                    // Switch even bool to false
                    isEven = !isEven;
                }

                // Print all the characters
                Console.WriteLine($"{evens} {odds}");
            }
        }
    }
}
