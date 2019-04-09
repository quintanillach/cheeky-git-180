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

namespace LeapYearChecker
{
    // Renamed the class using Pascal case per the .NET conventions
    class LeapYear
    {
        static void Main(string[] args)
        {
            // The LeapYear() constructor  is the default constructor created
            // implicitly by C# which sets the member variables to the default
            // values. The method possesses the same name as the class.
            LeapYear obj = new LeapYear();
            
            // The expressions below invoke the ReadData and Leap methods and
            // passes a copy of the address of the class instance 'obj' to the methods
            // rather than the instance itself since a class is a reference type
            // The methods then return the data to the instance 'obj' created
            // in the constructor and save it to memory.
            // Renamed the method names using Pacal case per the .NET conventions
            obj.ReadData();
            obj.Leap();
        }

        // The int 'y' is a field and not a traditional variable since it is
        // created directly in the class which means it is shared among all instances
        // of the class. In the original file, the field was public which meant it
        // had no restrictions to access or modification. I made the field private
        // which means only to the members of the class and is actually called a
        // backing field. This helps guard the program from invalid input and causing
        // it to throw an exception. When I set the field to private I also added
        // a public property to safely expose the field and allowed it to get and set
        // instead of allowing direct access.
        private int y;

        public int Y { get => y; set => y = value; }

        public void ReadData()
        {
            // This method displays a request for the user to input a year and specifies
            // the accepted format. It then receives the input as the default data type
            // string and converts it into an integer. Lastly, the program assigns the
            // integer as the value of the property 'Y' and passes it to the Leap() method.
            Console.WriteLine("Enter the year (YYYY) : ");
            Y = Convert.ToInt32(Console.ReadLine());
        }
        public void Leap()
        {
            // This if statement checks for remainders of 0 when year is divided by 4, 100, 400
            // using the modulus operator. When conditions in the statement are true then the 
            // year is a leap year. When conditions are false, the else statement execute
            // and the year is determined as not a leap year. In each case the function prints
            // the results to the console and waits for the user to press Enter to end program
            if ((Y % 4 == 0 && Y % 100 != 0) || (Y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", Y);
            }
            else                                                                                
            {
                Console.WriteLine("{0} is not a Leap Year", Y); 
            }
            Console.ReadLine();
        }
    }
}
