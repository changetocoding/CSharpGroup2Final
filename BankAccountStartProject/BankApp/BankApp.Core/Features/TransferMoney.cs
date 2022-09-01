using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class TransferMoney
    {
        private IAccountRepository _accountRepository;
        private INotificationService _notificationService;

        public TransferMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            _accountRepository = accountRepository;
            _notificationService = notificationService;
        }


        public void Execute(int fromAccountId, int toAccountId, decimal amount)
        {
            var from = _accountRepository.GetAccountById(fromAccountId);
            var to = _accountRepository.GetAccountById(toAccountId);

            // ToDo

            if (from.FraudulentActivityDectected() && to.FraudulentActivityDectected())
            {
                _notificationService.NotifyFraudlentActivity(from);
                _notificationService.NotifyFraudlentActivity(to);

                throw new Exception($"Account limit reached you cannot payin at this time");
            }

            if (from.CanWithdraw(amount) && amount > 0 )
            {

                from.Withdraw(amount);
                to.PayIn(amount);
                _accountRepository.Update(to);
                _accountRepository.Update(from);
            }
            else if (amount > from.Balance)
            {
                throw new InvalidOperationException($"Cannot transfer more than available balance");
            }

            else
            {
                throw new Exception();
            }
        }
    }
}
