using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
    class Expenses : Finance, IFinance
    {

       
        Expenses(decimal value, string description): base(value, description)
        {
           

        }
        


    }
}
