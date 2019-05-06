/*
 * C# solution to stock span problem
 * Source: Geeks for Geeks
 * Source Author: Arnab Kundu
 * Source URL: https://www.geeksforgeeks.org/the-stock-span-problem/
 * Date Accessed: 04/30/2019
 */

using System; 
using System.Collections;

// Added namespace
// Renamed class and methods
// Renamed variables for clarity
namespace DataStructures
{
    public class StockSpan
    {
        public static void CalculateSpan(int[] stockPrices, int totalDays, int[] spanValues)
        {
            // Instantiate a Stack collection to store stock
            // value on each day
            Stack days = new Stack();
            days.Push(0);

            // Set the inital index equal to 1
            spanValues[0] = 1;

            // Iterate through the rest of the spanValues array
            for (int i = 1; i < totalDays; i++)
            {
                // Elements in the stack are popped (or removed) from the stack
                // as long as the stack is not empty and the top of the stack
                // is less than the price index
                while (days.Count > 0 && stockPrices[(int)days.Peek()] <= stockPrices[i])
                {
                    days.Pop();
                }

                // This tuple assigns a value to the elements in the spanValues array
                // If the stack is empty, then the price of the stock on the current
                // day is greater than all previous days
                // Else the current stack value is referenced as the last day when
                // the price of the index was greater than the current day evaluated
                // and the difference of days is "the span"
                spanValues[i] = (days.Count == 0) ? (i + 1) : (i - (int)days.Peek());

                // An element equal to the current iteration is pushed (added) 
                //to the stack meaning the loop resets back to the current day
                days.Push(i);
            }
        }

        // Print the space-separated values in the array
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\nSpan {i} = {arr[i]}\n");
            }
        }

        public static void Main(String[] args)
        {
            // Added title block
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("C# program to calculate the span of a stock's price given a number of days");
            Console.WriteLine("------------------------------------------------------------------------------\n");

            // Added user input
            Console.WriteLine("How many days?");
            string userInput = (Console.ReadLine());
            int.TryParse(userInput, out int totalDays);
            int[] stockPrices = new int[totalDays];

            Console.WriteLine("Enter the stock price by day : ");

            // The for loop adds elements to the array
            for (int i = 0; i < stockPrices.Length; i++)
            {
                Console.Write($"Day {i + 1} -- ");
                string s = (Console.ReadLine());
                int.TryParse(s, out int element);
                stockPrices[i] = element;
            }
            // An array the same number of elements as the stockPrices array
            // is instantiated to hold the value of the stock price span
            int[] spanValues = new int[totalDays];

            // Local variables are passed as arguments to the CalculateSpan method
            CalculateSpan(stockPrices, totalDays, spanValues);

            // PrintArray method is called to print the final array
            PrintArray(spanValues);
        }
    }
}