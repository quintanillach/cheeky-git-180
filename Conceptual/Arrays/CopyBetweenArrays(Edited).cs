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
    // the number of elements in the array. The input is then converted from
    // the default string type to an integer type for use in the array index.
    // The sourceSize variable is used to instantiate a sourceArray[] and
    // give it the number of elements indicated by the user.
    // I also renamed the variables in the program to be more specific as to
    // each variables' function for improved readability.
    int sourceSize, targetSize, newSize;
    Console.WriteLine("Enter the size of the Array : ");
    sourceSize = Convert.ToInt32(Console.ReadLine());
    int [] sourceArray = new int[sourceSize];
    
    // Once the user has input the size of the array, the console displays a
    // request for the individual elements of the array. The for loop ensures
    // the user does not exceed the number of elements within the array by
    // iterating the index only as long as the iteration is smaller than
    // the sourceSize value. The user input is converted once again from string
    // to integer type and save to the array.
    Console.WriteLine("Enter the Elements of the First Array :");
    for (int i = 0; i < sourceSize; i++)
      {
        sourceArray[i] = Convert.ToInt32(Console.ReadLine());
      }
    
    // The console then asks for the size of the array the values are being copied
    // to and instantiates a new array with as many elements as the user inputs.
    Console.WriteLine("Enter the Size of the Target Array : ");
    targetSize = Convert.ToInt32(Console.ReadLine());
    int[] targetArray = new int[targetSize];
    
    // Here, the program is asking the user for a range within the first array
    // which should be copied. The Array.Copy method then copies the range beginning
    // at the specified index and pastes them into the targetArray[] starting at
    // the specified destination index. 
    Console.WriteLine("Enter the section of the First Array "+ 
                      "that has to be Copied :");
    newSize = Convert.ToInt32(Console.ReadLine());
    Array.Copy(sourceArray, 0, targetArray, 0, newSize);
    
    // Lastly, the program uses a foreach loop to iterate through the targetArray[]
    // and print the new values based on the Array.Copy return above. The program
    // waits for the user to press Enter before terminating
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
