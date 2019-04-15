/*
 * C# Program Illustrate Method Hiding
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-method-hiding/
 * Date Accessed: 04/04/2019
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class Demo
    {
        public virtual double Area(double r)
        {
            return r * r;
        }
        public void Func()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class A : Demo
    {
        public override double Area(double r)
        {
 
            return base.Area(r) * r;
        }
        public new void Func()
        {
            Console.WriteLine("Derived Class");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            A o1 = new A();
            Console.WriteLine(o1.Area(20));
            o1.Func();
            Console.ReadLine();
        }
    }
}
