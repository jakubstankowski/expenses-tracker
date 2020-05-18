using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpensesTracker.Contracts;
using ExpensesTracker.Models;

namespace ExpensesTracker.Core
{
    class Budget : IBudget
    {

        private List<Finance> list;

        public string Name { get; }

        public int Count => this.list.Count;


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
            return this.list.Select(x => x.Value).Sum();
        }

        public List<string> GetFinanceDescriptions()
        {
            return this.list.Select(x => x.Description).ToList();
        }

        public List<decimal> GetFinanceValues()
        {
            return this.list.Select(x => x.Value).ToList();
        }
    }
}
