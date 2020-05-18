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
            
           while (true)
            {
                Budget incomes = new Budget("Incomes");
                consolePrinter.Menu();
                var option = Console.ReadKey().Key;
                Console.Clear();

                switch (option)
                {
                    case ConsoleKey.D1:
                        SubmenuBudget(incomes);
                        break;
                    case ConsoleKey.D2:
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
                    Add(budget);
                    break;
                case ConsoleKey.D3:
                    break;


            }

        }
        public static void Add(Budget budget)
        {
            try
            {
                string elementAdded = budget.Add(Finance.Create());
                consolePrinter.PrintLine(52);
                Console.WriteLine(elementAdded);
                consolePrinter.Total(budget);
                

            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
