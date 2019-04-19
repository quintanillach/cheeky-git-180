/*
 * C# program to illustrate the concept of Interface References
 * Source: GeeksForGeeks
 * Source Author: ankita_saini
 * Source URL: https://www.geeksforgeeks.org/c-sharp-how-to-use-interface-references/
 * Date Accessed: 04/19/2019
 */
 
using System; 

namespace Interfaces
{
    // Added public access modifier for access outside of assembly
    // Renamed the methods using Pascal case
    public interface Vehicle
    {
        // These are abstract methods which are methods
        // without bodies. Derived classes must override
        // these methods for the code to compile. These methods
        // act as the conditions of the contract for the derived
        // classes to fulfill
        void ChangeGear(int a);
        void SpeedUp(int a);
        void ApplyBrakes(int a);
        void PrintStates();
    }

    // Implemented expression-bodied members for terseness
    // Used string interpolation instead of concatenation
    public class Bicycle : Vehicle
    {
        int speed;
        int gear;

        public void ChangeGear(int newGear) => gear = newGear;

        public void SpeedUp(int increment) => speed = speed + increment;

        public void ApplyBrakes(int decrement) => speed = speed - decrement;

        public void PrintStates() => Console.WriteLine($"speed: {speed} gear: {gear}");
    }

    // Renamed the class for clarity
    public class VehicleState
    { 
        public static void Main(String[] args)
        {
            // Instantiate object 'bicycle' using default
            // constructor for Bicycle()
            Bicycle bicycle = new Bicycle();

            // Declare a object 'obj' which references
            // the Vehicle interface and copy the value
            // of 'obj' to the 'bicycle' object above
            // This means any parameters passed through the methods
            // are first assigned to the 'obj' object then
            // copied to the reference address of 'bicycle'
            // rather than directly passing values to the 'bicycle' object
            Vehicle obj;
            obj = bicycle;

            obj.ChangeGear(4);
            obj.SpeedUp(5);
            obj.ApplyBrakes(2);

            Console.WriteLine("Bicycle Present State:");

            obj.PrintStates(); 
        } 
    } 
}