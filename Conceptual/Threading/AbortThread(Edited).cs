/*
 * C# program to illustrate abort threads
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/how-to-terminate-a-thread-in-c-sharp/
 * Date Accessed: 04/26/2019
 */

using System; 
using System.Threading;

namespace Threading
{
    public class ExampleThread
    {
        // A thread is created
        public Thread threadOne;

        public ExampleThread(string name)
        {
            // The created thread is instantiated and the
            // RunThread method is called to start the thread
            threadOne = new Thread(this.RunThread);
            threadOne.Name = name;
            threadOne.Start();
        }

        public void RunThread()
        {
            // The try-catch block raises attempts to execute code and monitors
            // the program for raised exceptions
            try
            {
                Console.WriteLine($"{threadOne.Name} is starting.");

                // The for loop counts by 10 with a short pause between each count
                // until the count reaches 100
                for (int j = 1; j <= 100; j++)
                {
                    Console.Write($"{j} ");
                    if ((j % 10) == 0)
                    {
                        Console.WriteLine();
                        Thread.Sleep(200);
                    }
                }
                Console.WriteLine($"{threadOne.Name} exiting normally.");
            }

            catch (ThreadAbortException ex)
            {
                // The ExceptionState is printed to the console
                Console.WriteLine($"Thread is aborted and the code is {ex.ExceptionState}");
            }
        }
    }

    public class AbortThread
    {
        public static void Main()
        {
            // The default constructor is called for ExampleThread
            // and an object is instantiated of type ExampleThread
            ExampleThread mainThread = new ExampleThread("Thread ");

            // The Sleep method is called to suspend the thread for 1 second
            Thread.Sleep(1000);
            Console.WriteLine("Stop thread");

            // A ThreadAbortException is raised and the thread is terminated
            mainThread.threadOne.Abort(100);

            mainThread.threadOne.Join();
            Console.WriteLine("Main thread is terminating");
        }
    }
}