/*
 * C# program to shuffle elements in an array
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/shuffle-a-given-array-using-fisher-yates-shuffle-algorithm/
 * Date Accessed: 04/30/2019
 */

using System;

// Added namespace
namespace DataStructures
{
    // Added public access modifiers for testing
    public class ShuffleArray
    {
        public static void Randomize(int[] arr, int arrayLength)
        {
            // The System.Random class constructor is called and a
            // random number generator is instantiated to
            // produce a random number
            Random randomNumber = new Random();

            for (int i = arrayLength - 1; i > 0; i--)
            {
                // The j variable matches the index in a new
                // array and the Next method generates a random
                // value within the specified range.
                int j = randomNumber.Next(0, i + 1);

                // This sequence of expressions uses a temporary
                // variable to swap the values of the indexes
                // within the array
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            // This for loop prints the array elements space-separated
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Main()
        {
            // Added title block
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine(" Shuffle the elements within a given array");
            Console.WriteLine(" -------------------------------------------\n");

            // Added user input
            Console.WriteLine(" How many elements in the array?");
            string _numberElements = (Console.ReadLine());
            int.TryParse(_numberElements, out int numberElements);
            int[] arr = new int[numberElements];

            Console.WriteLine(" Enter the array elements : ");

            // The for loop adds elements to the array
            for (int i = 0; i < arr.Length; i++)
            {
                string s = (Console.ReadLine());
                int.TryParse(s, out int element);
                arr[i] = element;
            }
            int n = arr.Length;

            // The Randomize method is called and the arguments are passed
            Randomize(arr, n);
        }
    }
}
