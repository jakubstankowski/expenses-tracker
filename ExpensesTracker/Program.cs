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
            consolePrinter.Menu();
            var option = Console.ReadKey().Key;
           
            while (true)
            {
               switch (option)
                {
                    case ConsoleKey.D1:
                        Add(incomes);
                        break;
                    case ConsoleKey.D2:
                        return;
        

                }
             }
           
        }

        public static void Add(Budget budget)
        {
            try
            {
                string elementAdded = budget.Add(Finance.Create());
                Console.WriteLine(elementAdded);
                consolePrinter.Total(budget);


            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
