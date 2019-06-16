/*
 * C# program to implement Bubble Sort algorithm on an array
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/bubble-sort/
 * Date Accessed: 04/11/2019
 */

using System;


// Added namespace
// Renamed class and methods for clarity
// Added public access modifier for testing
namespace Sorting
{
    public class BubbleSort
    {
        public static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            // The outer for loop iterates through the current element
            // being referenced
            for (int i = 0; i < n - 1; i++)
            {
                // The inner for loop compares it to the previous element
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the value of the elements if the conditions
                        // are met using a temporary variable
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;

            // Print space-separated elements in the given array
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            // Added title block
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("C# Program to sort an array of numbers using BubbleSort");
            Console.WriteLine("--------------------------------------------------------\n");

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array : ");
            PrintArray(arr);
            BubbleSortAlgorithm(arr);
            Console.WriteLine("\nSorted array : ");
            PrintArray(arr);
        }
    }
}
