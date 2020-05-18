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
            Console.WriteLine("Chose option:");
            Console.WriteLine("1. Set your money");
            Console.WriteLine("2. Set expenses");
            Console.WriteLine("3. Budget Print");
            Console.WriteLine("4. Close");
          
        }

      
        public void Budget(Budget budget, decimal incomesTotal)
        {
            throw new NotImplementedException();
        }

       
        public void SubMenu()
        {
            Console.WriteLine("Chose option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Back");
        }

        public void Total(Budget budget)
        {
            Console.WriteLine($"Total: {budget.Total()} $");
        }

        public void PrintLine(int width)
        {
            Console.WriteLine($"+{new string('-', width)}+");
        }

        public void WholeBudget(Budget incomes, Budget expenses, decimal balance)
        {
            Console.WriteLine("Total balance: " + balance);
        }
    }
}
