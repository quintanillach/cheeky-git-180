/*
 * C# program to print the largest contiguous array sum using Kadane's algorithm
 * Source: Geeks for Geeks
 * Source Author: anuj_67
 * Source URL: https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
 * Date Accessed: 04/30/2019
 */

using System;

// Added namespace
// Added public access modifiers
// Implements string interpolation
// Renamed variables for clarity
namespace DataStructures
{
    public class KadaneAlgorithm
    {
        public static void MaxSubArray(int[] a, int size)
        {
            int max_so_far = int.MinValue,
            max_ending_here = 0, startIndex = 0,
            endIndex = 0, tempIndex = 0;

            for (int i = 0; i < size; i++)
            {
                // The maximum ending variable is assigned a value
                // equal to the comparative index in the array passed by Main
                max_ending_here += a[i];

                // The if statement compares the value of the sums
                // during the loops iterations and assigns the value
                // of the current maximum ending to the max_so_far
                // if the previous value was less than the max_ending_here variable
                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    startIndex = tempIndex;
                    endIndex = i;
                }

                // Sets the max_ending_here back to 0 if a negative value
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    tempIndex = i + 1;
                }
            }

            // Prints the indeces for the final value of the max_so_far
            // after the loop is broken
            Console.WriteLine($"\n\nMaximum contiguous sum is {max_so_far}");
            Console.WriteLine($"Starting index {startIndex}");
            Console.WriteLine($"Ending index {endIndex}");
        }

        public static void Main()
        {
            // Added title block
            Console.WriteLine(" --------------------------------------------------------------");
            Console.WriteLine(" Find the largest sum of a contiguous subarray within an array");
            Console.WriteLine(" --------------------------------------------------------------\n");

            // Added user input
            Console.WriteLine(" How many elements in the array?");
            string _numberElements = (Console.ReadLine());
            int.TryParse(_numberElements, out int numberElements);
            int[] arr = new int[numberElements];

            Console.WriteLine(" Enter the array elements : ");
            int i;
            // The for loop adds elements to the array
            for (i = 0; i < arr.Length; i++)
            {
                string s = (Console.ReadLine());
                int.TryParse(s, out int element);
                arr[i] = element;
            }

            Console.WriteLine("\n\nFinal array : ");

            // Print the space-separated final array for visualization
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
            int size = arr.Length;
            
            // Pass the arguments to the MaxSubArray method
            MaxSubArray(arr, size);
        }
    }
}
