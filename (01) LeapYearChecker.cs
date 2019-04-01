/* Purpose: C# program to check if a given year is a leap year
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL:
 * Date Accessed: 03/26/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYearChecker                                                                                   //Namespace
{
    class leapYear                                                                                          //Class
    {
        static void Main(string[] args)                                                                     //Main method
        {
            leapYear obj = new leapYear();                                                                  //Constructor
            obj.readData();                                                                                 //Method Call readData()
            obj.leap();                                                                                     //Method Call leap()
        }
        int y;                                                                                              //Declare field 'y'
        public void readData()                                                                              //Method readData()
        {
            Console.WriteLine("Enter the year (YYYY) : ");                                                  //Display request for user input to console
            y = Convert.ToInt32(Console.ReadLine());                                                        //Save user input to 'y'
        }
        public void leap()                                                                                  //Method leap()
        {                                                                                                   //if, else statement to state whether year is leap or not leap
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))                                             //if statement to check for remainders of 0 when year is divided by 4, 100, 400
            {
                Console.WriteLine("{0} is a Leap Year", y);                                                 //when conditions are true then the year is a leap year
            }
            else                                                                                            //else statement executes in all other cases
            {
                Console.WriteLine("{0} is not a Leap Year", y);                                             //When conditions are false, the year is not a leap year 
            }
            Console.ReadLine();                                                                             //Force user input to end program
        }
    }
}
