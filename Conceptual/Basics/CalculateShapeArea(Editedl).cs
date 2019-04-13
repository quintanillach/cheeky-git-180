/* C# Menu-Driven Program to compute the area of the various geometrical shape
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/conditional-statement/csharp-conditional-statement-exercise-24.php
 * Date Accessed: 04/12/2019
 */

using System;

namespace Basics
{
    public class AreaOfShape
    {
        public static void Main()
        {
            // Refactored 'choice' from int to string to use TryParse method
            // Renamed variables for clarity
            // Refactored the integers as single floating-point type for precision
            // These floats represent the factors for calculating the area
            // of the optional shapes in the program. They are all tersely
            // declared on the same line for readability and implicitly assigned
            // the default value of 0.
            float radius, length, width, baseT, heightT;
            double area = 0;

            Console.Write("\n\n");
            Console.Write("A menu driven program to compute the area of various geometrical shape:\n");
            Console.Write("-------------------------------------------------------------------------");
            Console.Write("\n\n");

            // The user is given a menu of shapes to choose from
            // which displays clear function of the program
            Console.WriteLine("Select the type of calculation : ");
            Console.WriteLine("[ 1 ] Area of circle");
            Console.WriteLine("[ 2 ] Area of rectangle");
            Console.WriteLine("[ 3 ] Area of triangle");
            string selection = (Console.ReadLine());

            // The console then attempts to parse the user's
            // selection from string to double. If the attempt
            // is successful, the function then outputs an double
            // for the switch statement to use
            double.TryParse(selection, out double shape);

            switch (shape)
            {
                // Corrected spelling and formatting within the cases
                // Refactored Conversions from ToInt32 to ToSingle for precision
                // Refactored 3.14 to Math.PI for precision
                // Added the default case label for conventions
                // These case labels employ the math formulas for calculating
                // the areas of the given shapes. The case label that executes
                // depends on the user's menu choice.
                case 1:
                    Console.Write("Input the radius of the circle : ");
                    radius = Convert.ToSingle(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case 2:
                    Console.Write("Input the length  of the rectangle : ");
                    length = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Input the width of the rectangle : ");
                    width = Convert.ToSingle(Console.ReadLine());
                    area = length * width;
                    break;
                case 3:
                    Console.Write("Input the base of the triangle : ");
                    baseT = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Input the height of the triangle :");
                    heightT = Convert.ToSingle(Console.ReadLine());
                    area = .5 * baseT * heightT;
                    break;
                default:
                    Console.WriteLine("The menu selection was invalid");
                    break;
            }

            // Refactored using string interpolation rather than
            // composite formatting
            // Finally the program prints the result of the switch statement
            // and waits for the user to terminate the program.
            Console.WriteLine($"The area is : {area}");
            Console.ReadLine();
        }
    }
}