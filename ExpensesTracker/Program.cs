using System;
using ExpensesTracker.Core;
using ExpensesTracker.Models;
using ExpensesTracker.Print;

namespace ExpensesTracker
{
    class Program
    {
        private static ConsolePrinter consolePrinter = new ConsolePrinter();
        static void Main(string[] args)
        {
            Budget incomes = new Budget("Incomes");
            Budget expenses = new Budget("Expenses");
           


            while (true)
            {
                decimal balance = Balance(incomes, expenses);
               
                consolePrinter.Menu();
                var option = Console.ReadKey().Key;
                Console.Clear();

                switch (option)
                {
                    case ConsoleKey.D1:
                        SubmenuBudget(incomes);
                        break;
                    case ConsoleKey.D2:
                        SubmenuBudget(expenses);
                        break;
                    case ConsoleKey.D3:
                        consolePrinter.WholeBudget(incomes, expenses, balance);
                        break;
                    case ConsoleKey.D4:
                        return;


                }
             }
           
        }

        private static void SubmenuBudget(Budget budget)
        {

            consolePrinter.SubMenu();
            var option = Console.ReadKey().Key;
            Console.Clear();

           
             switch (option)
            {
                case ConsoleKey.D1:
                    SubMenuCategory(budget);
                    break;
                case ConsoleKey.D3:
                    break;


            }

        }

        private static void SubMenuCategory(Budget budget)
        {
            Console.Clear();
            consolePrinter.CategoryMenu(budget.Name.ToLower());

            if (budget.Name.ToLower() == "incomes")
            {
                IncomesCategory(budget);
            } else
            {
                ExpensesCategory(budget);
            }

        }

        private static void IncomesCategory(Budget budget)
        {
          
            var option = Console.ReadKey().Key;
            switch (option)
            {
                case ConsoleKey.D1:
                    Add(budget, "work");
                    break;
                case ConsoleKey.D2:
                    Add(budget, "others");
                    break;
                case ConsoleKey.D3:
                    break;


            }
        }

        private static void ExpensesCategory(Budget budget)
        {

            var option = Console.ReadKey().Key;
            switch (option)
            {
                case ConsoleKey.D1:
                    Add(budget, "food");
                    break;
                case ConsoleKey.D2:
                    Add(budget, "home");
                    break;
                case ConsoleKey.D3:
                    Add(budget, "transport");
                    break;
                case ConsoleKey.D4:
                    Add(budget, "shopping");
                    break;
                case ConsoleKey.D5:
                    Add(budget, "hobby");
                    break;
                case ConsoleKey.D6:
                    Add(budget, "family");
                    break;
                case ConsoleKey.D7:
                    Add(budget, "health");
                    break;
                case ConsoleKey.D8:
                    Add(budget, "car");
                    break;
                case ConsoleKey.D9:
                    Add(budget, "others");
                    break;
                case ConsoleKey.D0:
                    break;


            }
        }

        public static void Add(Budget budget, string category)
        {
            try
            {
                Console.Clear();
                string elementAdded = budget.Add(Finance.Create(category));
                Console.WriteLine(elementAdded);
                consolePrinter.Budget(budget);
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public static decimal Balance(Budget incomes, Budget expenses)
        {
            return incomes.Total() - expenses.Total();
        }
    }
}
