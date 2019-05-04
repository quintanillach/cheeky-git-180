/*
 * C# Program to find missing number in an array
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/find-the-missing-number/
 * Date Accessed: 05/04/2019
 */
 
using System; 
  
class GFG 
{ 
    // Function to ind missing number 
    static int getMissingNo (int []a, int n) 
    { 
        int total = (n + 1) * (n + 2) / 2;  
          
        for (int i = 0; i< n; i++) 
        total -= a[i]; 
          
        return total; 
    } 
      
    /* program to test above function */
    public static void Main() 
    { 
        int []a = {1, 2, 4, 5, 6}; 
        int miss = getMissingNo(a, 5); 
        Console.Write(miss);  
    } 
  
} 