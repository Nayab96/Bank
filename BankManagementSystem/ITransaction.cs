using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal interface ITransaction // Interface to be implemented in different classes.
    {

        void ExecuteTransaction();
        void PrintTransaction();

    }
}
