using System;
using ExpensesTracker.Core;
using ExpensesTracker.Models;
using ExpensesTracker.Print;

namespace ExpensesTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget incomes = new Budget("Incomes");

            ConsolePrinter.Menu();
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
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
