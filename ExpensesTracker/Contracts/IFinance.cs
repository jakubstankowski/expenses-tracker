using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Contracts
{
    interface IFinance
    {
        double Value { get; set; }
        string Description { get; set; }
    }
}
