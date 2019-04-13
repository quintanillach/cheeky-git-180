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
            // The username and password variables are declared here along with
            // integer variables 
            string username, password;
            int attempts = 0, success = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Defaule username and password is : username and password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "username" && password == "password")
                {
                    success = 1;
                    attempts = 3;
                }

                else
                {
                    success = 0;
                    attempts++;
                }
            }
            while ((username != "username" || password != "password")
                    && (attempts != 3));
            if (success == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else if (success == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }
    }
}
