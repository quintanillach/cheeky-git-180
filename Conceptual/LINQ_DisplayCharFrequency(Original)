/* C# Program to display the characters and the frequencies in a given string
 * Source: W3Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/linq/csharp-linq-exercise-5.php
 * Date Accessed: 04/07/2019
 */

using System;
using System.Linq;
using System.Collections.Generic;
 
class LinqExercise5
{
    static void Main(string[] args)
    {
      string str; 

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : "); 
            Console.Write("\n----------------------------------------------------------------------------\n");	
            Console.Write("Input the string : ");
            str= Console.ReadLine();
            Console.Write("\n");
        
            var FreQ = from x in str  
                    group x by x into y  
                    select y;  
                Console.Write("The frequency of the characters are :\n");
                foreach(var ArrEle in FreQ)  
                    {  
                    Console.WriteLine("Character "+ArrEle.Key + ": " + ArrEle.Count()+" times");  
                    }  
    }
}
