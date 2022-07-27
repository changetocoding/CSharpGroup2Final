using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp2;

namespace BankApp2
{
    [TestClass]
    public class Account
    {
        [TestMethod]
        public void Account_Check_Amount()
        {
            var account = Account(1000);
        }
    }
}
