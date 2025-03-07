﻿using BankApp.Core.DataAccess;
using BankApp.Core.Services;

namespace BankApp.Core.Features
{
    public class PayInMoney
    {
        private IAccountRepository _accountRepository;
        private INotificationService _notificationService;

        public PayInMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            _accountRepository = accountRepository;
            _notificationService = notificationService;
        }

        public void Execute(int intoAccountId, decimal amount)
        {
            var into = _accountRepository.GetAccountById(intoAccountId);
            
            if(amount > 0)
            {
                into.PayIn(amount);
            }
            else
            {
                throw new Exception();
            }
            if (into.FraudulentActivityDectected())
            {
                _notificationService.NotifyFraudlentActivity(into);
                throw new Exception($"Account limit reached you cannot payin at this time");
            }
            _accountRepository.Update(into);
        }
    }
}
