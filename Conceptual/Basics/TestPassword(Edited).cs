/* C# program to take userid and password. After three wrong attempts, user will be rejected
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-3.php
 * Date Accessed: 04/12/2019
 */

using System;

namespace Basics
{

    public class TestPassword
    {
        public static void Main()
        {
            // Refactored the variable 'success' from integer type
            // to boolean type; added title block
            string username, password;
            int attempts = 0;
            bool success = false;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Check username and password :");
            Console.WriteLine("NOTE : Default username and password is - username and password");
            Console.WriteLine("---------------------------------\n");

            // The do-while loop executes the code in the do segment
            // at least once while the specified boolean expression
            // evaluates to true
            do
            {
                Console.Write("Input an username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                // This if-else statement checks if both the username
                // and password match the variables. If they do not
                // match the attempts variable increases by a value of 1
                // and a message is displayed to the user with the number
                // of attempts so far.
                if (username == "username" && password == "password")
                {
                    success = true;
                    attempts = 3;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("\n Login not successful.After three attempts, your account will be temporarily disabled");
                    Console.WriteLine($"Attempts : {attempts}\n");
                }
            }

            // The while block specifies the conditions in which the
            // following code block executes. In this case the while loop
            // breaks when attempts == 3. 
            while (attempts < 3);

            // Finally, this if-else statement evaluate the success
            // variable and verifies the user login as successful or not
            if (success != true)
            {
                Console.WriteLine("Login temporary disabled. Please try again later.");
            }
            else
            {
                Console.WriteLine("\nLogin successful!");
            }
        }
    }
}