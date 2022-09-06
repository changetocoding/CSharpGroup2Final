using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankApp.Web.ViewModels;
using BankApp;
using BankApp.Core.Features;

namespace BankApp.Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly PayInMoney _PayIn;
        private readonly WithdrawMoney _withdraw;
        private readonly TransferMoney _transfer;

        public FeaturesController(PayInMoney payIn,WithdrawMoney withdraw,TransferMoney transfer)
        {
           this._PayIn = payIn;
           this._withdraw = withdraw;
           this._transfer = transfer;
        }

        [HttpPut]
        [Route("DepositMoney")]
        public void PayIn (int Id, decimal amount)
        {
            
           _PayIn.Execute(Id,amount);
        }

        [HttpPut]
        [Route("WithdrawMoney")]
        public void Withdraw(int id, decimal amount)
        {
            _withdraw.Execute(id, amount);
        }

        [HttpPut]
        [Route("TransferMoney")]
        public void Transfer(int fromAccountId, int toAccountId, decimal amount)
        {
            _transfer.Execute(fromAccountId, toAccountId, amount);
        }

    }

}
