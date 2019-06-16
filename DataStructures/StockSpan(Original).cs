/*
 * C# solution to stock span problem
 * Source: Geeks for Geeks
 * Source Author: Arnab Kundu
 * Source URL: https://www.geeksforgeeks.org/the-stock-span-problem/
 * Date Accessed: 04/30/2019
 */

using System; 
using System.Collections; 
  
class GFG { 
    // a linear time solution for 
    // stock span problem A stack 
    // based efficient method to calculate 
    // stock span values 
    static void calculateSpan(int[] price, int n, int[] S) 
    { 
        // Create a stack and Push 
        // index of first element to it 
        Stack st = new Stack(); 
        st.Push(0); 
  
        // Span value of first 
        // element is always 1 
        S[0] = 1; 
  
        // Calculate span values 
        // for rest of the elements 
        for (int i = 1; i < n; i++) { 
  
            // Pop elements from stack 
            // while stack is not empty 
            // and top of stack is smaller 
            // than price[i] 
            while (st.Count > 0 && price[(int)st.Peek()] <= price[i]) 
                st.Pop(); 
  
            // If stack becomes empty, then price[i] is 
            // greater than all elements on left of it, i.e., 
            // price[0], price[1], ..price[i-1]. Else price[i] 
            // is greater than elements after top of stack 
            S[i] = (st.Count == 0) ? (i + 1) : (i - (int)st.Peek()); 
  
            // Push this element to stack 
            st.Push(i); 
        } 
    } 
  
    // A utility function to print elements of array 
    static void printArray(int[] arr) 
    { 
        for (int i = 0; i < arr.Length; i++) 
            Console.Write(arr[i] + " "); 
    } 
  
    // Driver method 
    public static void Main(String[] args) 
    { 
        int[] price = { 10, 4, 5, 90, 120, 80 }; 
        int n = price.Length; 
        int[] S = new int[n]; 
  
        // Fill the span values in array S[] 
        calculateSpan(price, n, S); 
  
        // print the calculated span values 
        printArray(S); 
    } 
} 
  
// This code is contributed by Arnab Kundu 