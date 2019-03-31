/* Purpose: C# program to check if a given year is a leap year
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL:
 * Date Accessed: 03/26/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYearChecker
{
    class leapYear
    {
        static void Main(string[] args)
        {
            //Constructor instantiates the object 
            leapYear obj = new leapYear();
            obj.readData();
            obj.leap();
        }
        int y;
        public void readData()
        {
            // User inputs the year they want to check
            Console.WriteLine("Enter the year (YYYY) : ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            //if, else statement to state whether year is leap or not leap
            //if statement to check for remainders of 0 when year is divided by 4, 100, 400
            //if conditions are met then the year is a leap year
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", y);
            }
            //When conditions in the if statement are false, execute the else statement 
            else
            {
                Console.WriteLine("{0} is not a Leap Year", y);
            }
            //Force user input to end program
            Console.ReadLine();
        }
    }
}
