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

        public static void  Create()
        {
            Console.WriteLine("INCOMES!");
           /* Console.Write("Value: ");
            decimal value = decimal.Parse(Console.ReadLine());
            Console.Write("Description: ");
            string category = Console.ReadLine();
            Expenses expense = new Expenses(value, category);
            return expense;*/
        }



    }
}
