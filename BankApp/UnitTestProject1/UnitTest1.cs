using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp;
using System;
using System.Net;

namespace BankApp
{
    [TestClass]
    public class BankAccount

    {
        [TestMethod]
        public void Add_Amount_to_Balance()
        {
            //arrange
            var amount = new BankAccount(1000);
        }
    }
}
