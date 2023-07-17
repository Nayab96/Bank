using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{

    internal class LoanAccount : BankAccount, ITransaction
    {

        public LoanAccount(string aName, int aAccNo, double aAccBal) : base(aName, aAccNo, aAccBal)
        {
            name = aName;
            accNo = aAccNo;
            accBal = aAccBal;
        }

        public override void CalculateInterest()
        {

            interestRate = 3;
            interest = (interestRate * accBal) / 100;
            Console.WriteLine("Annual interest on Account no. " + accNo + " and Account name i.e. " + name + " with balance i.e. " + accBal + "PKR is " + interest + "PKR");
        }

        public override void Deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit(PKR):");
            double depositN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " deposited " + depositN + "PKR");
            accBal = accBal + depositN;
            Transactiondetail(depositN, "Deposit");
            Console.WriteLine("New Balancce: " + accBal + "PKR");
            Console.ReadLine();
        }
        public override void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw (PKR):");
            double withdrawN = Convert.ToInt32(Console.ReadLine());

            if (withdrawN > accBal)
            {
                Console.WriteLine("This amount can not be withdrawn");
            }
            else
            {
                Console.WriteLine(name + " withdrew " + withdrawN + "PKR");
                accBal = accBal - withdrawN;
                Transactiondetail(withdrawN, "Withdraw");
                Console.WriteLine("New Balancce: " + accBal + "PKR");
            }
        }

        public override void DisplayAccountInfo() // this method is overriden differently for each class which shows polymorphism 
        {
            Console.WriteLine("Account Holder Name: " + name);
            Console.WriteLine("Account Type: Loan " +
                "Account");
            Console.WriteLine("Account Humber: " + accNo);
            Console.WriteLine("Account Balance: " + accBal + "PKR");
            Console.ReadLine();
        }

        public void ExecuteTransaction()  // interface implemented
        {
            Console.WriteLine("What do you want to do? (Withdraw or Deposit)");
            string x = Console.ReadLine();

            if (x == "Withdraw")
            {
                Withdraw();

            }
            else if (x == "Deposit")
            {
                Deposit();
            }
            else
            {
                Console.WriteLine("Error! Please enter Deposit or Withdraw");
            }

        }
        public void PrintTransaction()
        {
            Console.WriteLine("A transaction has been completed from your account");
        }

    }
}
