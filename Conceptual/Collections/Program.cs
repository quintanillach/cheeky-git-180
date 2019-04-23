/*
 * C# Program to demonstrate the properties of the Dictionary class
 * Source: Microsoft Docs
 * Source Author: N/A
 * Source URL: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2
 * Date Accessed: 04/17/2019
 */

using System;
using System.Collections.Generic;

namespace Dictionaries
{
    public class DictionaryGeneric
    {
        public static void Main()
        {
            // Added a segment to display the program function
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Collection of File Extensions and Associated Programs");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("\n");

            // This segment initializes an empty Dictionary which
            // accepts key value pairs of strings and strings
            Dictionary<string, string> openWith =
                new Dictionary<string, string>();

            // Uses the .Add method to insert key value pairs into the
            // dictionary with some duplicate values but no duplicate keys
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // Refactored this segment to allow user input rather than a fixed input
            // The user input is assigned to a local variable and concatenated
            // to meet the accepable parameter format for the .Add method
            // The segment is in a try-catch block to handle cases where
            // the key already exists in the colection

            Console.WriteLine("Enter the file extension you would like to add : ");
            string fileType = (Console.ReadLine());
            Console.WriteLine("Enter the associated application name followed by [.exe] : ");
            string appName = (Console.ReadLine());

            try
            {
                openWith.Add($"{fileType}", $"{appName}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"An element with Key = \\ {fileType} \\ already exists");
            }

            // The Item property is another name for the indexer, so you 
            // can omit its name when accessing elements. 
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // The indexer can be used to change the value associated
            // with a key.
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // The indexer throws an exception if the requested key is
            // not in the dictionary.
            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.",
                    openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient 
            // way to retrieve values.
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting 
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}",
                    openWith["ht"]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
        }
    }
}
