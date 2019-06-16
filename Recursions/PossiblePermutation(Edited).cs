/*
 * C# Program to Print Possible Permutations
 * Source Author: W3Resource
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-11.php
 * Date Accessed: 04/24/2019
 */

using System;

namespace Recursion
{
    public class FormPermutation
    {
        // The SwapNumbers method uses the ref keyword
        // to assign the value of int a to to temp, the value of
        // b to a, and the value of temp (originally a) back to b
        public void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // The PrintPermutation method accepts three parameters
        public void PrintPermutation(int[] list, int k, int m)
        {
            // The if statement checks if the number of elements in the array
            // parameter is equal to int k
            // and prints the elements in the array
            if (k == m)
            {
                for (int i = 0; i <= m; i++)
                {
                    Console.Write($"{list[i]}");
                }
                Console.Write(" ");
            }

            // The else statement executes in all other cases
            // and calls the SwapNumbers method to perform
            // permutation operations within the array and passes parameters
            // back to the outer PrintPermutation method (the recursion)
            else
            {
                for (int i = k; i <= m; i++)
                {
                    SwapNumbers(ref list[k], ref list[i]);
                    PrintPermutation(list, k + 1, m);
                    SwapNumbers(ref list[k], ref list[i]);
                }
            }
        }
    }
    public class PossiblePermutations
    {
        public static void Main()
        {
            // The FormPermutation default constructor is  called
            // and the class object is instantiated
            FormPermutation test = new FormPermutation();

            // The arr1 array is declared and instantiated with a capacity of 5 elements
            int[] arr1 = new int[5];

            Console.WriteLine(" ------------------------------------------------------------------");
            Console.WriteLine(" Recursion : Generate all possible permutations of an array :");
            Console.WriteLine(" ------------------------------------------------------------------");

            // Refactored 'n' as a string to implement
            // TryParse for protection against invalid input
            Console.Write(" Input the number of elements to store in the array [maximum 5 digits ] :");
            string n = (Console.ReadLine());
            int.TryParse(n, out int arrayElements);

            if (arrayElements <= 5)
            {
                Console.Write($" Input {arrayElements} elements in the array :\n");

                // The for loop iterates through the array and displays a request
                // for the user input the digits for Permutation
                for (int i = 0; i < arrayElements; i++)
                {
                    Console.Write($" Element - {i} : ");
                    // Refactored using TryParse for protection from unexpected input
                    string _element = (Console.ReadLine());
                    int.TryParse(_element, out int element);
                    arr1[i] = element;
                }

                Console.WriteLine($"\n The Permutations with a combination of {arrayElements} digits are : ");
                test.PrintPermutation(arr1, 0, arrayElements - 1);
                Console.Write("\n\n");
            }

            else
            {
                Console.WriteLine("Too many elements");
            }

            Console.ReadLine();
        }
    }
}