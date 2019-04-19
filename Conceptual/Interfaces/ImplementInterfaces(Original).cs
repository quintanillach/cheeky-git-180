/*
 * C# program to illustrate the interface 
 * Source: GeeksForGeeks
 * Source Author: Mithun Kumar
 * Source URL: https://www.geeksforgeeks.org/c-sharp-interface//
 * Date Accessed: 04/19/2019
 */
 
 using System;
 
 namespace Interfaces
 {
    public interface Vehicle
    { 
        // These are abstract methods which do not
        // method bodies and forces the derived class
        // to override the abstract methods (known as dynamic polymorphism)
        // Added the public access modifier to give access to the interface
        // outside of the current assembly
        void ChangeGear(int a); 
        void SpeedUp(int a); 
        void ApplyBrakes(int a); 
    }

    // The Bicycle class inherits from the Vehicle interface
    // The derived class must contain the methods inside the
    // interface to "fulfill the contract"
    // Added the public access modifier for potential testing
    // Renamed methods using Pascal case
    public class Bicycle : Vehicle
    {
        // These integers are used as fields to allow each
        // of the methods to write to memory within the class
        // and use consistent values without using redundant code
        int speed; 
        int gear; 

        // Each of these methods override the abstract methods
        // by declaring a parameter variable and assigning value
        // to the local fields based on parameters passed from
        // the Main() method
        public void ChangeGear(int newGear) => gear = newGear;

        public void SpeedUp(int increment) => speed = speed + increment;

        public void ApplyBrakes(int decrement) => speed = speed - decrement;
        
        // Used string interpolation for readability
        public void printStates() => Console.WriteLine($"speed: {speed} \n gear: {gear}");
    }

    // Both the Scooter and the Bicycle class are derived
    // from the Vehicle interface. Both classes  fulfill
    // the contract in the same way but are two separate
    // objects.
    public class Scooter : Vehicle
    { 
        int speed; 
        int gear; 

        public void ChangeGear(int newGear) => gear = newGear; 

        public void SpeedUp(int increment) => speed = speed + increment; 

        public void ApplyBrakes(int decrement) => speed = speed - decrement;

        public void printStates() => Console.WriteLine($"speed: {speed} \n gear: {gear}");
    }

     public class VehicleState
     { 
        public static void Main(String []args) 
        { 
            // Instantiate the an object 'bicycle' using
            // the default constructor for the Bicycle class
            // The parameters for each method inside the class
            // are passed using literals
            Bicycle bicycle = new Bicycle(); 
            bicycle.ChangeGear(2); 
            bicycle.SpeedUp(3); 
            bicycle.ApplyBrakes(1); 

            Console.WriteLine("Bicycle present state :"); 
            bicycle.printStates(); 

            Scooter scooter = new Scooter(); 
            scooter.ChangeGear(1); 
            scooter.SpeedUp(4); 
            scooter.ApplyBrakes(3); 

            Console.WriteLine("Scooter present state :"); 
            scooter.printStates(); 
        } 
     } 
}
