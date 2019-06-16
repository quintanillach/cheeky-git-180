/*
 * C# Program to Print Possible Permutations
 * Source Author: W3Resource
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-11.php
 * Date Accessed: 04/24/2019
 */

using System;

class formPermut
{
   public void swapTwoNumber (ref int a, ref int b)
   {
      int temp = a;
      a = b;
      b = temp;
   }
   public void prnPermut (int []list, int k, int m)
   {
      int i;
      if (k == m)
      { 
         for (i = 0; i <= m; i++)
         Console.Write ("{0}",list [i]);
         Console.Write (" ");
      }
      else
         for (i = k; i <= m; i++)
         {
            swapTwoNumber (ref list [k], ref list [i]);
            prnPermut (list, k+1, m);
            swapTwoNumber (ref list [k], ref list [i]);
         }
   }
}
class RecExercise11
{
   public static void Main()
   {
       int n,i;
      formPermut test = new formPermut();
      int[] arr1 = new int[5];
        
        Console.WriteLine("\n\n Recursion : Generate all possible permutations of an array :");
		Console.WriteLine("------------------------------------------------------------------");      
      
        Console.Write(" Input the number of elements to store in the array [maximum 5 digits ] :");
        n = Convert.ToInt32(Console.ReadLine());    
        Console.Write(" Input {0} number of elements in the array :\n",n);
        for(i=0;i<n;i++)
            {
	        Console.Write(" element - {0} : ",i);
	        arr1[i] = Convert.ToInt32(Console.ReadLine()); 
	        }      

        Console.Write ("\n The Permutations with a combination of {0} digits are : \n",n);
        test.prnPermut(arr1, 0, n-1);
        Console.Write ("\n\n");
   }
}
