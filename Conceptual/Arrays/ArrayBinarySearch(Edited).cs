/*
 *  C# Program to Search an element with Array Indices
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-array-search-indices/
 * Date Accessed: 04/05/2019
 */
using System;

namespace Arrays
{
 class ArrayBinarySearch
  {
     public static void Main()
     {
      // This first segment declares a new array and specifies the elements within
      // the array without explicitly specifying the size. This is important when
      // forming the for loop, the condition needs to iterate within the bounds
      // of the array. This program takes advantage of the .Length property, but
      // could also use an explicit value if desired -- though the alternative would
      // be poor practice since future changes would require more refactoring.
       int[] ints = { 0, 10, 100, 1000, 1000000 };
       Console.WriteLine("Array indices and elements: ");
       for (int i = 0; i < ints.Length; i++)
       {
        // Here, the for loop prints the array elements within the specified range
        // The Console.Write is used which means the console will not follow the
        // display with a current line terminator. I refactored the line using
        // the $ operator for string interpolation. This serves to improve readability
        // without sacrificing function and continue the use of the alignment value, in
        // this case '-5', for the console display.
        Console.Write($"[{i}] = {ints[i], -5}");
       }
       Console.WriteLine();
      
      // The Main() method then calls the FindObject() method below with specific parameters
      // to search the ints[] array for a specific element. 
       FindObject(ints, 25);
       FindObject(ints, 1000);
       FindObject(ints, 2000000);
       Console.ReadLine();
     }
  
     public static void FindObject(Array array, Object o)
     {
      // The FindObject() method uses the built-in Array.BinarySearch() method
      // which searches a one-dimensional array for the specified element. This
      // built-in method returns the index of the value if it is found in the
      // array. This method works well in the case of the given array, but
      // may return incorrect index values if used on an unsorted array.
       int index = Array.BinarySearch(array, 0, array.Length, o);
       Console.WriteLine();
      
      // This if-else statement reads the value returned from the Array.BinarySearch()
      // method and prints the search results based on how the BinarySearch() method
      // returns values in the .NET Framework. I also implemented the interpolated
      // string over the composite formatting for readability in this statement
       if (index > 0)
       {
           Console.WriteLine($"Object: {o} found at [{index}]");
       }
       else if (~index == array.Length)
       {
           Console.WriteLine($"Object: {o} not found. "
              + "No array object has a greater value.");
           Console.WriteLine();
       }
       else
       {
           Console.WriteLine($"Object: {o} not found. "
              + "Next larger object found at [{~index}].");
       }
    }
  }
}
