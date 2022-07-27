using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp2
{
    //bank account demo class
    public class Account
    {
        private double balance;

        public Account()
        {
        }

        public Account(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }

        public void TransferFundsTo(Account otherAccount, double amount)
        {
            if (otherAccount is null)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            Withdraw(amount);
            otherAccount.Add(amount);
        }

        public bool LowAccountBalance()
        {
            if (Balance < 20)
            {
                return true;
            } 
            else
            {
                return false;
            }
           
        }


    }

}
