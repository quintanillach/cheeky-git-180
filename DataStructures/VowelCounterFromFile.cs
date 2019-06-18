using System;
using System.IO;

namespace Module1
{
    public class InputVowelCounter
    {
		// Method accepts the text file as string as parameter and returns
		// two integers for the total number of vowels counted
        public static void CountVowels(string s, out int upperCase, out int lowerCase)
        {
            upperCase = 0;
            lowerCase = 0;
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        lowerCase++;
                        break;
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        upperCase++;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
			// The file path is written to a string
            string path = @"C:\temp\myTest.txt";
			
			// If statement checks if file exists in directory
            if (!File.Exists(path))
            {
                // Creates a file if none exists
                StreamWriter sw = File.CreateText(path);
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
            }

            // Otherwise open the file and save text to local string
            StreamReader sr = File.OpenText(path);
            string s;
            int upperCase = 0, lowerCase = 0;
			
			// As long as the file input is not null
			// Pass the text as argument for the CountVowels() method
            while ((s = sr.ReadLine()) != null)
            {
                CountVowels(s, out upperCase, out lowerCase);
            }
			
			// Print the count of upper and lower variables
            Console.WriteLine($"Upper Case Vowels in File : {upperCase}");
            Console.WriteLine($"Lower Case Vowels in File : {lowerCase}");
        }
	}
}