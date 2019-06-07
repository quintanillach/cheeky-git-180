/*
 * C# Program to illustrate factory design pattern using credit unions
 * Source: LinkedIn Learning
 * Source Author: Reynald Adolphe
 * Source URL: https://www.linkedin.com/learning/c-sharp-design-patterns-part-1/code-the-factory-pattern
 * Date Accessed: 04/30/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class CreditUnionFactory    
    {
        static void Main(string[] args)
        {
            // The var keyword lets the compiler determine the data type
            // of the SavingsAcctFactory object being instantiated.
            // The as keyword acts as a cast conversion of the SavingsAcctFactory
            // to the ICreditUnionFactory ref type
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;

            // A bank account object is instantiated with an
            // account number parameter containing CITI
            // which is passed to the SavingsAcctFactory Method
            var citiAcct = factory.GetSavingsAccount("CITI-321");

            // A bank account object is instantiated with an
            // account number parameter containing NATIONAL
            // which is passed to the SavingsAcctFactory Method
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            // The Balance property is passed back to the Main method
            // and returns the unique balances of each bank account
            Console.WriteLine($"My citi balance is {citiAcct.Balance} and national balance is {nationalAcct.Balance}");
        }

    }

    // The ISavingsAccount is the base class for the program
    // and contains the Balance field and property
    // Changed the property to a backing field and property implementation
    public abstract class ISavingsAccount
    {
        private decimal _balance;

        public decimal Balance { get => _balance; set => _balance = value; }
    }

    // The CitiSavingsAcct class inherits from the ISavingsAccount
    // and provides a value for the Balance propery
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // The NationalSavingsAcct class also inherits from the ISavingsAccount
    // and provides its own unique value for the Balance property
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // THe ICreditUnionFactory declares a method
    // of the ISavingsAccount type with the account number as the parameter
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // THe SavingsAcctFactory class inherits from the ICreditUnionFactory interface
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            // The if-else statement checks the account number passed by the caller
            // for text which indicates the bank account owner
            // and calls the appropriate method based on the text
            // to return the account information to the caller
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingsAcct();
            }

            else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingsAcct();
            }
            // The last else statement throws an exception if the
            // account number passed by the caller is not a valid account number
            else
            {
                throw new ArgumentException("Invalid Account Number");
            }
        }
    }


}
