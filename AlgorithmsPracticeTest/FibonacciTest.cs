using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;
using System.Diagnostics;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Recursive_Fib_Success9()
        {
            int n= 9;
            int result = Fibonacci.Recursive_Fib(n);
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void Recursive_Fib_Success2()
        {
            int n= 2;
            int result = Fibonacci.Recursive_Fib(n);
            Assert.AreEqual(1, result);
        }
    }
}