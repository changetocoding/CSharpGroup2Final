﻿using System;

namespace BankApp.Core.Domain
{
    public class Account
    {
        public const decimal FraudulentActivityLimit = 100_000_000m;
        public const decimal PayInLimit = 10000m;
        public const decimal LowBalanceThreshold = 1000m;
        public const decimal BalanceLimitForWithdraw = 0m;

        public int Id { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Positive number that keeps track of total that has been withdrawn from account
        /// </summary>
        public decimal Withdrawn { get; set; }

        /// <summary>
        /// Positive number that keeps track of total that has been paid into account
        /// </summary>
        public decimal PaidIn { get; set; }

        public virtual void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Insufficient funds to withdraw");
            //else if (amount <= BalanceLimitForWithdraw)
            //    throw new InvalidOperationException("You cannot withdraw 0");

            Balance = Balance - amount;
            Withdrawn = Withdrawn + amount;
        }

        public virtual void PayIn(decimal amount)
        {
            if (amount > PayInLimit)
                throw new InvalidOperationException($"You cannot pay in more than {PayInLimit} in a single transaction");

            Balance = Balance + amount;
            PaidIn = PaidIn + amount;
        }

        public virtual bool CanWithdraw(decimal amount)
        {
            var newBalance = Balance - amount;
            return newBalance >= BalanceLimitForWithdraw;
        }

        public bool IsLowBalance()
        {
            if (Balance <= LowBalanceThreshold)
                throw new InvalidOperationException("Current Balance is Low");

            return Balance < LowBalanceThreshold;
        }

        public bool FraudulentActivityDectected()
        {
            return PaidIn >= FraudulentActivityLimit;
        }
    }
}
