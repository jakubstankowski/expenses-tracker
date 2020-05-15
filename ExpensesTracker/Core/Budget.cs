using System;
using System.Collections.Generic;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Models;

namespace ExpensesTracker.Core
{
    class Budget : IBudget
    {

        private List<Finance> list;

        public string Name { get; }

        public int Count => throw new NotImplementedException();


        public Budget(string name)
        {
            this.list = new List<Finance>();
            this.Name = name;
        }

        public string Add(Finance finance)
        {
            list.Add(finance);

            return "Success add!";
        }

        public string Delete(string description)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            throw new NotImplementedException();
        }
    }
}
