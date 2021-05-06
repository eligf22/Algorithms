using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class RepeatedNumberTest
    {
        [TestMethod]
        public void MostRepeatedNumber_Success()
        {
            int[] numbers = { 1, 10, 8, 9, 9, 10,10 };
            Assert.AreEqual(10, RepeatedNumber.MostRepeatedNumber(numbers));
        }

        [TestMethod]
        public void MostRepeatedNumber_WithTwoElements_Success()
        {
            int[] numbers = { 3, 3 };
            Assert.AreEqual(3, RepeatedNumber.MostRepeatedNumber(numbers));
        }

        [TestMethod]
        public void MostRepeatedNumber_NotRepeatedNumbers_Success()
        {
            int[] numbers = { 1, 3 };
            Assert.AreEqual(0, RepeatedNumber.MostRepeatedNumber(numbers));
        }

        [TestMethod]
        public void MostRepeatedNumber_ArgumentNullException()
        {
            int[] numbers = null;
            Assert.ThrowsException<ArgumentNullException>(() => RepeatedNumber.MostRepeatedNumber(numbers));
        }
    }
}
