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
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Incomes");
            Console.WriteLine("2. Expenses");
            Console.WriteLine("3. Budget Print");
            Console.WriteLine("4. Load Template Budget");
            Console.WriteLine("5. Close");
          
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
            
           
            this.Budget(incomes);
            this.Budget(expenses);
            this.Balance(balance);

        }

        private void Balance(decimal balance)
        {
            Console.WriteLine("TOTAL BALANCE: " + balance);
            this.PrintLine(53);
        }

        private void PrintTotal(Budget budget)
        {
            Console.WriteLine($"TOTAL {budget.Name.ToUpper()}: {budget.Total()} $.");
            
        }

        private void PrintBudget(Budget budget)
        {
            for (int i = 0; i < budget.Count; i++)
            {
                string financeID = budget.GetFinanceID()[i];
                string financeCategory = budget.GetFinanceCategory()[i];
                decimal financeValue = budget.GetFinanceValues()[i];
                Console.WriteLine($"ID: {financeID} | Value: {financeValue} | Category: {financeCategory}");
            }
        }

        public void CategoryMenu(string type)
        {
           if(type == "incomes")
            {
                IncomesCategory();
            } else
            {
                ExpensesCategory();
            }

        }

        public void ExpensesCategory()
        {
            Console.WriteLine("Choose expenses category: ");
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Home");
            Console.WriteLine("3. Transport");
            Console.WriteLine("4. Shopping");
            Console.WriteLine("5. Hobby");
            Console.WriteLine("6. Family");
            Console.WriteLine("7. Health");
            Console.WriteLine("8. Car");
            Console.WriteLine("9. Others");
            Console.WriteLine("0. Back");
        }
        public void IncomesCategory()
        {
            Console.WriteLine("Choose incomes category: ");
            Console.WriteLine("1. Work");
            Console.WriteLine("2. Other");
            Console.WriteLine("3. Back");
         }

       
    }
}
