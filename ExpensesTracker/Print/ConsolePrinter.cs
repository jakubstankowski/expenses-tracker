using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Core;

namespace ExpensesTracker.Print
{
    class ConsolePrinter: IMenuPrinter, IPrinter
    {
        public  void Menu()
        {
            Console.WriteLine("Welcome to expenses tracker!");
            Console.WriteLine("1. Set your money");
            Console.WriteLine("2. Exit program");
          
        }

      
        public void Budget(Budget budget, decimal incomesTotal)
        {
            throw new NotImplementedException();
        }

       
        public void SubMenu()
        {
            throw new NotImplementedException();
        }

        public void Total(Budget budget)
        {
            Console.WriteLine($"Total: {budget.Total()} $");
        }
    }
}
