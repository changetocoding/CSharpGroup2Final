using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;


namespace BankApp.Test.Features
{
    class TransferTest
    {

        [Test]
        public void CanTransferMoneyFromAccountToAnotherAccount()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int fromAccountId = 1;
            const int intoAccountId = 2;
            var account = new Account { Id = fromAccountId, Balance = 1000 };
            var account2 = new Account { Id = intoAccountId, Balance = 0 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account);
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(account2);


            var transfer = new TransferMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // act 
            transfer.Execute(fromAccountId, intoAccountId, 200);

            // assert
            Assert.That(account.Balance, Is.EqualTo(800));
            Assert.That(account2.Balance, Is.EqualTo(200));

        }

        [Test]
        public void CannotTransferMoreThanAccountBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int fromAccountId = 1;
            const int intoAccountId = 2;
            var account = new Account { Id = fromAccountId, Balance = 1000 };
            var account2 = new Account { Id = intoAccountId, Balance = 0 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account);
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(account2);


            var transfer = new TransferMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, intoAccountId, 2000));


            // assert
            Assert.That(account.Balance, Is.EqualTo(1000));
            Assert.That(account2.Balance, Is.EqualTo(0));

        }
        [Test]
        public void IfTransferAmountIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int fromAccountId = 1;
            const int intoAccountId = 2;
            var account = new Account { Id = fromAccountId, Balance = 1000 };
            var account2 = new Account { Id = intoAccountId, Balance = 0 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account);
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(account2);

            var transfer = new TransferMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, intoAccountId, -5000));


            // assert
            Assert.That(account.Balance, Is.EqualTo(1000));
            Assert.That(account2.Balance, Is.EqualTo(0));
        }
    }
}
