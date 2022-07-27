using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Funds_to_Account()
        {
                     //arrange
            var account = new Account(1000);
                    //act
            account.Add(500);
                        //assert
            Assert.AreEqual(1500, account.Balance);
        }

        [TestMethod]
        public void Withdraw_Funds_Account()
        {
            //arrange
            var account = new Account(1000);
            //act
            account.Withdraw(500);
            //assert
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Transfer_Funds_to_Another_Account()
        {
            //arrange
            var account = new Account(1000);
            var otheraccount = new Account();
            //act
            account.Withdraw(500);
            otheraccount.Add(500);

            //assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otheraccount.Balance);

        }

        [TestMethod]
        public void Low_Account_Balance()
        {
            //arrange
            var account = new Account(100);

            //act
            var result =account.LowAccountBalance();
            

            //assert
            Assert.IsTrue(result);
            
        }
    }
}