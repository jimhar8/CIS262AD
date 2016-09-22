using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CS3  BankAccount Inheritance - Jim Harris
/*
Use the base abstract class BankAccount to create a CheckingAccount
and SavingsAccount class with different withdrawal rules.

*/

namespace CS3
{
    //BankAccount - Base Abstract class with abstract withdraw method
    public abstract class BankAccount
    {

        protected decimal decBalance;

        public decimal Balance
        {
            get { return decBalance; }
            set { decBalance = value; }
        }
        

        public BankAccount()
        {

        }

        public BankAccount(decimal balance)
        {
            this.Balance = balance;

        }

        public void deposit(decimal amount) 
        {
            this.Balance += amount;
         
        }

        public abstract int withdraw(decimal decAmt);
    }
    //SavingsAccount - Derived Class
    public class SavingsAccount : BankAccount
    {
        private decimal rate = 0.10m;

        public SavingsAccount():base()
        {

        }

        public SavingsAccount(decimal amount)
            : base(amount)
        {

        }

        public override int withdraw(decimal decAmt)
        {
            decimal decTotalTransaction = decAmt + decAmt * rate;

            if (decTotalTransaction > this.Balance)
            {
                return 1;
            }
            else
            {
                this.Balance -= decTotalTransaction;
                return 0;
            }
        }
    }

    //CheckingAccount - Derived Class
    public class CheckingAccount : BankAccount
    {
        private int numWithdrawls = 0;

        public CheckingAccount()
            : base()
        {

        }

        public CheckingAccount(decimal amount)
            : base(amount)
        {

        }

        public override int withdraw(decimal decAmt)
        {
            decimal decTotalTransaction = 0.0m;


            if (numWithdrawls >= 2)
            {
                decTotalTransaction = decAmt + 1.50m;
            }
            else
            {
                decTotalTransaction = decAmt;
            }


            if (decTotalTransaction > this.Balance)
            {
                return 1;
            }
            else
            {
                this.Balance -= decTotalTransaction;
                numWithdrawls++;
                return 0;
            }
        }
    }

    class Program
    {
        //method used to perform transactions
        static void transfer(BankAccount fromAccount, BankAccount toAccount, decimal decAmt)
        {
            int insufficientFunds;

            insufficientFunds = fromAccount.withdraw(decAmt);
            if (insufficientFunds == 1)
                Console.WriteLine("*** Transfer failed - insufficient funds *** ");
            else
                toAccount.deposit(decAmt);

            return;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("CS3 Jim Harris\n\n");

            //declare objects using overloaded constructors
            CheckingAccount checking = new CheckingAccount(100.00m);
            SavingsAccount savings = new SavingsAccount(200.00m);

            Console.WriteLine("Initial Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            //**
            Console.WriteLine("Transfer from Checking to Savings, Amount: 101.00 ");

            transfer(checking, savings, 101.00m);

            Console.WriteLine("Current Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            //**
            Console.WriteLine("Transfer from Checking to Savings, Amount: 25.00 (3 transactions) \n"
                 + "First 2 withdrawals from Checking are free; others 1.50 fee");

            transfer(checking, savings, 25.00m);
            transfer(checking, savings, 25.00m);
            transfer(checking, savings, 25.00m);

            Console.WriteLine("Current Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            //**
            Console.WriteLine("Transfer from Savings to Checking, Amount: 100.00 \n"
                 + "10% fee is $10.00, total deduction 110.00 ");

            transfer(savings, checking, 100.00m);

            Console.WriteLine("Current Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            //**
            Console.WriteLine("Transfer from Savings to Checking, Amount: 166.00 ");

            transfer(savings, checking, 166.00m);

            Console.WriteLine("Current Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            //**
            Console.WriteLine("Transfer from Checking to Savings, Amount: 123.00 + 1.50 fee.");

            transfer(checking, savings, 123.00m);

            Console.WriteLine("Current Balances");
            Console.WriteLine("  Checking: " + checking.Balance.ToString("c"));
            Console.WriteLine("  Savings: " + savings.Balance.ToString("c") + " \n\n");

            return;

        }
    }
}
