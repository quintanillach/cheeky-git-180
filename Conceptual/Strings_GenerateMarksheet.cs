/* Purpose: C# program to generate a marksheet for a student
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-generate-student-marksheet
 * Date Accessed: 03/30/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                                                  //Imports System namespace

namespace GenerateMarksheet                                         //Create GenerateMarksheet namespace
{
    class Program
    {
        static void Main(string[] args)                             //Main method
        {
            int r, m1, m2, m3, t;                                   //Declare multiples integer variables
            float p;                                                //Declare float variable
            string n;                                               //Declare string n

            Console.WriteLine("Enter Roll Number : ");              //Display request for student Roll number
            r = Convert.ToInt32(Console.ReadLine());                //Convert user input to integer and save to int 'r'

            Console.WriteLine("Enter Student Name : ");             //Display request for student name
            n = Console.ReadLine();                                 //Save user input to string 'n'

            Console.WriteLine("Mark of Subject1 : ");               //Display request for first subject mark
            m1 = Convert.ToInt32(Console.ReadLine());               //Convert user input to integer and save to int 'm1'

            Console.WriteLine("Mark of Subject2 : ");               //Display request for second subject mark
            m2 = Convert.ToInt32(Console.ReadLine());               //Convert user input to integer and save to int 'm2'

            Console.WriteLine(" Mark of Subject3 : ");              //Display request for third subject mark
            m3 = Convert.ToInt32(Console.ReadLine());               //Convert user input to integer and save to int 'm3'

            t = m1 + m2 + m3;                                       //Sum the three marks and save to int 't'
            p = t / 3.0f;                                           //Average the three marks and implicit conversion to float p for precision
            Console.WriteLine("Total : ", +t);                      //Display int 't' as the total
            Console.WriteLine("Percentage : ", +p);                 //Display float 'p' as the percentage

            if (p >= 35 && p < 50)                                  //if statements to determine grades based on percentages 
            {
                Console.WriteLine("Grade is C");                    //Display Grade is C for 35 to 49 percent
            }

            if (p >= 50 && p < 60)
            {
                Console.WriteLine("Grade is B");                    //Display Grade is B for 50 to 59 percent
            }

            if (p >= 60 && p < 80)
            {
                Console.WriteLine("Grade is A");                    //Display Grade is A for 60 to 79 percent
            }

            if (p >= 80 && p <= 100)
            {
                Console.WriteLine("Grade is A+");                   //Display Grade is A+ for 80 to 100 percent
            }
            Console.ReadLine();                                     //Wait for user to close program
        }
    }
}
