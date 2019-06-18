using System;

namespace Module1
{
    public class VowelCounter
    {
        public static void CountVowels(string userInput)
        {
            // Declare int variables to store count from foreach loop
            int upperCase = 0, lowerCase = 0;

            // Treat the string as an array of char type and evaluate 
            // values to check if upper or lower case vowel
            foreach (char letter in userInput)
            {
                switch(letter)
                {
                    // First, check if char is a lowercase vowel
                    // If so, increment lowerCase int
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        lowerCase++;
                        break;
                    // Then, check if char is uppercase vowel
                    // If so, increment upperCase int
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        upperCase++;
                        break;
                    // Otherwise, break from switch block and
                    // continue foreach loop
                    default:
                        break;
                }
            }

            // Print the final values for the respective count to the console
            Console.WriteLine($"\nUpper Case Vowels in String : {upperCase}");
            Console.WriteLine($"Lower Case Vowels in String : {lowerCase}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Count the Vowels in a given string");
            Console.WriteLine("-----------------------------------------------\n");

            // Request user input and save to string
            Console.WriteLine("Enter a string : ");
            string userInput = Console.ReadLine();

            // Invoke the CountVowels() method and pass user string as argument
            CountVowels(userInput);

            Console.Read();
        }
    }
}
