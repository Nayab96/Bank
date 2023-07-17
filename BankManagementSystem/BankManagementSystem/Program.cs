using Microsoft.Win32.SafeHandles;

namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //an object of bank account is created
            Bank bank = new Bank();

            //different types of bank accounts are added. 
            SavingAccount account1 = new SavingAccount("Laila", 54321, 200);
            CheckingAccount account2 = new CheckingAccount("Ameema", 23456, 100);
            //bank accounts are added to the dictionary
            bank.AccountDictionary(54321, account1);
            bank.AccountDictionary(23456, account2);
            //here the key is used to search for account details
            bank.SearchAccountDetails(23456);

            //a deposit is made in account
            account2.Deposit();










            Console.ReadLine();
        }
    }
}