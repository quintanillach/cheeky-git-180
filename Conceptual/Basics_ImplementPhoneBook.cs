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
class PhoneBook
{
 
    static void Main(string[] arg)
    {
        // The Hashtable class represents a collection of key pairs which
        // are organized based on the hash code of the key. This program
        // creates a new hashtable named 'tab' and uses it to build a phone
        // book with the various inputs.
        Hashtable tab = new Hashtable();
        string fileName;

        // The original file put the conditions inside of the brackets which
        // is not good coding practice. Fixed this formatting by cutting and pasting
        // to the correct spot.
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
