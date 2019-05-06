/*
 * C# solution to the apples and oranges problem
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/apple-and-orange/problem
 * Date Accessed: 05/06/2019
 */

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ChallengePrograms
{
	public class Solution {

		public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) 
		{
			// Declare two new variables to hold
			// the number of apples and oranges that land
			// on Sam's House
			int applesOnHouse = 0, orangesOnHouse = 0;
			
			// For loop iterates through the apples array
			// and checks if the initial position plus
			// the distance from the tree is equal
			// to the position of the house
			for (int i = 0; i < apples.Length; i++)
			{
				if(((apples[i] + a) >= s) &&
					((apples[i] + a) <= t))
				{
					applesOnHouse++;
				}
			}
			
			// Same purpose as previous for loop
			// but for oranges
			for (int i = 0; i < oranges.Length; i++)
			{
				if(((oranges[i] + b) >= s) &&
					((oranges[i] + b) <= t))
				{
					orangesOnHouse++;
				}
			}
			
			// Print the final value of fruit to hit Sam's house
			Console.WriteLine(applesOnHouse);
			Console.WriteLine(orangesOnHouse);
		}

		public static void Main(string[] args) 
		{
			// Split the input string into an array
			// and assign value to local variables
			string[] st = Console.ReadLine().Split(' ');
			int s = Convert.ToInt32(st[0]);
			int t = Convert.ToInt32(st[1]);

			string[] ab = Console.ReadLine().Split(' ');
			int a = Convert.ToInt32(ab[0]);
			int b = Convert.ToInt32(ab[1]);

			string[] mn = Console.ReadLine().Split(' ');
			int m = Convert.ToInt32(mn[0]);
			int n = Convert.ToInt32(mn[1]);
			
			// Converts the entire line of input into
			// separate array elements and converts to integers
			int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

			int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
			
			// Pass all inputs to CountApplesAndOranges method
			CountApplesAndOranges(s, t, a, b, apples, oranges);
		}
	}
}