/*
 * C# program to calculate total meal cost including tax and tip
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/30-operators/problem
 * Date Accessed: 04/06/2019
 */

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ChallengePrograms
{
    public class MealTotalCost 
    {
        public static void Calculate(double meal_cost, int tip_percent, double tax_percent) 
        {
            // Parameters are saved to local variables
            double m = meal_cost;
            
            // The tip and tax are calculated against the given
            // meal cost
            double p = (m * tip_percent) / 100;
            double x = (m * tax_percent) / 100;
            
            // Local variables are summed up
            // to return total meal cost
            double total_cost = m + p + x;
            
            // Print the total cost to the appropriate
            // numeric format of two decimal places 
            Console.WriteLine($"\nTip - {p}\nTax - {x:F2}\nFinal Cost - {total_cost:F2}");
        }

        public static void Main(string[] args) 
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Challenge program to calculate total meal cost including tax and tip");
            Console.WriteLine("----------------------------------------------------------------------\n");
            
            // User input as string and converted to numeric
            // data types for calculation using TryParse
            Console.WriteLine("Enter the meal cost :");
            string input1 = (Console.ReadLine());
            double.TryParse(input1, out double meal_cost);
            
            Console.WriteLine("Enter the tip as a percentage of the meal cost :");
            string input2 = (Console.ReadLine());
            int.TryParse(input2, out int tip_percent);

            Console.WriteLine("Enter the local sales tax as a percentage:");
            string input3 = (Console.ReadLine());
            double.TryParse(input3, out double tax_percent);
            
            // The Calculate method is called and the user input
            // is passed as arguments
            Calculate(meal_cost, tip_percent, tax_percent);
        }
    }
}
