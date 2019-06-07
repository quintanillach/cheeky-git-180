/*
 * C# Program to illustrate the concept of inheritance of constructors
 * Source: Geeks for Geeks
 * Source Author: ankita_saini
 * Source URL: https://www.geeksforgeeks.org/c-sharp-inheritance-in-constructors/
 * Date Accessed: 04/23/2019
 */

using System; 

// Implemented a namespace
// Refactored using expression-bodied members
// Refactored using string interpolation
// Added access modifiers for enhanced security
namespace Basics
{
    // The Tank class is declared as the base class for the program.
	public class Tank 
	{
        // These backing fields are common across each tank and contain
        // information that an user may need to know about the tank
        private double t_radius; 
		private double t_height; 

        // The constructor implements the parameters specified in the
        // signature and save them to local variables
		public Tank(double r, double h) 
		{ 
			Radius = r; 
			Height = h; 
		} 

        // These properties get and set the values of the fields above
        // and use the ternary operators to check the values passed for
        // negative numbers to invert the values if necessary
		public double Radius 
		{ 
			get { 
				return t_radius; 
				} 

			set { 
				t_radius = value < 0 ? -value : value; 
				} 
		} 

		public double Height 
		{ 
			get { 
				return t_height; 
				} 

			set { 
					t_height = value < 0 ? -value : value; 
				} 
		} 

        // The DisplayDimension method simply executes the function whenever called
		public void DisplayDimension() => 
            Console.WriteLine($"The radius of tank is : {Radius} and the height of tank is : {Height}");
	} 

    // The AreaOfTank class inherits all of the attributes of the
    // Tank class and tacks on additional logic and properties
    // specific to calculcating the area of a tank
	public class AreaOfTank : Tank 
	{ 
		private string Color; 

        // The constructor accepts the additional string parameter
        // and passes the other parameters to the base class
		public AreaOfTank(string c, double r, 
					double h) : base(r, h)
		{ 
			Color = c; 
		} 

        // Area() method calculates the area of the tank
		public double Area() 
		{ 
			return 2 * 3.14 * Radius * Height; 
		} 

		public void DisplayColor() =>
			Console.WriteLine($"The Color of tank is {Color}"); 
	}

	public class ConstructorInheritance { 

		public static void Main() 
		{
            // Added a title block and user input into the program
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Calculating the Area of a Tank");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine("Enter the color of the tank : ");
            string tankColor = (Console.ReadLine());

            // The height and radius variables are first saved to strings
            // and ran through TryParse to protect the program from unexpected input
            Console.WriteLine("\nEnter the radius of the tank : ");
            string tankRadius = (Console.ReadLine());
            double.TryParse(tankRadius, out double radius);

            Console.WriteLine("\nEnter the height of the tank : ");
            string tankHeight = (Console.ReadLine());
            double.TryParse(tankHeight, out double height);

            // The AreaOfTank object is instantiated with the appropriate
            // parameters passed to each class and returned
            AreaOfTank t1 = new AreaOfTank(tankColor, radius, height); 
			t1.DisplayColor(); 
			t1.DisplayDimension(); 
			Console.WriteLine($"\nArea of the tank is {t1.Area()}");
        } 
	} 
}