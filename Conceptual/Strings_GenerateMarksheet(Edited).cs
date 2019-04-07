/* Purpose: C# program to generate a marksheet for a student
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-generate-student-marksheet
 * Date Accessed: 03/30/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Renamed namespace to conform to my naming convention for Github repo
namespace Strings
{
    // Renamed program from Program to GenerateMarksheet
    class GenerateMarksheet
    {
        static void Main(string[] args)
        {
            // The program immediately declares multiple variables based on the
            // predicted number of subjects and then requests the user to input
            // values to assign to each of these variables.
            int r, m1, m2, m3, t;
            float p;
            string n;

            Console.WriteLine("Enter Roll Number : ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name : ");
            n = Console.ReadLine();

            Console.WriteLine("Mark of Subject1 : ");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mark of Subject2 : ");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Mark of Subject3 : ");
            m3 = Convert.ToInt32(Console.ReadLine());

            // Based on the user input, the variables are then summed up
            // to int 't' and averaged out for a percentage. The total is
            // converted from a integer to a float for precision since integers
            // do not necessarily divide into round integers. The program
            // prints these values before moving on the next segment.
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine("Total : ", +t);
            Console.WriteLine("Percentage : ", +p);

            // Changed the if functions to else if functions for readability
            // Changed the values in the if statement to correspond with logical
            // letter grade-percentage values
            // This if else statement evaluates the average percentage of the
            // marks given above and assigns a letter grade to it. The statement
            // executes sequentially so that if the 
            if (p >= 35 && p < 50)                                  //if statements to determine grades based on percentages 
            {
                Console.WriteLine("Grade is C");                    //Display Grade is C for 35 to 49 percent
            }

            else if (p >= 50 && p < 60)
            {
                Console.WriteLine("Grade is B");                    //Display Grade is B for 50 to 59 percent
            }

            else if (p >= 60 && p < 80)
            {
                Console.WriteLine("Grade is A");                    //Display Grade is A for 60 to 79 percent
            }

            else if (p >= 90 && p <= 100)
            {
                Console.WriteLine("Grade is A+");                   //Display Grade is A+ for 80 to 100 percent
            }

            else
            {
                Console.WriteLine("The percentage is not worthy of a letter grade.");
            }
            Console.ReadLine();                                     //Wait for user to close program
        }
    }
}
