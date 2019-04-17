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

namespace Collections
{
    class ImplementPhoneBook
    {

        static void Main(string[] arg)
        {
            // The Hashtable class represents a collection of key pairs which
            // are organized based on the hash code of the key. This program
            // creates a new hashtable named 'tab' and uses it to build a phone
            // book with the various inputs.
            Hashtable tab = new Hashtable();
            string fileName;

            // Moved conditions for if statement outside of curly braces
            // This if statement checks arg[] array to ensure it has elements
            // and assigns the value at the zero index as the fileName.
            // If there are no elements within the array, the program assigns
            // a default fileName
            if (arg.Length > 0)
            {
                fileName = arg[0];
            }
            else
            {
                fileName = "phoneBook.txt";
            }

            StreamReader r = File.OpenText(fileName);
            string line = r.ReadLine();

            while (line != null)
            {
                int pos = line.IndexOf('=');
                string name = line.Substring(0, pos).Trim();
                long phone = Convert.ToInt64(line.Substring(pos + 1));
                tab[name] = phone;
                line = r.ReadLine();
            }

            r.Close();

            // The empty conditions on this for loop indicate an infinite loop
            // which means the expressions within the loop are executed throughout
            // the program
            for (; ; )
            {
                Console.Write("Name : ");
                string name = Console.ReadLine().Trim();
                if (name == "")
                    break;
                object phone = tab[name];
                if (phone == null)
                    Console.WriteLine("-- Not Found in Phone Book");
                else
                    Console.WriteLine(phone);
            }
        }
    }
}