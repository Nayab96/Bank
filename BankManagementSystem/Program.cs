using System;

namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //an object of bank account is created
            Bank bank = new Bank();

            //different types of bank accounts are added. 
            SavingAccount account1 = new SavingAccount("Laila", 54321, 100);
            CheckingAccount account2 = new CheckingAccount("Ameema", 23456, 100);
            LoanAccount account3 = new LoanAccount("Nayab", 23467, 700);

            //Add Bank accounts in bank list
            bank.AddBankAccount(account1);
            bank.AddBankAccount(account2);
            bank.AddBankAccount(account3);

            //let's see the list of accounts in our bank!
            bank.DisplayAccountList();

            //bank accounts are added to the dictionary
            bank.AccountDictionary(54321, account1);
            bank.AccountDictionary(23456, account2);
            //here the key is used to search for account details
            bank.SearchAccountDetails(23456);


            //Here we calculate interests for each bank account
            account1.CalculateInterest();
            account2.CalculateInterest();
            account3.CalculateInterest();

            //here we execute a transactions for every account, which will call withdraw or deposit method depending on what user selects.
            account1.ExecuteTransaction();
            account2.ExecuteTransaction();
            account3.ExecuteTransaction();

            //Let's see transaction History with this method
            account1.Transactionhistory();
       

            Console.ReadLine();
        }
    }
}
