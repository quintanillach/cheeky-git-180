/*
 * C# program to define a sealed class
 * Source Author: Geeks for Geeks
 * Source URL: https://www.geeksforgeeks.org/c-sharp-sealed-class/
 * Date Accessed: 04/26/2019
 */

using System;

namespace Basics
{
    // The base class Printer contains the methods
    // for the deriving class to implement with virtual
    // access modifiers to enable overriding
    public class Printer
    {
        public virtual void Show()
        {
            Console.WriteLine("Dimensions : 6 x 6");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printing jobs...\n");
        }
    }
 
    // The LaserJet class inherits from the Printer class
    public class LaserJet : Printer
    {
        // The Show method overrides the base class implementation
        // and uses the sealed access modifier to prevent any classes
        // derived from the LaserJet class from overriding this method
        public sealed override void Show()
        {
            Console.WriteLine("Dimensions : 12 x 12");
        }

        // The default print message is overrode
        public override void Print()
        {
            Console.WriteLine("Printing jobs from LaserJet...\n");
        }
    }

    // The OfficeJet class inherits from the LaserJet
    public class OfficeJet : LaserJet
    {
        // Only the Print method is overrode
        // and the Show method is simply inherited
        // from the LaserJet class
        public override void Print()
        {
            Console.WriteLine("Printing jobs from OfficeJet...\n");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Printer defaultPrinter = new Printer();
            defaultPrinter.Show();
            defaultPrinter.Print();

            Printer laserPrinter = new LaserJet();
            laserPrinter.Show();
            laserPrinter.Print();

            Printer inkPrinter = new OfficeJet();
            inkPrinter.Show();
            inkPrinter.Print();
        }
    }
}