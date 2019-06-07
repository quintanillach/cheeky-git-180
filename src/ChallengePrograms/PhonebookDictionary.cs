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
        public static void Main(String[] args)
        {
            // Title block
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Challenge program to create phonebook and query the collection");
            Console.WriteLine("---------------------------------------------------------------\n");

            // Read user input and convert to integer
            // for number of entries in phonebook
            Console.WriteLine("How many entries are you adding?");
            string entries = (Console.ReadLine());
            int.TryParse(entries, out int numberOfEntries);

            // An empty collection of key-value pairs is
            // instantiated through the IDictionary interface
            IDictionary<string, string> phoneBook = new Dictionary<string, string>();

            // Try catch block to catch exceptions from invalid
            // phonebook entries
            try
            {
                Console.WriteLine("Define the entry pairs (e.g. firstnameonly 0005555555)");

                for (int i = 0; i < numberOfEntries; i++)
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
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message} -- The entry was invalid.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
	    }
		
		// Ask the user if they would like to query
	    Console.WriteLine("Would you like to query your collection? (Y|N)");
	    string queryInput = (Console.ReadLine().ToLower());
	    bool queryCollection = false;
	    string name;
		
            if (queryInput == "y")
            {
		    // Set the queryCollection to true for the do-while loop
		queryCollection = true;
		    
                do
                {
                    name = (Console.ReadLine());
			
			// User input is checked againt the collection
			// and prints the key-value pair if the name is found
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}={phoneBook[name]}");
                    }
                    else
                    {
			    // Loop is broken if name is not found
                        Console.WriteLine("Not found");
                        queryCollection = false;
                    }
                }

                while ((queryCollection == true) && (name != null));

                Console.ReadLine();
            }
            
            else
            {
		    // Terminate the program if not querying the collection
                Console.ReadLine();
            }
        }
    }
}
