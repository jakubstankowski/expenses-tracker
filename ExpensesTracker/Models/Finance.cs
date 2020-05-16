using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
    class Finance : IFinance
    {
            
        public decimal Value { get; set; }
        public string Description { get; set; }


        public Finance(decimal value, string description)
        {
            this.Value = value;
            this.Description = description;
        }

        public static Finance Create()
        {
                Console.Write("Value: ");
                decimal value = decimal.Parse(Console.ReadLine());
                Console.Write("Description: ");
                string description = Console.ReadLine();
                Finance finance = new Finance(value, description);
                return finance;
        }



    }
}
