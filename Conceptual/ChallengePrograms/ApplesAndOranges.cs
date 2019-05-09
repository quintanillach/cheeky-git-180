/*
 * C# solution to the apples and oranges problem
 * Source: HackerRank
 * Source URL: https://www.hackerrank.com/challenges/apple-and-orange/problem
 * Date Accessed: 05/06/2019
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
    public class Solution
    {

        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            // Declare two new variables to hold
            // the number of apples and oranges that land
            // on Sam's House
            int applesOnHouse = 0, orangesOnHouse = 0;

            // For loop iterates through the apples array
            // and checks if the initial position plus
            // the distance from the tree is equal
            // to the position of the house
            for (int i = 0; i < apples.Length; i++)
            {
                if (((apples[i] + a) >= s) &&
                    ((apples[i] + a) <= t))
                {
                    applesOnHouse++;
                }
            }

            // Same purpose as previous for loop
            // but for oranges
            for (int i = 0; i < oranges.Length; i++)
            {
                if (((oranges[i] + b) >= s) &&
                    ((oranges[i] + b) <= t))
                {
                    orangesOnHouse++;
                }
            }

            // Print the final value of fruit to hit Sam's house
            Console.WriteLine($"{applesOnHouse} apples fell on the house.");
            Console.WriteLine($"{orangesOnHouse} oranges fell on the house.");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("C# Solution to the apples and oranges problem");
            Console.WriteLine("----------------------------------------------\n");

            // Split the input string into an array
            // and assign value to local variables
            Console.WriteLine("Input the space-separated integers for the start and end point of the house : ");
            string[] houseInput = Console.ReadLine().Split(' ');
            int.TryParse(houseInput[0], out int houseStart);
            int.TryParse(houseInput[1], out int houseEnd);

            Console.WriteLine("Input the space-separated integers for the apple and orange tree, respectively : ");
            string[] treePositions = Console.ReadLine().Split(' ');
            int.TryParse(treePositions[0], out int appleTree);
            int.TryParse(treePositions[1], out int orangeTree);

            Console.WriteLine("Input the space-separated integers for the number of apples and oranges that fell, respectively : ");
            string[] numberOfFruit = Console.ReadLine().Split(' ');
            int.TryParse(numberOfFruit[0], out int numberOfApples);
            int.TryParse(numberOfFruit[1], out int numberOfOranges);

            // Converts the entire line of input into
            // separate array elements and converts to integers
            Console.WriteLine("Input the space-separated integers for the distance each apple fell : ");
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            Console.WriteLine("Input the space-separated integers for the distance each orange fell : ");
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            // Pass all inputs to CountApplesAndOranges method
            CountApplesAndOranges(houseStart, houseEnd, appleTree, orangeTree, apples, oranges);
        }
    }
}