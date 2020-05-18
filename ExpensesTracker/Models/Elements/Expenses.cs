using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;

namespace ExpensesTracker.Models
{
    class Expenses : Finance, IFinance
    {

        string  TestValue { get; set; }
        Expenses(decimal value, string description): base(value, description)
        {
            TestValue = "test value!";

        }
        public static Expenses Create()
        {
            Console.WriteLine("EXPENSESS");
            Console.Write("Value: ");
            decimal value = decimal.Parse(Console.ReadLine());
            Console.Write("Description: ");
            string category = Console.ReadLine();
            Expenses expense = new Expenses(value, category);
            return expense;
        }


    }
}
