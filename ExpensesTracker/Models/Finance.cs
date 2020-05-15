using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
    class Finance : IFinance
    {
            
        public double Value { get; set; }
        public string Description { get; set; }


        public Finance(double value, string description)
        {
            this.Value = value;
            this.Description = description;
        }

        public static Finance Create()
        {

           
                 Console.Write("Value: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Description: ");
                string description = Console.ReadLine();
                Finance finance = new Finance(value, description);
                return finance;
           
           
        }



    }
}
