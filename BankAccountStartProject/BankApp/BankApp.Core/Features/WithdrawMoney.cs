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
                throw new Exception($"Account limit reached you cannot withdraw at this time");
            }
            else if (from.CanWithdraw(amount) && amount > 0)
            {
                from.Withdraw(amount);
                accountRepository.Update(from);

            }
            else if (from.IsLowBalance())
            {  //lowthreshold notofication for low balance should show
                notificationService.NotifyFundsLow(from);
            }
           
            else
            {
                throw new Exception();
            }
            
           
        }
    }
}
