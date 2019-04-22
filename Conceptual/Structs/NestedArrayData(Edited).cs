/* C# Program to create a nested struct to store two data for an Employee in an array.
 * Source: W3Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/structure/csharp-structure-exercise-3.php
 * Date Accessed: 04/07/2019
 */

using System;

namespace Structs
{
    public class NestedArrayData
    {
        // Employee is a structure of members eName and DateOfBirth
        public struct Employee
        {
            public string eName;
            public DateOfBirth Date;
        }

        // DateOfBirth is a nested structure of Employee
        // Any returns from this struct pass through the
        // corresponding object in Employee() before returning
        // to the calling function
        public struct DateOfBirth
        {
            public int Day;
            public int Month;
            public int Year;
        }

        public static void Main(string[] args)
        {
            // Refactored total as an user input rather
            // than a fixed amount for customization
            // The user's input is written to a string
            // and then converted through TryParse for
            // protection against invalid input
            int dd = 0, mm = 0, yy = 0;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Employee Data :");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Insert the number of employees for you dataset : ");
            string totalEmployees = (Console.ReadLine());
            int.TryParse(totalEmployees, out int total);

            // This code segment invokes the constructor for the
            // Employee struct and instantiates it as an array.
            Employee[] emp = new Employee[total];


            // The for loop iterates through the elements in the
            // array, writes the data from user input to local variables
            // and copies the data from the local variables to
            // the fields in the structs above.
            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the Employee : ");
                string name = Console.ReadLine();
                emp[i].eName = name;

                Console.Write("Input day of the birth [DD] : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("Input month of the birth [MM] : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Input year for the birth [YY] : ");
                yy = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Year = yy;

                // Added printing function for user to verify
                // information is correct
                Console.WriteLine($"\nEmployee Name: {emp[i].eName}");
                Console.WriteLine($"Date of Birth: {emp[i].Date.Month}/{emp[i].Date.Day}/{emp[i].Date.Year} \n");
            }

            Console.ReadLine();
        }
    }
}