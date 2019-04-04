/* Purpose: C# program to display the abbreviation of a text
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-display-abbreviation-text/
 * Date Accessed: 03/31/2019
 */

using System;                                                           //Imports System namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayAbbreviation                                           //Establishes DisplayAbbreviation namespace
{
    class abbreviation
    {
        string str;                                                     //Declares the 'str' field to enable all methods to use the field and prevent redundancy

        public void ReadData()                                          //Create 'ReadData()' method
        {
            Console.WriteLine("Enter a String : ");                     //Display request for user input for a string of text to abbreviate
            str = Console.In.ReadLine();                                //Assign value to 'str' field based on user input
        }

        public void abbre()                                             //Create the 'abbre()' method
        {
            char[] c, result;                                           //Declare the char and result arrays on the same line
            int j = 0;                                                  //Declare int j and assign an initial value of 0
            c = new char[str.Length];                                   //Instantiate new char array and use built-in property to retreive total number of elements from the string 'str'
            result = new char[str.Length];                              //Instantiate new char array and use built-in property to retreive total number of elements from the string 'str'
            c = str.ToCharArray();                                      //Uses built-in method to copy characters in this instance of the string 'str' to an array of Unicode characters
            result[j++] = (char)((int)c[0] ^ 32);                       //Adds character to result[] 
            result[j++] = '.';                                          //Appends 

            for (int i = 0; i < str.Length -1; i++)                     //
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')        //if the character in c[] is a space, tab, or break
                {
                    int k = (int)c[i + 1] ^ 32;                         //Declare int 'k' and set value to int c[+1]
                    result[j++] = (char)k;                              //Add character as element in result[]
                    result[j++] = '.';                                  //Add '.' between characters
                }
            }
            Console.Write("The Abbreviation for {0} is ", str);         //Display the initial string from user input
            Console.WriteLine(result);                                  //Display the result[]
            Console.ReadLine();                                         //Wait for the user to press a button before closing
        }

        public static void Main()                                       //Main method
        {
            abbreviation obj = new abbreviation();                      //Create a static constructor to instantiate an object from our class
            obj.ReadData();                                             //Invoke ReadData Method
            obj.abbre();                                                //Invoke abbre Method
        }
    }
}
