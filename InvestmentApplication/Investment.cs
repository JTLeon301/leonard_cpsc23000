using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApplication
{
    internal abstract class Investment
    {
        //properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string OpeningDate { get; set; }
        public double Balance { get; set; }

        public abstract void UpdateBalance();

        //default constructor
        public Investment()
        {
            Id = string.Empty;
            Name = string.Empty;
            OpeningDate = string.Empty;
            Balance = 0;
        }

        //custom constructor method
        public Investment(string id, string name, string openingDate, double balance)
        {
            Id = id;
            Name = name;
            OpeningDate = openingDate;
            Balance = balance;
        }

        //ToString function
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{OpeningDate}\t{Balance:C}";
        }
    }
}
