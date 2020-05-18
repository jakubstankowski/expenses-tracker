using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Core;

namespace ExpensesTracker.Models
{
    class Finance : IFinance
    {

        public decimal Value { get; set; }
        public string Category { get; set; }

        public static List<string> incomesCategory = new List<string> { "work", "other" };

        public Finance(decimal value, string category)
        {
            this.Value = value;
            this.Category = category;
        }

        public static Finance Create(string category)
        {
                Console.Write("Value: ");
                decimal value = decimal.Parse(Console.ReadLine());
                Finance finance = new Finance(value, category);
                return finance;
        }

      



    }
}
