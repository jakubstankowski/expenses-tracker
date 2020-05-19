using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Contracts
{
    interface IFinance
    {
        string ID { get; set; }
        decimal Value { get; set; }
        string Category { get; set; }
    }
}
