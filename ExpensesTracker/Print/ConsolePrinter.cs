﻿using System;
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
            Console.WriteLine("1. Incomes");
            Console.WriteLine("2. Expenses");
            Console.WriteLine("3. Budget Print");
            Console.WriteLine("4. Close");
          
        }

      
        public void Budget(Budget budget)
        {
            this.PrintLine(53);
            this.PrintTotal(budget);
            this.PrintLine(53);
            this.PrintBudget(budget);
            this.PrintLine(53);
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

        private void PrintTotal(Budget budget)
        {
            Console.WriteLine($"TOTAL {budget.Name.ToUpper()}: {budget.Total()} $.");
            
        }

        private void PrintBudget(Budget budget)
        {
            for (int i = 0; i < budget.Count; i++)
            {
                string financeDescription = budget.GetFinanceDescriptions()[i];
                decimal financeValue = budget.GetFinanceValues()[i];
                Console.WriteLine($"Value: {financeValue} Description: {financeDescription}");
            }
        }

    }
}
