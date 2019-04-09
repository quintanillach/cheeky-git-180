/* C# Program to find the Fibonacci Numbers for a series of n numbers
 * Source: W3Resource
 * Source Author: 
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-10.php
 * Date Accessed: 04/05/2019
 */

using System;

namespace Recursions
{
	class FibonacciSequence
	{
	    	public static int FindFibonacci(int n)
	    	{
			int p = 0;
			int q = 1;
			// This for loop iterates the integer variables above and
			// assigns the value 'p' to a temporary variable, assigns the value of q
			// to the 'p' variable, and then adds q and and the previous value of p
			// which is now the value of 'temp' and assigns the sum back to 'q'.
			// The loop iterates as many times as the user requested until it i = n
			// and the loop is broken. Through each iteration, the method prints the
			// value of p and the recursion continues.
			// Refactored the for loop with the addition assignment (+=) operator
			// for concision
			for (int i = 0; i < n; i++)
			{
		    		int temp = p;
		    		p = q;
		    		q += temp;
			}
			return p;
	    	}

	    	static void Main()
	    	{
			Console.WriteLine("\n\n Recursion : Find the Fibonacci numbers for a n numbers of series :");
			Console.WriteLine("-----------------------------------------------------------------------");

			// This Main() method calls the FindFibonacci() method and passes the returned value for as
			// many times as user indicates.
			// Refactored this segment using string interpolation for readability without sacrificing function
			Console.Write(" Input number of terms for the Fibonacci series : ");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write($"\n The Fibonacci series of {n1} terms is : ");
		    	for (int i = 0; i < n1; i++)
			{
			    Console.Write($"{FindFibonacci(i)} ");
			}
			Console.ReadKey();
		}
	}
}
