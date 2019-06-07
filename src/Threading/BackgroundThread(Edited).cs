/*
 * C# program to illustrate background threads
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/types-of-threads-in-c-sharp/
 * Date Accessed: 04/26/2019
 */

using System;
using System.Threading;

namespace Threading
{
    public class BackgroundThread
    {

        static void Main(string[] args)
        {
            // The default constructor for Thread is instantiated
            // and calls the MyThread method as
            Thread threadExample = new Thread(MyThread);

            threadExample.Name = "YourThread";

            // The thread state is switched to running
            // and the status is monitored by the console
            threadExample.Start();
            threadExample.IsBackground = true;

            // Added an array to keep thread alive until
            // user presses 10 keys
            int[] countDown = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < countDown.Length; i++)
            {
                Console.WriteLine($"Key presses until thread termination : {countDown[i]}\n");
                Console.ReadKey();
            }

            // The user is notified when the thread is terminated
            Console.WriteLine($"{threadExample.Name} has ended!");
        }

        static void MyThread()
        {
            // The MyThread method prints the name of the thread to the console
            Console.WriteLine($"In progress thread is: {Thread.CurrentThread.Name}\n");

            Thread.Sleep(10000);

            Console.WriteLine($"Completed thread is: {Thread.CurrentThread.Name}");
        }
    }
}
