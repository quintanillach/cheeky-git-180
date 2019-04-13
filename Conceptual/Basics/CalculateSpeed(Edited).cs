/* C# program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-3.php
 * Date Accessed: 04/12/2019
 */

using System;

// Implemented namespace and class naming conventions
namespace Basics
{
    public class CalculateSpeed
    {
        public static void Main()
        {
            // Each of these variables are declared as
            // single-point floating types which allow
            // the user to input larger more precise
            // values than the integral types
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            // Added an introductory statement for the program
            // The console requests the user input data and
            Console.WriteLine("A program to calculate speed based on given time and distance");
            Console.WriteLine("-------------------------------------------------------------");
            try
            {
                Console.Write("Input travel distance (meters): ");
                distance = Convert.ToSingle(Console.ReadLine());

                Console.Write("Input time interval (hour): ");
                hour = Convert.ToSingle(Console.ReadLine());

                Console.Write("Input time interval (minutes): ");
                min = Convert.ToSingle(Console.ReadLine());

                Console.Write("Input time interval (seconds): ");
                sec = Convert.ToSingle(Console.ReadLine());

                timeSec = (hour * 3600) + (min * 60) + sec;
                mps = distance / timeSec;
                kph = (distance / 1000.0f) / (timeSec / 3600.0f);
                mph = kph / 1.609f;

                Console.WriteLine("Your speed in meters/sec is {0}", mps);
                Console.WriteLine("Your speed in km/h is {0}", kph);
                Console.WriteLine("Your speed in miles/h is {0}", mph);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
