/*
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/selection-sort/
 * Date Accessed: 04/11/2019
 */

using System;

// Implemented namespace
// Renamed methods using Pascal case and access modifiers
namespace Sorting
{
    public class SelectionSort
    {
        // The SortArray receives the parameter array from the caller
        private static void SortArray(int[] arr)
        {
            // The length of the array is assigned to a local variable
            int n = arr.Length;

            // The for loop iterates through the array index 
            for (int i = 0; i < n - 1; i++)
            {
                // The minimum index is established for the Selection Sort algorithm
                int minIndex = i;

                // The nested for loop checks the next element in the index
                // and compares it to the minimum index. If the next value
                // is less than the minimum index, they are swapped
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                // The value of the element at the new minimum index is assigned
                // to a temporary variable
                int temp = arr[minIndex];

                // The minimum index is then assigned to the array at the next
                // iteration and the loop restarts
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // The PrintArray method simply prints each element in the array
        // with a space separation for neatness
        private static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            // Added the printing of the initial array before sorting
            Console.WriteLine("Initial Array : ");
            PrintArray(arr);

            // The array is passed to the SortArray method
            SortArray(arr);

            // The array is re-printed after sorting
            Console.WriteLine("\nSorted array : ");
            PrintArray(arr);
        }

    }
}
