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
                    var check = dbContext.AccountDbs.Where(x => x.Email == emailAddress).FirstOrDefault();
                    if (dbContext.AccountDbs.Contains(check))
                    {
                        throw new InvalidOperationException($"Account Already Exist");

                    }
                    else
                    {
                        var account = new AccountDb(){ Email = emailAddress };
                        dbContext.AccountDbs.Add(account);
                        dbContext.SaveChanges();
                        return account.Id;
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
                var db_acct = dbContext.AccountDbs.Where(x => x.Id == accountId).FirstOrDefault();
                if (dbContext.AccountDbs is null)
                {
                    throw new InvalidOperationException($"Account Does Not Exist");

                }
                else
                {
                    var account = new Account() { Id = accountId };
                    return account;
                }

            }

            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbContext = new BankContext())
            {
                return dbContext.AccountDbs.Select(x => new Account() { Id = x.Id }).ToList();
            }
        }

        public void Update(Account account)
        {
            using (var dbContext = new BankContext())
            {
                var dbacct = dbContext.AccountDbs.Where(x => x.Id == account.Id).SingleOrDefault();
                if (dbacct is null)
                {
                    throw new InvalidOperationException($"Id Notot Found");
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

        //int IAccountRepository.CreateAccount(string emailAddress)
        //{
        //    throw new NotImplementedException();
        //}
}
