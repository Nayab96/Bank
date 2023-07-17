using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    internal abstract class BankAccount : IBankAccount // This is the parent class, from which other bank account classes are derived. it implements the IBankAccount interface and shows the concept of inheritence. 
    {

        public string name { get; set; }
        public int accNo { get; set; }
        public double accBal { get; set; }

        public double interest;
        public int interestRate;

        public BankAccount(string aName, int aAccNo, double aAccBal) // Constructors demonstrate encapsulation e.g. wrapping up data.
        {
            name = aName;
            accNo = aAccNo;
            accBal = aAccBal;
        }
        public abstract void Deposit();  // The deposit and withdraw methods are implemented via IBankAccount and kept abstract.
        public abstract void Withdraw();
        public abstract void DisplayAccountInfo(); //abstracr methods have empty bodies, which are overriden by child classes.
        public abstract void CalculateInterest();

    }
}
