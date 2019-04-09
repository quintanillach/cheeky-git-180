/* C# Program to implement a method that returns a structure including calling the method and using its value.
 * Source: W3Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/structure/csharp-structure-exercise-10.php
 * Date Accessed: 04/07/2019
 */
 
using System;

public struct sampStru
{
    private double val;
    public double Value
    {
        get { return val; }
        set { val = value; }
    }
    public double Read()
    {
        return double.Parse(Console.ReadLine());
    }
}
public struct Square
{
    sampStru ln;
    sampStru ht;

    public sampStru Length
    {
        get { return ln; }
        set { ln = value; }
    }
    public sampStru Breadth
    {
        get { return ht; }
        set { ht = value; }
    }
    public void newSquare()
    {
        sampStru rct = new sampStru();

        Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
        ln = sqrLength();
        Console.Write("breadth : ");
        ht.Value = rct.Read();
    }
    public sampStru sqrLength()
    {
        sampStru rct = new sampStru();

        Console.Write("length : ");
        rct.Value = rct.Read();
        return rct;
    }
}
public class strucExer10
{
    static void Main()
    {
		Console.Write("\n\nMethod that returns a structure  :\n");
		Console.Write("--------------------------------------\n");
        var Sqre = new Square();
        Sqre.newSquare();
        Console.WriteLine();
        Console.WriteLine("Perimeter and Area of the square :");
        Console.WriteLine("Length:    {0}", Sqre.Length.Value);
        Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
        Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
        Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
    }
}
