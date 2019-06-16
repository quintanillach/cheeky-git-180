/* C# program to sort a list of elements using the Shell Sort method
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-1.php
 * Date Accessed: 04/11/2019
 */

using System;
using System.Collections;

namespace Sorting
{
    public class Shell
    {
       public static void Main(string[] args)
        {
            // An array of integers stores the data with no particular order
            // Moved the assignment to the same line as the declaration of int n
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n = arr.Length;

            // The array elements are printed to the console in both
            // the unsorted and the sorted order after passing through
            // the other methods in the class
            Console.WriteLine("Original Array Elements :");
            ShowArrayElements(arr);
            ShellSort(arr, n);
            Console.WriteLine("\nSorted Array Elements :");
            ShowArrayElements(arr);
        }

        // The ShowArrayElements() method accepts the initial array
        // as the only parameter and simply iterates through the array
        // to print each element separated by a space
        public static void ShowArrayElements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }

        // The ShellSort() method accepts the array and the array.Length
        // values as the parameters for use               
        public static void ShellSort(int[] arr, int array_size)
        {
            int i, j, gap, temp;

            // The gap size is a crucial variable in the ShellSort algorithm which
            // is used to determine the spacing between elements in the array to
            // begin comparing values. In this case '3' is a sufficient gap because
            // the array is small
            gap = 3;

            // The while loops evaluates gap for a value greater than zero
            // and executes as long as it is true
            while (gap > 0)
            {
                // The for loop iterates through the index of the array
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    // The value of the element is then assigned to a temporary variable
                    temp = arr[i];

                    // The nested while loop checks if the gap exceeds the index
                    // and compares the initial value of the element in the original index and
                    // compares it to the temporary variable. If the temporary variable is 
                    // less than the original index then the values are swapped
                    while ((j >= gap) && (arr[j - gap] > temp))
                    {
                        arr[j] = arr[j - gap];
                        j = j - gap;
                    }
                    arr[j] = temp;
                }
                
                // This if else statement does a check after each iteration of the algorithm
                // and breaks the while loop when the gap becomes too small
                if (gap / 2 != 0)
                {
                    gap = gap / 2;
                }
                else if (gap == 1)
                {
                    gap = 0;
                }
                else
                {
                    gap = 1;
                }
            }

        }
    }
}
