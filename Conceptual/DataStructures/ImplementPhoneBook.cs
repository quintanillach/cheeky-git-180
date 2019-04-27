/*
 * C# Program to Implement PhoneBook
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-phonebook-webservice/
 * Date Accessed: 03/31/2019
 */

using System;
using System.Collections;
using System.IO;

// Added custom namespace
namespace Collections
{
    public class ImplementPhoneBook
    {

        public static void Main(string[] arg)
        {
            Console.WriteLine("Specify the directory of the data : ");
            string specifiedPath = (Console.ReadLine());
            SetCurrentDirectory(specifiedPath);
            // The Hashtable class represents a collection of key pairs which
            // are organized based on the hash code of the key. This program
            // creates a new hashtable named 'tab' and uses it to build a phone
            // book with the various inputs.
            Hashtable phoneBook = new Hashtable();
            string fileName;

            // This if statement checks arg[] array to ensure it has elements
            // and assigns the value at the zero index as the fileName.
            // If there are no elements within the array, the program assigns
            // a default fileName
            // Moved conditions for if statement outside of curly braces
            if (arg.Length > 0)
            {
                fileName = arg[0];
            }
            else
            {
                fileName = "phoneBook.txt";
            }

            StreamReader readCharacters = File.OpenText(fileName);
            string textLines = readCharacters.ReadLine();

            while (textLines != null)
            {
                int pos = textLines.IndexOf('=');
                string name = textLines.Substring(0, pos).Trim();
                long phone = Convert.ToInt64(textLines.Substring(pos + 1));
                phoneBook[name] = phone;
                textLines = readCharacters.ReadLine();
            }

            readCharacters.Close();

            // The empty conditions on this for loop indicate an infinite loop
            // which means the expressions within the loop are executed throughout
            // the program
            for ( ; ; )
            {
                Console.Write("Name : ");
                string name = Console.ReadLine().Trim();

                while (name != null)
                {
                    object phone = phoneBook[name];
                    if (phone == null)
                        Console.WriteLine("-- Not Found in Phone Book");
                    else
                        Console.WriteLine(phone);
                }
            }
        }

        public static void SetCurrentDirectory(string path)
        {
            string dir = ($"{path}");
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
        }
    }
}