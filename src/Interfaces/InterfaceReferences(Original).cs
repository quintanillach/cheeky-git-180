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
  // interface declaration 
  interface Vehicle { 

    // all are the abstract methods. 
    void changeGear(int a); 
    void speedUp(int a); 
    void applyBrakes(int a); 
    void printStates(); 
  } 

  // class implements interface 
  class Bicycle : Vehicle { 

    int speed; 
    int gear; 

    // to change gear 
    public void changeGear(int newGear) 
    { 

      gear = newGear; 
    } 

    // to increase speed 
    public void speedUp(int increment) 
    { 

      speed = speed + increment; 
    } 

    // to decrease speed 
    public void applyBrakes(int decrement) 
    { 

      speed = speed - decrement; 
    } 

    public void printStates() 
    { 
      Console.WriteLine("speed: " + speed + " gear: " + gear); 
    } 
  } 

  // Driver Class 
  class GFG { 

    // Main Method 
    public static void Main(String[] args) 
    { 

      // creating an instance of Bicycle 
      Bicycle bicycle = new Bicycle(); 

      // Creating interface references 
      Vehicle obj; 

      // assigning Bicycle object 'bicycle' 
      // to interface Reference 'obj' 
      obj = bicycle; 

      // calling the abstract methods 
      // implemented by class Bicycle 
      obj.changeGear(4); 
      obj.speedUp(5); 
      obj.applyBrakes(2); 

      Console.WriteLine("Bicycle Present State:"); 

      // calling the method of class Bicycle 
      obj.printStates(); 
    } 
  } 
}  
