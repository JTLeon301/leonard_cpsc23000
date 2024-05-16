using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApplication
{
    internal class CDAccount : Investment
    {
        private double interestRate;
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0) {
                    interestRate = 0;
                } else
                {
                    interestRate = 0;
                }
            }
        }

        public CDAccount()
        {
            InterestRate = 0;
        }

        public CDAccount(string id, string name, string openingDate, double startingBalance, double intRate) : base(id, name, openingDate, startingBalance)
        {
            InterestRate = intRate;
        }

        public override void UpdateBalance()
        {
            Balance = Balance + InterestRate * Balance;
        }

        public override string ToString()
        {
            //finish
            return $"{base.ToString()}
        }
    }
}
