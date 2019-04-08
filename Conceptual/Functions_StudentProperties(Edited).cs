/*
 *  C# Program to Demonstrate Properties of the Class
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-class-properties/
 * Date Accessed: 04/04/2019
 */
using System;

namespace Functions
{
    class Student
    {
        
        private string myName = "N/A";
        private int myAge = 0;
        public string Name
        {
            get { return myName; }
            set { myName = value; }
        }
        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }

        public static void Main()
        {
            Student Student = new Student();
            Console.WriteLine("Student details - {0}", Student);
            Student.Name = "BOB";
            Student.Age = 99;
            Console.WriteLine("Student details - {0}", Student);
            Student.Age += 1;
            Console.WriteLine("Student details - {0}", Student);
            Console.ReadLine();
        }
    }
}
