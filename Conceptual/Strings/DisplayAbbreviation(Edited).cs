/* Purpose: C# program to display the abbreviation of a text
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-display-abbreviation-text/
 * Date Accessed: 03/31/2019
 */

using System;

// Renamed the namespace, class, and methods using Pascal case per .NET conventions
namespace Strings
{
    // Added the public access modifier for consistency
    public class DisplayAbbreviation
    {
        // Here the field 'str' is declared to allow all methods to access
        // one variable rather than create separate instances. The original
        // code did not use an access modifier on the field. I added the
        // private access modifier to transform it into a backing field
        // and prevent external sources from corrupting the program. I 
        // added the property Str to get and set the field.
        private string str;

        public string Str { get => str; set => str = value; }

        public void ReadData()
        {
            // The ReadData() method simply requests the user to input
            // a string to abbreviate and assigns the value to the
            // 'Str' property
            // Added 'ToLower' property to maintain proper acronym format
            Console.WriteLine("Enter a String : ");
            Str = Console.ReadLine().ToLower();
        }

        public void Abbreviate()
        {
            // This segment of the code declares two separate character
            // arrays 'stringLength' and 'result'. The integer 'j' is also
            // declared and assigned an initial value of 0.
            char[] stringLength, result;
            int j = 0;

            // Then the stringLength and result arrays are instantiated with
            // the number of elements within each array set to the length of
            // the Str property. This allows the program to adapt to various
            // strings and makes the program re-usable.
            stringLength = new char[Str.Length];
            result = new char[Str.Length];

            // The ToCharArray method is called here which copies the characters
            // from the string input to an array of individual unicode characters
            stringLength = Str.ToCharArray();

            // The 0 index of the stringLength array is cast converted to an
            // integer type and either the 0 index or 32 is cast converted to
            // a unicode character ( the unicode equivalent of 32 is a space )
            // This value of the index j++ is then appended to a '.'
            result[j++] = (char)((int)stringLength[0] ^ 32);
            result[j++] = '.';


            // This for loop ensures that for every index of stringLength --
            // without exceeding the bounds of the array -- is evaluated.
            // If the value of the element in stringLength is equal to
            // a space, tab, or line break, the element is cast converted
            // to an integer value then cast converted just as above to a
            // unicode character. This value is then appended to a '.'
            for (int i = 0; i < Str.Length - 1; i++)
            {
                if (stringLength[i] == ' ' || stringLength[i] == '\t' || stringLength[i] == '\n')
                {
                    int k = (int)stringLength[i + 1] ^ 32;
                    result[j++] = (char)k;
                    result[j++] = '.';
                }
            }

            // Finally, the Abbreviate() method displays the original
            // string followed by the resulting array.
            // Reformatted the Console.Write using string interpolation
            // over traditional composite formatting for readability
            Console.Write($"The Abbreviation for {Str} is ");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Convert a string to an acronym");
            Console.WriteLine("----------------------------------------\n");
            // The Main() method only contains the default constructor
            // which instantiates the class as an object and then
            // passes a copy of the address of the object to
            // the ReadData() and Abbreviate() methods above
            // and saves the data returned to the object itself
            DisplayAbbreviation obj = new DisplayAbbreviation();
            obj.ReadData();
            obj.Abbreviate();
        }
    }
}
