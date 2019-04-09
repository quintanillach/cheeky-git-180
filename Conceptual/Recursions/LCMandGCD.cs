/* C# program to find the least common multiplier and the greatest common denominator of a pair of numbers
 * Source: W3Resource
 * Source Author: 
 * Source URL: https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-12.php
 * Date Accessed: 04/05/2019
 */


using System;
using System.Text;
 
class RecExercise12
{        
  public static void Main()
    {
            long num1, num2, hcf, lcm;
            Console.WriteLine("\n\n Recursion : Find the LCM and GCD of two numbers :");
		    Console.WriteLine("------------------------------------------------------");      
      
            Console.Write(" Input the first number : "); 
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write(" Input the second number : "); 
            num2 = Convert.ToInt64(Console.ReadLine());
 
            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;
 
            Console.WriteLine("\n The GCD of {0} and {1} = {2} ", num1, num2, hcf);
            Console.WriteLine(" The LCM of {0} and {1} = {2}\n", num1, num2, lcm);
            
 
     }
 
       static long gcd(long n1, long n2)
       {
           if (n2 == 0)
           {
               return n1;
           }
           else
           {
               return gcd(n2, n1 % n2);
           }
       }
}
