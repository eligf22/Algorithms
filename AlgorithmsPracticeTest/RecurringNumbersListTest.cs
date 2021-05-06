using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class RecurringNumbersListTest
    {
        [TestMethod]
        public void MostRepeatedNumberArray_ArgumentNullException()
        {
            int[][] list = null;

            Assert.ThrowsException<ArgumentNullException>(() => RecurringNumbers.GetRecurringNumbers(list));
        }

        [TestMethod]
        public void MostRepeatedNumberArray_Success()
        {

            int[][] list = new int[][] { new int[] { 1, 4 }, new int[] { 4, 5, 5 } };
            var expected = new int[] { 4, 5 };
            var result = RecurringNumbers.GetRecurringNumbers(list);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
