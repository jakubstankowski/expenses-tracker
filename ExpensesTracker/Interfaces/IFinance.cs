using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Contracts
{
    interface IFinance
    {
        decimal Value { get; set; }
        string Category { get; set; }
    }
}
