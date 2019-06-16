/*
 * C# program demonstrating data type concatenation
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-data-types/problem
 * Date Accessed: 04/05/2019
 */

using System;
using System.Collections.Generic;
using System.IO;

// Added namespace
namespace ChallengePrograms
{
	// Added public access modifiers throughout program
	// for testing purposes
	public class Solution 
	{
		public static void Main(String[] args) 
		{
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Challenge program to concatenate data types");
			Console.WriteLine("--------------------------------------------\n");
			
			// These were the given input variables from HackerRank
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";
			
			// Declared variables for concatenation				
			// User input as string and TryParse
			// to convert string to numeric data types
			Console.WriteLine("Enter a number (integer) : ");
			string J = (Console.ReadLine());
			int.TryParse(J, out int j);
			
			Console.WriteLine("Enter a number (double) : ");
			string E = (Console.ReadLine());
			double.TryParse(E, out double e);
			
			Console.WriteLine("Enter a string : ");
			string t = Console.ReadLine();
			
			// Expressions to concatenate user input with
			// given variables
			int sumInts = i + j;
			Console.WriteLine($"\n{sumInts}");

			double sumDoubles = d + e;
			// The result of the double concatenated
			// and converted back to string and
			Console.WriteLine($"{sumDoubles:F1}");

			string sumStrings = s + t;
			Console.WriteLine(sumStrings);

		}
	}
}
