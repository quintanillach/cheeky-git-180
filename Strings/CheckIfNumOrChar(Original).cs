/*
 * C# program to check the whether the character is number or character
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/c-sharp-string-properties/
 * Date Accessed: 04/26/2019
 */

using System; 
class Geeks { 
	
	// Main Method 
	public static void Main() 
	{ 
		string str = "11Gee45for78geeks"; 

		for (int i = 0; i < str.Length; i++) 
		{ 
			if (Char.IsDigit(str[i])) 
				Console.WriteLine("{0} is a Number.", str[i]); 
			else
				Console.WriteLine("{0} is a character.", str[i]); 
		} 
	} 
} 