using System;
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
                        Console.WriteLine("Add money");
                        break;
                    case ConsoleKey.D2:
                        return;
                        break;

                }
             }
           
            /*  while (true)
              {
                  string test = Console.ReadLine();

                  if (test == "test")
                  {
                      Console.WriteLine("work!");
                  } else
                  {
                      return;
                  }

              }*/
        }
    }
}
