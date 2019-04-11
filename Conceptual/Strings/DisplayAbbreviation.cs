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

// Renamed the namespace, class, and methods using Pascal case per .NET conventions
namespace Strings
{
    // Added the public access modifier for consistency
   public class DisplayAbbreviation
    {
        // Here the field 'str' is declared to allow all methods to access
        // one variable rather than create separate instances. The original
        // code did not use an access modifier on the field. I added the
        // private access modifier to transform it into a backing field
        // and prevent external sources from corrupting the program. I 
        // added the property Str to get and set the field.
        private string str;

        public string Str { get => str; set => str = value; }

        public void ReadData()
        {
            // The ReadData() method simply requests the user to input
            // a string to abbreviate and assigns the value to the
            // 'Str' property
            Console.WriteLine("Enter a String : ");
            Str = Console.In.ReadLine();
        }

        public void Abbreviate()                                             //Create the 'Abbreviate()' method
        {
            char[] c, result;                                           //Declare the char and result arrays on the same line
            int j = 0;                                                  //Declare int j and assign an initial value of 0
            c = new char[Str.Length];                                   //Instantiate new char array and use built-in property to retreive total number of elements from the string 'str'
            result = new char[Str.Length];                              //Instantiate new char array and use built-in property to retreive total number of elements from the string 'str'
            c = Str.ToCharArray();                                      //Uses built-in method to copy characters in this instance of the string 'str' to an array of Unicode characters
            result[j++] = (char)((int)c[0] ^ 32);                       //Adds character to result[] 
            result[j++] = '.';                                          //Appends 

            for (int i = 0; i < Str.Length -1; i++)                     //
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')        //if the character in c[] is a space, tab, or break
                {
                    int k = (int)c[i + 1] ^ 32;                         //Declare int 'k' and set value to int c[+1]
                    result[j++] = (char)k;                              //Add character as element in result[]
                    result[j++] = '.';                                  //Add '.' between characters
                }
            }
            Console.Write("The Abbreviation for {0} is ", Str);         //Display the initial string from user input
            Console.WriteLine(result);                                  //Display the result[]
            Console.ReadLine();                                         //Wait for the user to press a button before closing
        }

        public static void Main()
        {
            // The Main() method only contains the default constructor
            // which instantiates the class as an object and then
            // passes a copy of the address of the object to
            // the ReadData() and Abbreviate() methods above
            // and saves the data returned to the object itself
            DisplayAbbreviation obj = new DisplayAbbreviation();
            obj.ReadData();
            obj.Abbreviate();
        }
    }
}
