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
 
namespace Program
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
        // of the fields above.
        TwoDMatrix(int x, int y)
        {
            M = x;
            N = y;
            A = new int[M, N];
            B = new int[M * N];
        }
        public void ReadMatrix()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    A[i, j] = System.Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void PrintD()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0}\t", A[i, j]);
 
                }
                Console.Write("\n");
            }
        }
        public void Convert()
        {
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
            for (int i = 0; i < M * N; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
        }
 
 
        public static void Main(string[] args)
        {
            TwoDMatrix obj = new TwoDMatrix(2,3);
            Console.WriteLine("Enter the Elements : ");
            obj.ReadMatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.PrintD();
            obj.Convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.PrintOneD();
            Console.ReadLine();
        }
    }
}
