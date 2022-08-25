using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SearchEngine3;

namespace SearchEngine3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Display_All_Information()
        {
            // Arrange

            var search = new Search();

            // Act

            var result = search.DisplayingAllInformations();

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Display_Town_Information()
        {
            // Arrange

            var search = new Search();

            // Act


            var result = search.GivingTownName("California");

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Display_County_Information()
        {
            // Arrange

            var search = new Search();

            // Act

            var result = search.GivingCountyName("Argyll and Bute");

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_To_Find_All_Duplicates()
        {
            // Arrange

            var search = new Search();

            // Act

            var result = search.DisplayingAllInformations();

            // Assert

            Assert.IsNotNull(result);
        }

    }
}
