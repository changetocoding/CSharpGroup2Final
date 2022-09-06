using BankApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Bank.Data.Scaffolded;
using BankApp;

namespace BankApp.Core.DataAccess
{
    public class DbBankAccount : IAccountRepository
    {
        public bool ValidatingEmailAddress(string emailAddress)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(emailAddress))
                return (true);
            else
                return (false);
        }
        public int CreateAccount(string emailAddress)
        {
            using (var dbContext = new BankContext())
            {
                if (ValidatingEmailAddress(emailAddress) is true)
                {
                    var acctEmail = dbContext.AccountDbs.FirstOrDefault(x => x.Email == emailAddress);
                    if (acctEmail is null)
                    {
                        var account = new AccountDb() { Email = emailAddress };
                        dbContext.AccountDbs.Add(account);
                        dbContext.SaveChanges();
                        return account.Id;

                    }
                    else
                    {
                        throw new InvalidOperationException($"This Account Already Exist");
                    }
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public Account GetAccountById(int accountId)
        {
            using (var dbContext = new BankContext())
            {
                var db_acct = dbContext.AccountDbs.FirstOrDefault(x => x.Id == accountId);
                if (db_acct is null)
                {
                    throw new InvalidOperationException($"Account Does Not Exist");

                }
                else
                {
                    var account = new Account()
                    {
                        Id = db_acct.Id,
                        Email=db_acct.Email,
                        Balance = db_acct.Balance,
                        Withdrawn = db_acct.Withdrawn,
                        PaidIn = db_acct.PaidIn

                        
                    };
                    return account;
                }
            }

            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbContext = new BankContext())
            {
                return dbContext.AccountDbs.Select(x => new Account() { Id = x.Id, Email = x.Email, Balance = x.Balance }).ToList();
            }
        }

        public void Update(Account account)
        {
            using (var dbContext = new BankContext())
            {
                var dbacct = dbContext.AccountDbs.Where(x => x.Id == account.Id).SingleOrDefault();
                if (dbacct is null)
                {
                    throw new InvalidOperationException($"Id Not Found");
                }

                else
                {
                   
                   dbacct.Balance = account.Balance;
                   dbacct.PaidIn = account.PaidIn;
                   dbacct.Withdrawn = account.Withdrawn;
                   dbContext.SaveChanges();
                }
                

            }   

        }
    }
}
