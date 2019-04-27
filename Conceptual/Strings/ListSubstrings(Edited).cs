/*
 * C# Program to List all Substrings in a given String
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-list-all-substring/
 * Date Accessed: 04/26/2019
 */

using System;

// Added custom namespace
namespace Strings
{
    // Added public access modifier
    public class ListSubstrings
    {
        // Changed the fields to backing fields
        // and implemented properties for best practices
        // Added private access modifiers for protection
        // against external access
        private string _fullString, _substring;
        private int JJ, II;

        // The stringArray is declared with capacity of 10
        // to keep display from becoming too large
        string[] stringArray = new string[10];

        // These properties get and set the fields above
        // without allowing full access to data in fields
        public string fullString { get => _fullString; set => this._fullString = value; }
        public string substring { get => _substring; set => _substring = value; }
        public int jj { get => JJ; set => JJ = value; }
        public int ii { get => II; set => II = value; }

        void UserInput()
        {
            // Specified the capacity of the string input
            Console.WriteLine("Enter a string (10 or few characters) : ");

            // Added a try-catch block to handle common exception
            try
            {
                fullString = Console.ReadLine();
                Console.WriteLine("All Possible Substrings of the Given String are :");

                // Outer for loop iterates through the string
                for (ii = 1; ii <= fullString.Length; ii++)
                {
                    // Inner for loop iterates through the array and saves
                    // substrings to index
                    for (jj = 0; jj <= fullString.Length - ii; jj++)
                    {
                        substring = fullString.Substring(jj, ii);
                        stringArray[jj] = substring;
                        Console.WriteLine(stringArray[jj]);
                    }
                }
            }

            // IndexOutOfRangeException is thrown when string exceeds 10 characters
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine (ex.Message);
            }
        }

        public static void Main()
        {
            // Added title block
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("List Possible Substrings for a Given String : ");
            Console.WriteLine("-------------------------------------------------------\n");

            // Default constructor is instantiated and the UserInput
            // method is called
            ListSubstrings subStrings = new ListSubstrings();
            subStrings.UserInput();
            Console.ReadLine();
        }
    }
}