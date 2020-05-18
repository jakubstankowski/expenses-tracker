using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
     class Incomes: Finance, IFinance
    {
        public Incomes(decimal value, string description)
            : base(value, description)
        {
        }



    }
}
