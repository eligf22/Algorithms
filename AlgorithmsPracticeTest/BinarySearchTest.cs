using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void IsBynarySearch_True()
        {
            int[] sortedArray = { 2, 3, 4, 10, 40 };
            int searchNum = 10;
            int leftIndex = 0;
            int rightIndex = sortedArray.Length -1;
            int result = BinarySearch.IsBinarySearch(sortedArray, searchNum, leftIndex, rightIndex);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void IsBynarySearch_SearchNumNotPresent()
        {
            int[] sortedArray = { 2, 3, 4, 10, 40 };
            int searchNum = 7;
            int leftIndex = 0;
            int rightIndex = sortedArray.Length - 1;
            int result = BinarySearch.IsBinarySearch(sortedArray, searchNum, leftIndex, rightIndex);
            Assert.AreEqual(-1, result);
        }
    }
}
