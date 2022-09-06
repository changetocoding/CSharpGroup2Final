using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class WithdrawMoney
    {
        private IAccountRepository accountRepository;
        private INotificationService notificationService;
        

        public WithdrawMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            this.accountRepository = accountRepository;
            this.notificationService = notificationService;
        }

        public void Execute(int fromAccountId, decimal amount)
        {
            var from = accountRepository.GetAccountById(fromAccountId);

            if (from.FraudulentActivityDectected())
            {
                notificationService.NotifyFraudlentActivity(from);
                throw new InvalidOperationException($"Account limit reached you cannot withdraw at this time");
            }
            else if (from.CanWithdraw(amount) && amount > 0)
            {
                from.Withdraw(amount);
                accountRepository.Update(from);
                if (from.IsLowBalance())
                { 
                    notificationService.NotifyFundsLow(from);
                }

            }
            else if(from.Balance < amount)
            {
                throw new InvalidOperationException();
            }
            
            else if (amount < 0)
            {
                throw new InvalidOperationException();
            }
           
            else
            {
                throw new Exception();
            }


        }
    }
}
