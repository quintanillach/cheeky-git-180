/*
 * C# program to show the difference between a class and an instance
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-class-vs-instance/problem
 * Date Accessed: 04/06/2019
 */
 
using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeProblems
{
    public class Person
    {
        // The age field backs the Age property which is declared
        // at the class level since only one value of age will be
        // evaluated at a time
        private int age;

        public int Age { get => age; set => age = value; }

        public Person(int initialAge)
        {
            // If statement checks to ensure age is over 0
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                // Assign the value to the Age property
                Age = initialAge;
            }
        }

        public void AmIOld()
        {
            // The message printed corresponds with the age of the person
            // instance when the method is called
            if (Age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (Age >= 13 && Age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (Age >= 18)
            {
                Console.WriteLine("You are old.");
            }
        }

        public void YearPasses()
        {
            // Increments the Age property
            Age++;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Challenge program to print a message based on the age of a person");
            Console.WriteLine("------------------------------------------------------------------\n");

            // Asks for the number of people being evaluated
            // Try to convert the input to an integer type
            Console.WriteLine("How many test cases?");
            string testCases = (Console.ReadLine());
            int.TryParse(testCases, out int T);

            for (int i = 0; i < T; i++)
            {
                // Display request for user input for each
                // test case and parse to integer
                Console.Write($"Test Case {i} : ");
                string ageInput = (Console.ReadLine());
                int.TryParse(ageInput, out int age);

                // Instantiate the Person object using the default
                // constructor
                Person p = new Person(age);

                // Call the AmIOld method for the instance
                p.AmIOld();

                // Increment the Age of the instance through
                // the YearPasses() method
                for (int j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }

                // Print the message again
                p.AmIOld();
                Console.WriteLine();
            }
        }
    }
}