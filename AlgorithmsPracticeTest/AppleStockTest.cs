using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class AppleStockTest
    {
        [TestMethod]
        public void GetMaxProfit_ArgumentException()
        {
            int[] stockPrices = {10};
            Assert.ThrowsException<ArgumentException>(() => AppleStock.GetMaxProfit(stockPrices));
        }

        [TestMethod]
        public void PriceGoesUpThenDownTest()
        {
            var actual = AppleStock.GetMaxProfit(new int[] { 1, 5, 3, 2 });
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriceGoesDownThenUpTest()
        {
            var actual = AppleStock.GetMaxProfit(new int[] { 7, 2, 8, 9 });
            var expected = 7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriceGoesUpAllDayTest()
        {
            var actual = AppleStock.GetMaxProfit(new int[] { 1, 6, 7, 9 });
            var expected = 8;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriceGoesDownAllDayTest()
        {
            var actual = AppleStock.GetMaxProfit(new int[] { 9, 7, 4, 1 });
            var expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PriceStaysTheSameAllDayTest()
        {
            var actual = AppleStock.GetMaxProfit(new int[] { 1, 1, 1, 1 });
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExceptionWithOnePriceTest()
        {
            Assert.ThrowsException<ArgumentException>(() => AppleStock.GetMaxProfit(new int[] { 5 }));
        }

        [TestMethod]
        public void ExceptionWithEmptyPricesTest()
        {
            Assert.ThrowsException<ArgumentException>(() => AppleStock.GetMaxProfit(new int[] { }));
        }

    }
}
