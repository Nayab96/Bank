using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class Bank
    {
        // List<BankAccount> bankaccounts = new List<BankAccount>();


        public List<BankAccount> bankaccounts;

        public Dictionary<int, BankAccount> accountdictionary;


        public Bank()
        {
            bankaccounts = new List<BankAccount>();  //Declaration of dictionary and list
            accountdictionary = new Dictionary<int, BankAccount>();
        }



        public void AddBankAccount(BankAccount account) //this method is used to add bank account object to the list
        {
            bankaccounts.Add(account);
            Console.WriteLine(" A new account with account number "+ account.accNo + " has been added");
        }
        public void DepositToAccount()
        {
            foreach (var BankAccount in bankaccounts)
            {
                BankAccount.Deposit();
            }
        }
        public void WithdrawFromAccount()
        {
            foreach (var BankAccount in bankaccounts)
            {
                BankAccount.Withdraw();
            }
        }

        public void DisplayAccountList() // this method displays the list of accounts
        {

            foreach (BankAccount account in bankaccounts)
            {
                Console.Write($"\nAccount Name: {account.name} --- Account Number: {account.accNo} --- Account Balance: {account.accBal}");

            }
        }

        public void AccountDictionary(int accNo, BankAccount account) // this method adds the key and value to the dictionary for saving
        {
            accountdictionary.Add(accNo, account);
        }
        public void SearchAccountDetails(int accNo) // this method takes a key e.g. acc no and shows the account details as values.
        {

            //foreach (KeyValuePair<int, string> item in accountdictionary)

            //foreach (int Key in accountdictionary.Keys)


            //Console.WriteLine("\n\nKey: " +item.Key + "\nValue: " +item.Value);
            BankAccount Value = accountdictionary[accNo];

            Console.WriteLine("\n\nThe details for Account No.:" + accNo + " are as follows:");
            Value.DisplayAccountInfo();



        }
    }
}
