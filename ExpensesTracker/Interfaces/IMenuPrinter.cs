﻿using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Core;

namespace ExpensesTracker.Contracts
{
    interface IMenuPrinter
    {
         void Menu();
         void SubMenu();
         void Budget(Budget budget);
         void PrintLine(int width);
        void CategoryMenu(string type);
        void ExpensesCategory();
        void IncomesCategory();
    }
}
