using System;
using ExpensesTracker.Models;
using ExpensesTracker.Print;

namespace ExpensesTracker
{
    class Program
    {
        static void Main(string[] args)
        {
         
            ConsolePrinter.Menu();
            var option = Console.ReadKey().Key;

            while (true)
            {
                switch (option)
                {
                    case ConsoleKey.D1:
                        Finance.Create();
                        break;
                    case ConsoleKey.D2:
                        return;
        

                }
             }
           
        }
    }
}
