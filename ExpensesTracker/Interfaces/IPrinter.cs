using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Core;

namespace ExpensesTracker.Contracts
{
    interface IPrinter
    {
        void Total(Budget budget);

        void WholeBudget(Budget incomes, Budget expenses, decimal balance);
    }
}
