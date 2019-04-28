/*
 * C# program to illustrate thread states
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/lifecycle-and-states-of-a-thread-in-c-sharp/
 * Date Accessed: 04/26/2019
 */

using System; 
using System.Threading;

// Added custom namespace
namespace Threading
{
    public class MyThread
    {

        public void Thread()
        {
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("My Thread");
            }
        }
    }

    public class ThreadExample
    {

        public static void Main()
        {

            MyThread yourThread = new MyThread();

            Thread threadOne = new Thread(new ThreadStart(yourThread.Thread));

            Console.WriteLine($"ThreadState: {threadOne.ThreadState}");

            threadOne.Start();
            Console.WriteLine($"ThreadState: {threadOne.ThreadState}");

            threadOne.Suspend();
            Console.WriteLine($"ThreadState: {threadOne.ThreadState}");

            threadOne.Resume();
            Console.WriteLine($"ThreadState: {threadOne.ThreadState}");
        }
    }
}