using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
    class WithdrawTests
    {

        [Test]
        public void CanWithdrawMoneyFromAccount()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int intoAccountId = 1;
            var account = new Account { Id = intoAccountId, Balance = 700 };
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // act 
            withdraw.Execute(intoAccountId, 200);

            // assert
            Assert.That(account.Balance, Is.EqualTo(500));
        }

        [Test]
        public void IfWithDrawAmountIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 1;
            var account = new Account { Id = intoAccountId, Balance = 1000 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, -1500));

            // assert
            Assert.That(account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void CannotWithDrawAboveAccountBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 1;
            var account = new Account { Id = intoAccountId, Balance = 1000 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void CannotWithDrawZeroFromBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 1;
            var account = new Account { Id = intoAccountId, Balance = 1000 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 0));

            // assert
            Assert.That(account.Balance, Is.EqualTo(1000));
        }
    }
}
