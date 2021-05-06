using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsPracticeLibrary;
using System;

namespace AlgorithmsPracticeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindrome_True()
        {
            char[] text = { 'a', 'b', 'c', 'b', 'a' };
            Assert.AreEqual(true, Palindrome.IsPalindrome(text));

        }

        [TestMethod]
        public void IsPalindrome_False()
        {
            char[] text = { 'a', 'b', 'c', 'c', 'a' };
            Assert.AreEqual(false, Palindrome.IsPalindrome(text));

        }

        [TestMethod]
        public void IsPalindrome_ArgumentNullException()
        {
            char[] text = null;
            Assert.ThrowsException<ArgumentNullException>(() => Palindrome.IsPalindrome(text));
            
        }
    }
}
