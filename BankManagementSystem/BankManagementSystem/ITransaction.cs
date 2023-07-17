using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    internal interface ITransaction // Interface to be implemented in different classes.
    {

        void ExecuteTransaction();
        void PrintTransaction();

    }
}
