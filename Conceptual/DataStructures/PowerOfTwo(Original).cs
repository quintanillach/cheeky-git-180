/*
 * C# Program to check is a number is a power of two
 * Source: Geeks for Geeks
 * Source Author: Sam007
 * Source URL: https://www.geeksforgeeks.org/csharp-program-to-find-whether-a-no-is-power-of-two/
 * Date Accessed: 05/04/2019
 */

using System; 
  
class GFG { 
    // Method to check if x is power of 2 
    static bool isPowerOfTwo(int x) 
    { 
        // First x in the below expression 
        // is for the case when x is 0 
        return x != 0 && ((x & (x - 1)) == 0); 
    } 
  
    // Driver method 
    public static void Main() 
    { 
        Console.WriteLine(isPowerOfTwo(31) ? "Yes" : "No"); 
        Console.WriteLine(isPowerOfTwo(64) ? "Yes" : "No"); 
    } 
} 