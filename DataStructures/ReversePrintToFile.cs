using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

public class Program
{
    // Method to reverse text in an array from the document
    public static void ReverseFileText(string[] currentDocument)    // O(n)
    {
        // Initialize a stack of the same type
        Stack<string> reverseDocument = new Stack<string>();

        // Iterate through the entire array
        for (int i = 0; i < currentDocument.Length; i++)    // O(n)
        {
            // Push each string to the stack
            reverseDocument.Push(currentDocument[i]);
        }

        // Execute as long as the stack is not empty
        while (reverseDocument.Count != 0)  // O(n)
        {
            // Write the strings to a new document from the stack
            File.WriteAllLines($"output.txt", reverseDocument, Encoding.UTF8);
        }
    }

    public static void Main()
    {
        // Read all lines of the document to an array of strings
        string[] currentDocument = File.ReadAllLines("input.txt");

        // Call the reversal method
        ReverseFileText(currentDocument);

        // Display a message that reversal was completed
        Console.WriteLine("Your document was reversed...");
        Console.ReadLine();
    }
}