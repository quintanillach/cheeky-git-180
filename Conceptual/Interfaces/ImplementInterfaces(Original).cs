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
        public abstract void ChangeGear(int a); 
        public abstract void SpeedUp(int a); 
        public abstract void ApplyBrakes(int a); 
    }

    // The Bicycle class inherits from the Vehicle interface
    // The derived class must contain the methods inside the
    // interface to "fulfill the contract"
    // Added the public access modifier for potential testing
    // Renamed methods using Pascal case
    public class Bicycle : Vehicle
    { 
        int speed; 
        int gear; 

        // Each of these methods override the abstract methods
        // by declaring a parameter variable and assigning value
        // to the local variables based on paramters passed from
        // the Main() method
        public void ChangeGear(int newGear) 
        { 
          gear = newGear; 
        } 

        public void SpeedUp(int increment) 
        { 

          speed = speed + increment; 
        } 

        public void ApplyBrakes(int decrement) 
        { 

          speed = speed - decrement; 
        } 

        public void printStates() =>
            // Used string interpolation for readability
            // Implemented expression-bodied members for conciseness
            Console.WriteLine($"speed: {speed} \n gear: {gear}"); 
    }

      // class implements interface 
      class Bike : Vehicle { 

        int speed; 
        int gear; 

        // to change gear 
        public void ChangeGear(int newGear) 
        { 

          gear = newGear; 
        } 

        // to increase speed 
        public void SpeedUp(int increment) 
        { 

          speed = speed + increment; 
        } 

        // to decrease speed 
        public void ApplyBrakes(int decrement){ 

          speed = speed - decrement; 
        } 

        public void printStates() 
        { 
          Console.WriteLine("speed: " + speed + 
                  " gear: " + gear); 
        } 

      } 

     class GFG
     { 
        // Main Method 
        public static void Main(String []args) 
        { 

            // creating an instance of Bicycle 
            // doing some operations 
            Bicycle bicycle = new Bicycle(); 
            bicycle.ChangeGear(2); 
            bicycle.SpeedUp(3); 
            bicycle.ApplyBrakes(1); 

            Console.WriteLine("Bicycle present state :"); 
            bicycle.printStates(); 

            // creating instance of bike. 
            Bike bike = new Bike(); 
            bike.ChangeGear(1); 
            bike.SpeedUp(4); 
            bike.ApplyBrakes(3); 

            Console.WriteLine("Bike present state :"); 
            bike.printStates(); 
        } 
     } 
}
