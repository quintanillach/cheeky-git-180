/*
 * C# program demonstrating data type concatenation
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-data-types/problem
 * Date Accessed: 04/05/2019
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengePrograms
{
	public class Solution 
	{
		public static void Main(String[] args) 
		{
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";

			int j = 0 ;
			double e = 0.0;
			string t = " ";

			j = int.Parse(Console.ReadLine());
			e = Convert.ToDouble(Console.ReadLine());
			t = Console.ReadLine();

			int sumInts = i + j;
			Console.WriteLine(sumInts);

			double sumDoubles = d + e;
			Console.WriteLine(sumDoubles.ToString("F1"));

			string sumStrings = s + t;
			Console.WriteLine(sumStrings);

		}
	}
}