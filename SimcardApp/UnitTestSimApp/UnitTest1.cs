using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimcardApp;
using System;

namespace UnitTestSimApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Recharge_Sim()
        {
            var account = new SimcardAccount(0);

            account.RechargeSim(100);

            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod]
        public void Buy_Data()
        {
            var account = new SimcardAccount(1000);

            account.BuyData(200);

            Assert.AreEqual(800, account.Balance);
        }

        [TestMethod]
        public void Borrow_Airtime()
        {
            var account = new SimcardAccount(0);

            account.BorrowAirtime(10);

            Assert.AreEqual(10, account.Balance);
        }

        [TestMethod]
        public void Transfer_Airtime_to()
        {
            var account = new SimcardAccount(1000);
            var secondaccount = new SimcardAccount();

            account.TransferAirtime(secondaccount, 500);

            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, account.Balance);

        }

        [TestMethod]
        public void Check_Low_Balance()
        {
            var account = new SimcardAccount(10);

           var accountbalance= account.LowAccountBalance();

            Assert.IsTrue(accountbalance);
        }
    }
}
