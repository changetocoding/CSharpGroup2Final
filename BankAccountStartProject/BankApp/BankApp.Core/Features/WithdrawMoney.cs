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

           
            if (from.CanWithdraw(amount) && from.Balance > 0 )
            {
                from.Withdraw(amount);
                
            }
            else
            {
                throw new Exception();
            }
            //if (from.IsLowBalance())
            //{
            //    notificationService.NotifyFundsLow(from);
            //}
            accountRepository.Update(from);
            notificationService.NotifyFundsLow(from);
        }
    }
}
