/*
 * C# Program to Demonstrate Multiple Exceptions
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-multiple-exceptions/
 * Date Accessed: 03/31/2019
 */
using System;

// Added namespace to conform to my Github naming conventions
namespace Exceptions
{
    // Renamed program to MultipleExceptions for clarity
    class MultipleExceptions
    {
        static void Main()
        {
            double Num1, Num2;
            double Result = 0.00;
            char op;
            try
            {
                Console.Write("Enter your First Number :  ");
                Num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an Operator  (+, -, * or /): ");
                op = char.Parse(Console.ReadLine());
                if (op != '+' && op != '-' &&
                    op != '*' && op != '/')
                    throw new Exception(op.ToString());
                Console.Write("Enter your Second Number :");
                Num2 = double.Parse(Console.ReadLine());
                if (op == '/')
                    if (Num2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");
                Result = Calculator(Num1, Num2, op);
                Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("The number you typed is not valid");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operation Error: {0} is not a valid op", ex.Message);
            }
            Console.Read();
        }

        static double Calculator(double v1, double v2, char op)
        {
            // This Calculator() method is a basic calculator using only
            // addition, subtraction, multiplication, and division which means
            // there are a significant amount of potential errors from user input.
            // Since the purpose of the program is to demonstrate exception handling
            // the method does not need any refactoring. The method uses a
            // switch case statement to easily handle the four operators
            // and returns the result at the end of the method.
            double Result = 0.00;

            switch (op)
            {
                case '+':
                    Result = v1 + v2;
                    break;
                case '-':
                    Result = v1 - v2;
                    break;
                case '*':
                    Result = v1 * v2;
                    break;
                case '/':
                    Result = v1 / v2;
                    break;
            }
            return Result;
        }
    }
}
