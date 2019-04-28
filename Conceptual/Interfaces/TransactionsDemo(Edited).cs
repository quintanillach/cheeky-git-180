/*
 * C# program to demonstrate transactions using interface
 * Source: Sanfoundry
 * Source Author: Manish Bhojasia
 * Source URL: https://www.sanfoundry.com/csharp-program-transactions-interface/
 * Date Accessed: 04/19/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    // The ITransactions interface declares body-less
    // methods for the inheriting class to implement
    public interface ITransactions
    {
        void ShowTransaction();
        decimal GetAmount();
    }

    public class Transaction : ITransactions
    {
        // Encapsulated the fields and used properties for
        // additional protection
        // Refactored transactionAmount as a decimal type for precision

        private string transactionID;
        private string transactionDate;
        private decimal transactionAmount;

        public string TransactionID { get => transactionID; set => transactionID = value; }
        public string TransactionDate { get => transactionDate; set => transactionDate = value; }
        public decimal TransactionAmount { get => transactionAmount; set => transactionAmount = value; }

        // The default constructor contains empty strings
        // and a zero dollar amount decimal if no parameters are passed
        public Transaction()
        {
            TransactionID = " ";
            TransactionDate = " ";
            TransactionAmount = 0.0M;
        }

        // If the caller passes parameters, the alternate
        // constructor is instantiated and the
        // values are assigned to the properties
        public Transaction(string c, string d, decimal a)
        {
            TransactionID = c;
            TransactionDate = d;
            TransactionAmount = a;
        }

        // The GetAmount method returns the value of the TransactionAmount property
        public decimal GetAmount()
        {
            return TransactionAmount;
        }

        // The ShowTransaction method prints the details
        // of the transaction to the console
        public void ShowTransaction()
        {
            Console.WriteLine($"Transaction ID:     {TransactionID}");
            Console.WriteLine($"Date:               {TransactionDate}");
            Console.WriteLine($"Amount:             {GetAmount()}\n");

        }

    }

    public class TransactionDemo
    {
        public static void Main(string[] args)
        {
            // Added a title block
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Program to Demonstrate Financial Transactions");
            Console.WriteLine("----------------------------------------------\n");



            // The alternate constructor is instantiated and the
            // specified values are passed to the constructor
            Transaction transaction1 = new Transaction("001", "06/24/2018", 87900.00M);
            Transaction transaction2 = new Transaction("002", "06/25/2018", 51900.00M);

            // Each transaction is printed
            transaction1.ShowTransaction();
            transaction2.ShowTransaction();
            Console.ReadKey();
        }
    }
}
