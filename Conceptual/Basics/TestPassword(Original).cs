/* C# program to take userid and password. After three wrong attempts, user will be rejected
 * Purpose: C# Program to Compute Average for the Set of Values
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-3.php
 * Date Accessed: 04/12/2019
 */

using System;
public class Exercise3
{
public static void Main()
{
string username, password;
int ctr = 0,dd=0;
       Console.Write("\n\nCheck username and password :\n");
	   Console.Write("N.B. : Defaule username and password is : username and password\n");
       Console.Write("---------------------------------\n"); 
do
{
Console.Write("Input a username: ");
username = Console.ReadLine();
 
Console.Write("Input a password: ");
password = Console.ReadLine();
if( username == "username" && password == "password" )
{
    dd=1;
    ctr=3;
}

else
{
    dd=0;
    ctr++;
}
}
while (( username != "username" || password != "password" )
        && (ctr != 3));
        if (dd == 0)
        {
            Console.Write("\nLogin attemp more than three times. Try later!\n\n");
        }
        else  
        if(dd==1)
        {
            Console.Write("\nPassword entered successfull!\n\n");	}         
    }
}
