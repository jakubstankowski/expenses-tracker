using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Core;

namespace ExpensesTracker.Print
{
    class FilePrinter : IPrinter
    {
        public void Total(Budget budget)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string path = $"../../../{budget.Name.ToUpper()}-{year}-{month}-{day}.txt";

            File.WriteAllText(path, $"Total: {budget.Total():F2} $.");
        }

        public void WholeBudget(Budget incomes, Budget expenses, decimal balance)
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string path = $"../../../Budget-{year}-{month}-{day}.txt";

            this.Budget(incomes, path);
            this.Budget(expenses, path);
        }

        private void Budget(Budget budget, string path)
        {
            Console.WriteLine();
           
            File.AppendAllText(
                path,
                string.Format(
               $"TOTAL {budget.Name.ToUpper()}: {budget.Total()} $."));
            File.AppendAllText(path, $"+{new string('-', 53)}+\n");
            File.AppendAllText(path, string.Format("Name", "Category"));
            File.AppendAllText(path, $"+{new string('-', 53)}+\n");
            for (int i = 0; i < budget.Count; i++)
            {
                string financeCategory = budget.GetFinanceCategory()[i];
                decimal financeValue = budget.GetFinanceValues()[i];
               

                File.AppendAllText(
                    path,
                    string.Format(financeCategory, "|",
                    $" {financeValue} $."));
            }
        }
    }
}
