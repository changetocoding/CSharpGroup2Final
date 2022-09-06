using BankApp.Core.DataAccess;
using BankApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public IEnumerable<AccountDetails> Get()
        {
            var accounts = _accountRepository.GetAll();
            return accounts.Select(x => new AccountDetails()
            {
                Balance = x.balance,
                Id = x.Id,
                EmailAddress = x.Email
            });
        }
        [HttpPost]
        [Route("CreateAllAccount")]
        public int CreateAccount(string email)
        {
            
            var users = _accountRepository.CreateAccount(email);
            return users;  
        }

      
    }


}