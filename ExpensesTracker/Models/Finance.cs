using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Core;

namespace ExpensesTracker.Models
{
    class Finance : IFinance
    {

        public string ID { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }


        public Finance(decimal value, string category)
        {
            this.Value = value;
            this.Category = category;
            this.ID = GenerateUniqueID();
        }

        public static Finance Create(string category)
        {
                Console.Write("Value: ");
                decimal value = decimal.Parse(Console.ReadLine());
                Finance finance = new Finance(value, category);
                return finance;
        }

        private static string GenerateUniqueID()
        {
            return Guid
                .NewGuid()
                .ToString()
                .Substring(0, 4);
        }



    }
}
