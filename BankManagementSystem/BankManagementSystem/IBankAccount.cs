using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    internal interface IBankAccount  //Interface is an example of polymorphism. Here we have declared it. 
    {
        void Deposit();
        void Withdraw();
    }
}
