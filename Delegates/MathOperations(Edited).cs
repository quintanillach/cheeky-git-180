/* C# Program to math operations using delegates
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-call-math-operations-delegates/
 * Date Accessed: 04/07/2019
 */
 
using System;

namespace Delegates
{
    // The MathOperations class contains the methods which
    // process the values specified in the Main() method.
    public class MathOperations
    {
        // Renamed this method for clarity
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }

        public static double Square(double value)
        {
            return value * value;
        }
    }

    // The delegate DoubleOp safely encapsulates methods of its type
    // and accepts the parameter passed by its caller, in this case
    // the ProcessAndDisplayNumber() method
    delegate double DoubleOp(double x);

    class Application
    {
        static void Main()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Math Operations Using Delegates");
            Console.WriteLine("---------------------------------------\n");

            // The delegate is instantiated as an array which encapsulates
            // the methods in the MathOperations class.
            DoubleOp[] operations = {
               MathOperations.MultiplyByTwo,
               MathOperations.Square
            };

            // Added an segment for user input using Console.Readline
            // to assign values to local string variables and attempt to
            // parse these string to double floating-point types
            // which helps to prevent the user from crashing the program
            Console.WriteLine("Enter the first value : ");
            string _valueOne = (Console.ReadLine());
            if (Double.TryParse(_valueOne, out double ValueOne)) ;

            Console.WriteLine("Enter the second value : ");
            string _valueTwo = (Console.ReadLine());
            if (Double.TryParse(_valueTwo, out double ValueTwo)) ;

            Console.WriteLine("Enter the third value : ");
            string _valueThree = (Console.ReadLine());
            if (Double.TryParse(_valueThree, out double ValueThree)) ;

            // This for loop iterates through the delegate array and
            // passes the values from the user input to the ProcessAndDisplayNumber()
            // and prints the result to the console
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Operation[{i}] : ");
                ProcessAndDisplayNumber(operations[i], ValueOne);
                ProcessAndDisplayNumber(operations[i], ValueTwo);
                ProcessAndDisplayNumber(operations[i], ValueThree);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        // This method invokes the delegate and passes an acceptable
        // parameter. The delegate then returns the output from the
        // encapsulated functions back to this method.
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine(
               "Value : {0}  Result : {1}", value, result);
        }
    }
}