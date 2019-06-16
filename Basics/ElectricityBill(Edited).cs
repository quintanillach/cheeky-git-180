/* C# program  to calculate and print the Electricity bill of a given customer.
 * Source: W3 Resource
 * Source Author: N/A
 * Source URL: https://www.w3resource.com/csharp-exercises/conditional-statement/csharp-conditional-statement-exercise-18.php
 * Date Accessed: 04/12/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basics
{
    public class ElectricityBill
    {
        static void Main(string[] args)
        {
            // Renamed the variables using common language for clarity
            // Refactored all variables aside from custID and custName
            // as decimal types for precision since program deals with
            // finances and requires precision
            int custID;
            decimal amountConsumed, energyCharge, subtotal = 0, surcharge, total;
            string custName;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Calculate Electricity Bill");
            Console.WriteLine("----------------------------\n");

            // Added type of unit for realism
            // The program displays a request for the customer's information
            // and total consumption to calculate the bill
            // The input is converted to the appropriate numerical type
            // and assigned to the variables above
            Console.Write("Input Customer ID : ");
            custID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer : ");
            custName = Console.ReadLine();
            Console.Write("Input amount of electricity consumed by the customer (kwH) : ");
            amountConsumed = Convert.ToDecimal(Console.ReadLine());

            // Added curly braces for readability
            // Added M suffix to explicitly convert numbers from the default
            // double to the decimal type
            // This if-else statement determines subtotal of the bill on a
            // tiered charge depending on total consumption
            if (amountConsumed < 200)
            {
                energyCharge = 1.20M;
            }
            else if (amountConsumed >= 200 && amountConsumed < 400)
            {
                energyCharge = 1.50M;
            }
            else if (amountConsumed >= 400 && amountConsumed < 600)
            {
                energyCharge = 1.80M;
            }
            else
            {
                energyCharge = 2.00M;
            }

            surcharge = amountConsumed * energyCharge;

            if (surcharge > 300)
            {
                subtotal = (surcharge * 15M) / 100.0M;
            }

            total = surcharge + subtotal;

            if (total < 100)
            {
                total = 100;
            }

            // Implemented string interpolation for concision
            // Added spaces and used Console.WriteLine instead of Console.Write
            // This final segment prints the important elements a customer
            // might want to know
            Console.WriteLine("Electricity Bill");
            Console.WriteLine($"Customer IDNO                       : {custID}");
            Console.WriteLine($"Customer Name                       : {custName}");
            Console.WriteLine($"Units (kwH) Consumed                : {amountConsumed}");
            Console.WriteLine($"Amount Charges @Rs. {energyCharge}  per kwH   : {surcharge}");
            Console.WriteLine($"Surchage Amount                     : {subtotal}");
            Console.WriteLine($"Net Amount Paid By the Customer     : {total}");
        }
    }
}