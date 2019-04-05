/*
 *  C# Program to Search an element with Array Indices
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-array-search-indices/
 * Date Accessed: 04/05/2019
 */
using System;
 
class ArrayBinarySearch
{
    public static void Main()
    {
        int[] ints = { 0, 10, 100, 1000, 1000000 };
        Console.WriteLine("Array indices and elements: ");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write("[{0}]={1, -5}", i, ints[i]);
        }
        Console.WriteLine();
        FindObject(ints, 25);
        FindObject(ints, 1000);
        FindObject(ints, 2000000);
        Console.ReadLine();
    }
 
    public static void FindObject(Array array, Object o)
    {
        int index = Array.BinarySearch(array, 0, array.Length, o);
        Console.WriteLine();
        if (index > 0)
        {
            Console.WriteLine("Object: {0} found at [{1}]", o, index);
        }
        else if (~index == array.Length)
        {
            Console.WriteLine("Object: {0} not found. "
               + "No array object has a greater value.", o);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Object: {0} not found. "
               + "Next larger object found at [{1}].", o, ~index);
        }
    }
}
