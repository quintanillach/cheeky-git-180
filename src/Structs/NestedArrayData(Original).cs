/* C# Program to create a nested struct to store two data for an employee in an array.
 * Source: W3Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/structure/csharp-structure-exercise-3.php
 * Date Accessed: 04/07/2019
 */

using System;
    class strucExer3
    {
	//employee is a structure of members eName and dtObirth
        struct employee
        {
            public string eName;
            public dtObirth Date;
        }
	//dtObirth is a nested structure of employee
        struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
        }  
        static void Main(string[] args)
        {
             
            int dd=0, mm=0, yy=0;
            int total = 2;
			Console.Write("\n\nCreate a nested struct and store data in an array :\n");
			Console.Write("-------------------------------------------------------\n"); 	
            employee[] emp = new employee[total];
 
            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;
 
                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;
 
                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;
 
                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
        }
    }
