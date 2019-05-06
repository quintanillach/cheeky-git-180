/*
 * C# Program to check is a number is a power of two
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
 * Date Accessed: 05/05/2019
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengePrograms
{
	public class PhonebookDictionary 
	{
		static void Main(String[] args) 
		{
			// Read user input and convert to integer
			// for number of entries in phonebook
			string entries = (Console.ReadLine());
			int.TryParse(entries, out int numberOfEntries);
			
			// An empty collection of key-value pairs is
			// instantiated through the IDictionary interface
			IDictionary<string, string> phoneBook = new Dictionary<string, string>();

			for(int i = 0; i < numberOfEntries; i++)
			{
				// The user input is read and split using
				// the Split method given space-separation
				// and assigned to an implicit variable array
				var input = (Console.ReadLine().Split(' '));
				
				// The elements in the array are passed as
				// arguments to the Dictionary and added as a
				// key-value pair
				phoneBook.Add(input[0], input[1]);
			}

			string name;
			
			// The while loop only executes if the user inputs a value
			while((name = Console.ReadLine()) != null)
			{
				// The if else statement checks the user input
				// and searches the Dictionary for a matching Key
				if (phoneBook.ContainsKey(name))
				{
					Console.WriteLine($"{name}={phoneBook[name]}");
				}
				else
				{
					Console.WriteLine("Not found");
				}
			}
		}
	}
}