using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApplication
{
    internal class CheckingAccount : Investment
    {
        private double overdraftFee;
        public double OverdraftFee
        {
            get
            {
                return overdraftFee;
            }
            set
            {
                if (value < 0)
                {
                    overdraftFee = 0;
                } else
                {
                    overdraftFee = value;
                }
            }
        }

        public CheckingAccount()
        {
            OverdraftFee = 0;
        }

        public CheckingAccount (string id, string name, string openingDate, double startingBalance, double fee) : base(id, name, openingDate, startingBalance)
        {
            OverdraftFee = fee;
        }
        
        public void Withdraw(double amt)
        {
            Balance = Balance - amt;
        }

        public void Deposit(double amt)
        {
            Balance = Balance + amt;
        }

        public override void UpdateBalance()
        {
            if (Balance < 0)
            {
                //finish
            }
        }
    }
}
