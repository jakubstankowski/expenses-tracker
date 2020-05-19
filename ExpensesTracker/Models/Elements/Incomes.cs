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

       public static List<Incomes> Template()
        {
            List<Incomes> template = new List<Incomes>
            {
                new Incomes(12000, "work"),
                new Incomes(3000, "others"),
            };

            return template;
        } 



    }
}
