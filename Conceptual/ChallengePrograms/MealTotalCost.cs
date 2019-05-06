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

class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        double m = meal_cost;
        double p = (m * tip_percent) / 100;
        double x = (m * tax_percent) / 100;
        double total_cost = m + p + x;
        int answer = (int) Math.Round(total_cost);
        Console.WriteLine(answer);
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}