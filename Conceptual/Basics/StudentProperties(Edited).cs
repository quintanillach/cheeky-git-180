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
        // The two fields 'myName' and 'myAge' are declared with the private
        // access modifier and implemented as backing fields rather than public
        // to guard the program from unexpected input. The properties 'Name' and
        // 'Age' are then declared with the get and set accessors which allows
        // the program expose only the desired information without revealing
        // private data or risking corruption.
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

        // The override modifier here allows the program to extend or modify the
        // abstract value of the method based on the inherited properties from
        // above.
        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }

        public static void Main()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Demonstrate the Properties of a Class");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");

            // This program uses a default constructor to instantiate an object
            // of the same name as the class -- in this case 'Student'. The program
            // then prints the details of the student. The original program did not allow
            // the user to input any value and instead just printed prefabricated information.
            // I refactored this segment to receive user input and save the information
            // to the Student properties. I also used string interpolation over composite
            // formatting in the Console.WriteLine functions
            Student Student = new Student();
            Console.WriteLine("Enter Student Name : ");
            Student.Name = (Console.ReadLine());
            Console.WriteLine("Enter Student Age : ");
            Student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Student details - {Student}");
            Console.ReadLine();
        }
    }
}
