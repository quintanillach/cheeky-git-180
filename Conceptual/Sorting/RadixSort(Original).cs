/*
 * C# Program to Demonstrate Radix Sort
 * Source Author: W3Resource
 * Source URL: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-10.php
 * Date Accessed: 04/24/2019
 */

using System;
 namespace Radix_Sort
{
    class Program
    {
        static void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)   
                        arr[i-j] = arr[i];
                    else                             
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length-j, j);
            }
        }
        static void Main(string[] args)
        {
            
			int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6  };
			Console.WriteLine("\nOriginal array : ");
			foreach (var item in arr)
            {
                Console.Write(" " + item);    
            }

            Sort(arr);
			Console.WriteLine("\nSorted array : ");
			foreach (var item in arr)
            {
                Console.Write(" " + item);    
            }
           Console.WriteLine("\n");
        }
    }
}
