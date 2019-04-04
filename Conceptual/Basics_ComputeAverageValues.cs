/*
 * Purpose: C# Program to Compute Average for the Set of Values
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL:
 * Date Accessed: 03/31/2019
 */
using System;

class program
{
    public static void Main()
    {
        int m, i, sum = 0, avg = 0;                                             //Declare multiple int variables
        Console.WriteLine("Enter the Number of Terms in the Array ");           //Display request for user input
        m = int.Parse(Console.ReadLine());                                      //Convert user input from string to int, then write fo var 'm'
        int[] a = new int[m];                                                   //Create int array 'a' with index of value 'm'
        Console.WriteLine("Enter the Array Elements ");
        for (i = 0; i < m; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < m; i++)
        {
            sum += a[i];
        }
        avg = sum / m;
        Console.WriteLine("Average is {0}", avg);
        Console.ReadLine();
    }
}
