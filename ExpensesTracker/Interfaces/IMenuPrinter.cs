using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Core;

namespace ExpensesTracker.Contracts
{
    interface IMenuPrinter
    {
         void Menu();
         void SubMenu();
         void Budget(Budget budget, decimal incomesTotal);
         void PrintLine(int width);

       


    }
}
