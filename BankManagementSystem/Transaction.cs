using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    class Transaction
    {
        public double amount { set; get; }
        public string type { set; get; }
        public DateTime DT { set; get; }


        public Transaction(double aAmount, string aType, DateTime aDT)
        {
            amount = aAmount;
            type = aType;
            DT = aDT;
        }
    }

    
}
