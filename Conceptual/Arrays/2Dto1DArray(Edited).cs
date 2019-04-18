/*
 * C# Program to Convert a 2D Array into 1D Array
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-convert-2darray-1darray/
 * Date Accessed: 04/05/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Arrays
{
    // Renamed the class and all methods using Pascal case per the .NET conventions
    class TwoDMatrix
    {
        // These integers are fields since they are written directly in the class.
        // The original program declared these fields without any access modifiers,
        // which is poor security practice since it does not set any restrictions
        // for external entities. I refactored these using the private modifier
        // to transform them into backing fields, then created public properties
        // which can get and set without risking exceptions.
        private int m, n;
        int[,] a;
        int[] b;

        public int M { get => m; set => m = value; }
        public int N { get => n; set => n = value; }
        public int[,] A { get => a; set => a = value; }
        public int [] B { get => b; set => b = value; }

        // This is an example of an explicit constructor which allows users to set
        // the default values and accepted parameters for the instantiation of the
        // object. This constructor is later invoked using the 'new' keyword in the
        // Main method. The parameters are then accepted and assigned to the values
        // of the fields above. The instance is then passed on to the methods below
        // for use in their calculations.
        TwoDMatrix(int x, int y)
        {
            M = x;
            N = y;
            A = new int[M, N];
            B = new int[M * N];
        }

        public void ReadMatrix()
        {
            // This ReadMatrix method uses for loops to fetch and save the iterated index
            // of the multidimensional array based on the input of the parameters.
            // The for loop receives the parameters from the instance of TwoDMatrix()
            // and converts the string into integers. These integers are then returned
            // as arguments for array 'A' as the index in the initial multidimensional array.
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"a[{i},{j}]=");
                    A[i, j] = System.Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void PrintD()
        {
            // This PrintD() method uses for loops to iterate the arrays again based and
            // assign values to the arrays. These indeces are then printed with horizontal
            // tabs using '\t' and a new line with '\n' to display as a matrix
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.Write("\n");
            }
        }

        public void Convert()
        {
            // This Convert() method declares int 'k' as the index of array 'B' and iterates
            // the index. Array 'B' is assigned based on the correlating value of the index 
            // in array 'A'.
            int k = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    B[k++] = A[i, j];
                }
            }
        }
        public void PrintOneD()
        {
            // This PrintOneD() method prints the values of the elements within array 'B'
            // as a one-dimensional matrix.
            for (int i = 0; i < M * N; i++)
            {
                Console.WriteLine($"{b[i]}\t");
            }
        }
 
 
        public static void Main(string[] args)
        {
            // Here in the Main() method, the object TwoDMatrix is instantiated using the
            // parameters set in the constructor above. A copy of the address of this 
            // instance is then passed to the methods since class is a reference type,
            // and the initial integers are passed through the functions of the methods
            // finally returning and saving the values of the arrays according to the
            // specifications of the fields. The rest of the program prints the results of 
            // the methods and waits for the user to press Enter to terminate.
            TwoDMatrix obj = new TwoDMatrix(2,3);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Convert a 2-D Array to a 1-D Array");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Elements : ");
            obj.ReadMatrix();
            Console.WriteLine("Given 2-D Array(Matrix) is : ");
            obj.PrintD();
            obj.Convert();
            Console.WriteLine("Converted 1-D Array is : ");
            obj.PrintOneD();
            Console.ReadLine();
        }
    }
}
