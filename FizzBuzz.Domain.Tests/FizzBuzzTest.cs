using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Number_Three_With_Limit_One_Fizz()
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer(1);

            var resultList = fizzBuzz.Build(3);

            Assert.AreEqual("fizz", resultList[0]);
        }

        [TestMethod]
        public void Result_List_Size_Equals_Limit()
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer(2);

            var resultList = fizzBuzz.Build(3);

            Assert.AreEqual(2, resultList.Count);
        }

        [TestMethod]
        public void Number_Three_With_Limit_Two_Fizz_Four()
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer(2);

            var resultList = fizzBuzz.Build(3);

            Assert.AreEqual("fizz", resultList[0]);
            Assert.AreEqual("4", resultList[1]);
        }

        [TestMethod]
        public void Number_Five_With_Limit_Two_Fizz_Four()
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer(2);

            var resultList = fizzBuzz.Build(10);

            Assert.AreEqual("buzz", resultList[0]);
            Assert.AreEqual("11", resultList[1]);
        }

        [TestMethod]
        public void Number_Fifteen_With_Limit_One_Fizzbuzz()
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer(1);

            var resultList = fizzBuzz.Build(15);

            Assert.AreEqual("fizzbuzz", resultList[0]);
        }
    }
}