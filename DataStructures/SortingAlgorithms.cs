using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Module2
{
    public class SortingAlgorithms
    {
        public static void BubbleReverseSort(string[] arr)  // Overall Time Complexity: O(n^2)
        {
            long bubbleComparisons = 0;

            // Temporary string is used for swapping elements
            string temp;
            int i, j;

            // Boolean variable prevents algorithm from iterating through entire inner
            // loop if elements are already sorted
            bool elementSwapped;

            // Outer for loop iterates through the array
            for (i = 0; i < arr.Length - 1; i++)    // O(n)
            {
                elementSwapped = false;

                // Iterate through the array excluding already sorted elements
                for (j = 0; j < arr.Length - i - 1; j++)    // O(n)
                {
                    // Compare current string element with next element
                    // Swap when comparison indicates current element 
                    // precedes the next element alphabetically
                    if (arr[j].ToLower().CompareTo(arr[j + 1].ToLower()) < 0)   // O(1)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        // When elements are swapped return true
                        elementSwapped = true;
                    }

                    // Increment the variable counting the number of
                    // comparisons in the algorithm
                    bubbleComparisons++;
                }

                // When no elements are swapped the array is sorted
                if (elementSwapped == false)    // O(1)
                {
                    break;
                }
            }

            // Print final comparison count
            Console.WriteLine($"Bubble Sort Comparisons : {bubbleComparisons}");
        }

        public static void SelectionReverseSort(string[] arr)   // Overall Time Complexity: O(n^2)
        {
            // Local variable to count the number of comparisons
            long selectionComparisons = 0;

            // Minimum index tracks the index of the smallest
            // element in the current iteration
            int minIndex, i, j;
            string temp;

            // Outer loop iterates through the array
            for (i = 0; i < arr.Length; i++)    // O(n)
            {
                minIndex = i;

                // Inner loop also iterates through the array
                for (j = i; j < arr.Length; j++) // O(n)
                {
                    // Compare strings and indicate whether the comparison string
                    // is smaller than the current smallest element, if so swap indeces
                    if (arr[j].CompareTo(arr[minIndex]) > 0) // O(1)
                    {
                        minIndex = j;
                    }

                    // Increment the variable counting the number of
                    // comparisons in the algorithm
                    selectionComparisons++;
                }

                // Swap the smallest element from the iteration to the next vacant index
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            // Print final comparison count
            Console.WriteLine($"Selection Sort Comparisons : {selectionComparisons}");
        }

        public static void MergeReverseSort(string[] arr) // Overall Time Complexity: O(1)
        {
            // Temporary array holds strings during sorting process
            string[] temp = new string[arr.Length];

            // First method call to MergeHelper
            MergeHelper(arr, temp, 0, arr.Length - 1);  // O(1)
        }

        public static void MergeHelper(string[] arr, string[] temp, int start, int end) // Overall Time Complexity: O(n log n)
        {
            if (start < end)    // O(1)
            {
                // Establish a mid-point in the array for reference
                int mid = (start + end) / 2;

                // Recursively call the MergeHelper method with split array
                MergeHelper(arr, temp, start, mid); // O(n log n)
                MergeHelper(arr, temp, mid + 1, end);   // O(n log n)

                // Call the EndMerge method to join the sorted array divisions
                EndMerge(arr, temp, start, mid + 1, end);   // O(n)
            }
        }

        public static void EndMerge(string[] arr, string[] temp, int start, int mid, int end)   // Overall Time Complexity: O(n)
        {
            // Local variable to count number of comparisons made
            long mergeComparisons = 0;

            // Set local variables equal to parameters for terseness and readability
            int i = start,
                j = mid,
                k = start;

            // While loop executes until either array is fully iterated
            while (i < mid && j <= end) // O(n)
            {
                // The strings are compared to determine sequential order and
                // the higher string is copied to the temporary array
                if ((arr[i].CompareTo(arr[j])) > 0) // O(1)
                {
                    temp[k] = arr[i];

                    // Increment the temporary array and the 'i' indexer
                    k++;
                    i++;
                }

                // Otherwise copy from the second array to the temporary array
                else   // O(1)
                {
                    temp[k] = arr[j];

                    // Increment the temporary array and the 'j' indexer
                    k++;
                    j++;
                }

                // Increment the count of comparisons in the algorithm
                mergeComparisons++;
            }

            // If the first array has not been fully copied, complete
            // the replication
            while (i < mid) // O(n)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }

            // If the second array has not been fully copied, complete
            // the replication
            while (j < end + 1) // O(n)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            // Copy the sorted elements from the temporary array to the original array
            for (i = start; i <= end; i++)  // O(n)
            {
                arr[i] = temp[i];
            }

            // Print the final count of comparisons when the original array is filled
            if (end == arr.Length - 1)  // O(1)
            {
                Console.WriteLine($"Merge Sort Comparisons : {mergeComparisons}");
            }
        }

        public static void QuickSortReverse(string[] arr)
        {
            // Initial method call for helper method
            QuickSortHelper(arr, 0, arr.Length - 1, out long totalComparisons);

            Console.WriteLine($"Quick Sort Comparisons : {totalComparisons}");
        }


        public static void QuickSortHelper(string[] arr, int first, int last, out long totalComparisons)   // Overall time complexity: O(n log n)
        {
            long comparisons, quickComparisons = 0;
            if (first < last) // O(1)
            {
                // Establish the pivot point for sorting reference
                int pivot = Partitioning(arr, first, last, out comparisons);
                quickComparisons += comparisons;
                // Recursively call helper method with array partitions 
                QuickSortHelper(arr, first, pivot - 1, out totalComparisons); // O(n log n)
                quickComparisons += totalComparisons;
                QuickSortHelper(arr, pivot + 1, last, out totalComparisons);  // O(n log n)
                quickComparisons += totalComparisons;
            }

            // Reset the total comparisons before each call
            totalComparisons = 0;

            // Add the number of comparisons from the current call
            totalComparisons += quickComparisons;

        }

        // Method returns index of new pivot position
        public static int Partitioning(string[] arr, int first, int last, out long comparisons)   // Overall time complexity: O(n)
        {
            comparisons = 0;
            // Set the value of the pivot string equal to the last element for first iteration
            string temp,
                    pivot = arr[last];

            // lessIndex variable tracks the elements smaller than the pivot point
            int lessIndex = first - 1;

            // Set first element to begin iteration and continue until reaching pivot
            for (int j = first; j < last; j++)  // O(n)
            {
                // Compare current string to pivot string and move all elements
                // smaller than the pivot to the left of the lessIndex
                if (arr[j].CompareTo(pivot) > 0)   // O(1)
                {
                    lessIndex++;
                    temp = arr[j];
                    arr[j] = arr[lessIndex];
                    arr[lessIndex] = temp;
                    comparisons++;
                }
            }

            // Move the element after the last sorted element and
            // assign to the pivot variable
            arr[last] = arr[lessIndex + 1];
            arr[lessIndex + 1] = pivot;

            // Return new pivot point to caller
            return lessIndex + 1;
        }

        // Print all array elements to separate lines in a new file
        public static void PrintArray(string[] arr, string newFilePath)
        {
            File.WriteAllLines($"{newFilePath}.txt", arr, Encoding.UTF8);
        }

        public static void Main()   // Overall time complexity: O(1)
        {
            string filePath = "input.txt";

            // Initialize array to store each line in source file
            // as an array element
            string[] words = File.ReadAllLines(filePath);

            // Create four shallow clones of the initial array
            // for each sorting method to manipulate
            string[] bubbleArray = (string[])words.Clone();
            string[] selectionArray = (string[])words.Clone();
            string[] mergeArray = (string[])words.Clone();
            string[] quickArray = (string[])words.Clone();

            // Call each sorting method and pass the relevant clones
            // as arguments
            BubbleReverseSort(bubbleArray);
            SelectionReverseSort(selectionArray);
            MergeReverseSort(mergeArray);
            QuickSortReverse(quickArray);

            // Finally, print the results of each array
            // and save to separate files
            PrintArray(bubbleArray, "BubbleArray.txt");
            PrintArray(selectionArray, "SelectionArray.txt");
            PrintArray(mergeArray, "MergeArray.txt");
            PrintArray(quickArray, "QuickArray.txt");
        }
    }
}