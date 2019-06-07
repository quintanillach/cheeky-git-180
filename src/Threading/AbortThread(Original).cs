/*
 * C# program to illustrate abort threads
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/how-to-terminate-a-thread-in-c-sharp/
 * Date Accessed: 04/26/2019
 */

using System; 
using System.Threading; 

class ExThread { 

	public Thread thr; 

	public ExThread(string name) 
	{ 
		thr = new Thread(this.RunThread); 
		thr.Name = name; 
		thr.Start(); 
	} 

	// Enetring point for thread 
	void RunThread() 
	{ 
		try { 
			Console.WriteLine(thr.Name + 
						" is starting."); 

			for (int j = 1; j <= 100; j++) 
			{ 
				Console.Write(j + " "); 
				if ((j % 10) == 0) 
				{ 
					Console.WriteLine(); 
					Thread.Sleep(200); 
				} 
			} 
			Console.WriteLine(thr.Name + 
				" exiting normally."); 
		} 
		catch (ThreadAbortException ex) { 
			Console.WriteLine("Thread is aborted and the code is "
											+ ex.ExceptionState); 
		} 
	} 
} 

// Driver Class 
class GFG { 

	// Main method 
	static void Main() 
	{ 

		// Creating object of ExThread 
		ExThread obj = new ExThread("Thread "); 
		Thread.Sleep(1000); 
		Console.WriteLine("Stop thread"); 
		obj.thr.Abort(100); 

		// Waiting for a thread to terminate. 
		obj.thr.Join(); 
		Console.WriteLine("Main thread is terminating"); 
	} 
} 
