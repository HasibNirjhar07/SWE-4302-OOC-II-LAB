using FizzbuzzApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzAppTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void verifyFizzTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string result = fizzbuzz.GetFizzyBuzz(3);
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void verifyBuzzTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string result = fizzbuzz.GetFizzyBuzz(7);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void verifyFizzBuzzTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string result = fizzbuzz.GetFizzyBuzz(21);
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestMethod]
        public void verifyGotchaTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            string result = fizzbuzz.GetFizzyBuzz(5);
            Assert.AreEqual("Gotcha", result);
        }
    }
}
