using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Models;

namespace ExpensesTracker.Contracts
{
    interface IBudget
    {
        string Name { get; }

        int Count { get; }

        string Add(Finance finance);

        string Delete(string description);

        decimal Total();

        List<string> GetFinanceCategory();

        List<decimal> GetFinanceValues();


    }
}
