// See https://aka.ms/new-console-template for more information
using BankApp.Core.DataAccess;
using BankApp.Core.Features;
using BankApp.Core.Services;
using BankApp;
using  Bank.Data.Scaffolded;



namespace MoneyBox.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var repoService = new IBankAccount();
            var notificationService = new NotificationService();


            var withdrawService = new WithdrawMoney(repoService, notificationService);
            var transferService = new TransferMoney(repoService, notificationService);
            var payInService = new PayInMoney(repoService, notificationService);


            while (true)
            {
                Console.WriteLine("What do you want to do?");
                var instruction = Console.ReadLine();
                if (instruction == "quit")
                {
                    break;
                }
                else if ("create".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    CreateAccount(repoService);
                }
                else if ("payin".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    PayIn(payInService);
                }
                else if ("balance".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Balance(repoService);
                }
                else if ("withdraw".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Withdraw(withdrawService);
                }

                else if ("transfer".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Transfer(transferService);
                }
                else if ("notifications".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Notifications(notificationService);
                }
            }
        }



        static void CreateAccount(IAccountRepository repo)
        {
            try
            {
                Console.WriteLine("What is your email?");
                var email = Console.ReadLine();

                var accountId = repo.CreateAccount(email);

                Console.WriteLine("Account has been created. Id is: " + accountId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        static void PayIn(PayInMoney payIn)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                Console.WriteLine("Enter amount to pay in");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                payIn.Execute(accountId, amount);
                Console.WriteLine("Payment Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        private static void Balance(IAccountRepository repo)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                var account = repo.GetAccountById(accountId);
                Console.WriteLine($"Your balance is: {account.Balance}");
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine("Your account has not been found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }

        static void Withdraw(WithdrawMoney withdraw)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                Console.WriteLine("Enter amount to withdraw");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                withdraw.Execute(accountId, amount);
                Console.WriteLine("Withdrawal Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }
        static void Transfer(TransferMoney transfer)
        {
            try
            {
                Console.WriteLine("Enter your account Id to transfer from");
                var FromaccountIdStr = Console.ReadLine();
                var FromaccountId = Convert.ToInt32(FromaccountIdStr);

                Console.WriteLine("Enter your account Id to transfer to");
                var accountToIdStr = Console.ReadLine();
                var accountIdTo = Convert.ToInt32(accountToIdStr);

                Console.WriteLine("Enter amount to transfer");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                transfer.Execute(FromaccountId, accountIdTo, amount);
                
                Console.WriteLine("Tranfer Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        private static void Notifications(INotificationService notify)
        {
            try
            {
                var notifications = notify.GetAllNotifications();
                Console.WriteLine($"Notifications:");
                foreach (var notification in notifications)
                {
                    Console.WriteLine($"> {notification.Message}");
                }
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine("Your account has not been found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }
    }
}