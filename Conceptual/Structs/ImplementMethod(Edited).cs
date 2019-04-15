/* C# Program to implement a method that returns a structure including calling the method and using its value.
 * Source: W3Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/structure/csharp-structure-exercise-10.php
 * Date Accessed: 04/07/2019
 */
 
using System;

namespace Structs
{
    public struct SampleStruct
    {
        // Declare the back field 'val' and implement
        // a public property 'Value' to get and set the
        // val field without exposing unnecessary information
        // to the user. This is an example of encapsulation
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }

        // Refactored input as a separate string variable
        // to use the TryParse() method for better protection
        // against unexpected input format
        // The Read() method in this struct takes user input
        // and attempts to parse it to a double. If the attempt
        // is successful, return the output double to the caller
        public double Read()
        {
            string input = (Console.ReadLine());
            double.TryParse(input, out double output);
            return output;
        }
    }
    public struct Square
    {
        // Renamed the methods in this struct using Pascal case
        // Renamed variables for clarity
        SampleStruct length;
        SampleStruct height;

        // These methods call SampleStruct and uses the output
        // to set the value of the variables above.
        public SampleStruct Length
        {
            get { return length; }
            set { length = value; }
        }
        public SampleStruct Breadth
        {
            get { return height; }
            set { height = value; }
        }

        // The void modifier specifies that this method does not
        // return a value
        public void NewSquare()
        {
            // This code segment calls the default constructor for
            // SampleStruct and instantiates an object to save data
            // from the output
            SampleStruct rct = new SampleStruct();

            Console.WriteLine("\nInput the dimensions of the Square ( equal length and width ) : ");
            length = SqrLength();
            Console.Write("Width : ");
            height.Value = rct.Read();
        }

        public SampleStruct SqrLength()
        {
            SampleStruct rct = new SampleStruct();

            Console.Write("Length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    public class StructMain
    {
        static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            
            // This instantiation is an example of type-inference
            // The compiler deduces the type based on the Square()
            // specification.
            var Sqre = new Square();
            Sqre.NewSquare();
            Console.WriteLine();

            // The program prints off the final details of the
            // square structure based on the user input using
            // simple calculations
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Width:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}
