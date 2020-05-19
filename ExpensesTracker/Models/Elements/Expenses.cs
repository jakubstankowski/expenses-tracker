using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
    class Expenses : Finance, IFinance
    {

       
        Expenses(decimal value, string category): base(value, category)
        {}

        public static List<Expenses> Template()
        {
            List<Expenses> template = new List<Expenses>
            {
                new Expenses(1200, "work"),
                new Expenses(5000, "home"),
                new Expenses(2000, "transport"),
                new Expenses(3000, "hobby"),
                new Expenses(3000, "food"),
                new Expenses(2000, "others")
            };

            return template;
        }
        


    }
}
