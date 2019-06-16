/*
 * C# solution to print next greater element using stack
 * Source: Geeks for Geeks
 * Source Author: Shrikant13
 * Source URL: https://www.geeksforgeeks.org/next-greater-element/
 * Date Accessed: 04/30/2019
 */

using System; 

public class NGE 
{ 
	public class stack 
	{ 
		public int top; 
		public int[] items = new int[100]; 

		// Stack functions to be used by printNGE 
		public virtual void push(int x) 
		{ 
			if (top == 99) 
			{ 
				Console.WriteLine("Stack full"); 
			} 
			else
			{ 
				items[++top] = x; 
			} 
		} 

		public virtual int pop() 
		{ 
			if (top == -1) 
			{ 
				Console.WriteLine("Underflow error"); 
				return -1; 
			} 
			else
			{ 
				int element = items[top]; 
				top--; 
				return element; 
			} 
		} 

		public virtual bool Empty 
		{ 
			get
			{ 
				return (top == -1) ? true : false; 
			} 
		} 
	} 

	/* prints element and NGE pair for 
	all elements of arr[] of size n */
	public static void printNGE(int[] arr, int n) 
	{ 
		int i = 0; 
		stack s = new stack(); 
		s.top = -1; 
		int element, next; 

		/* push the first element to stack */
		s.push(arr[0]); 

		// iterate for rest of the elements 
		for (i = 1; i < n; i++) 
		{ 
			next = arr[i]; 

			if (s.Empty == false) 
			{ 

				// if stack is not empty, then 
				// pop an element from stack 
				element = s.pop(); 

				/* If the popped element is smaller than 
				next, then a) print the pair b) keep 
				popping while elements are smaller and 
				stack is not empty */
				while (element < next) 
				{ 
					Console.WriteLine(element + " --> " + next); 
					if (s.Empty == true) 
					{ 
						break; 
					} 
					element = s.pop(); 
				} 

				/* If element is greater than next, then 
				push the element back */
				if (element > next) 
				{ 
					s.push(element); 
				} 
			} 

			/* push next to stack so that we can find next 
			greater for it */
			s.push(next); 
		} 

		/* After iterating over the loop, the remaining 
		elements in stack do not have the next greater 
		element, so print -1 for them */
		while (s.Empty == false) 
		{ 
			element = s.pop(); 
			next = -1; 
			Console.WriteLine(element + " -- " + next); 
		} 
	} 

	public static void Main(string[] args) 
	{ 
		int[] arr = new int[] {11, 13, 21, 3}; 
		int n = arr.Length; 
		printNGE(arr, n); 
	} 
} 

// This code is contributed by Shrikant13 
