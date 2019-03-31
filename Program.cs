using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayAbbreviation
{
    //Function: C# program to display the abbreviation of a text
    class abbreviation
    {
        //Declares the field (variable) 'str' outside of methods
        //By declaring outside of a specific method
        //We enable all methods to use the same field (variable) without having to repeat the code in each method
        string str;

        //Next, we create a the method 'readdata'
        //readdata takes the user input and assigns the value to 'str'
        public void Readdata()
        {
            //Ask for user to input a string of text to abbreviate
            Console.WriteLine("Enter a String : ");

            //Assign value to 'str' based on user input
            str = Console.In.ReadLine();
        }

        public void abbre()
        {
            char[] c, result;
            int j = 0;
            c = new char[str.Length];
            result = new char[str.Length];
            c = str.ToCharArray();
            result[j++] = (char)((int)c[0] ^ 32);
            result[j++] = '.';

            for (int i = 0; i < str.Length -1; i++)
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')
                {
                    int k = (int)c[i + 1] ^ 32;
                    result[j++] = (char)k;
                    result[j++] = '.';
                }
            }
            Console.Write("The Abbreviation for {0} is ", str);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main()
        {
            //Here we create a static constructor to instantiate an object from our class
            abbreviation obj = new abbreviation();

            //Using the instance of 'obj' we just created
            //We invoke our methods above to save data to the object
            obj.Readdata();
            obj.abbre();
        }
    }
    //Source: Sanfoundry
    //URL: https://www.sanfoundry.com/csharp-program-display-abbreviation-text/
    //Date Accessed: 03/31/2019
}
