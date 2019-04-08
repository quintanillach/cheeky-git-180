/*
 * C# Program to Copy a Section of One Array to Another
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-copy-section-onearray-another/
 * Date Accessed: 04/05/2019
 */
 
using System;

namespace Arrays
{
 class CopyBetweenArrays
 {
   static void Main()
   {
    // These integer variables are declared at the beginning of the program
    // since they are used throughout the method. None of them are assigned
    // values explicitly, which means the compiler assigns them a default
    // value of 0. The program then displays a request for the user to input
    // the number of elements in the array
    int sourceSize, targetSize, newSize;
    Console.WriteLine("Enter the size of the Array : ");
    sourceSize = Convert.ToInt32(Console.ReadLine());
    int [] sourceArray = new int[sourceSize];
    
    Console.WriteLine("Enter the Elements of the First Array :");
    for (int i = 0; i < sourceSize; i++)
      {
        sourceArray[i] = Convert.ToInt32(Console.ReadLine());
      }
    
    Console.WriteLine("Enter the Size of the Target Array : ");
    targetSize = Convert.ToInt32(Console.ReadLine());
    int[] targetArray = new int[targetSize];
    
    Console.WriteLine("Enter the section of the First Array "+ 
                      "that has to be Copied :");
    size = Convert.ToInt32(Console.ReadLine());
    Array.Copy(sourceArray, 0, targetArray, 0, newSize);
    Console.WriteLine("New Array With The Specified Section of Elements "+
                      "in the First Array");
    foreach (int value in targetArray)
    {
       Console.WriteLine(value);
    }
    Console.Read();
    }
  }
}
