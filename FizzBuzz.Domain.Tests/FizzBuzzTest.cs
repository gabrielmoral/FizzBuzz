using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Number_Three_With_Limit_One_Fizz()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer(1);

            var resultList = fizzBuzzer.Build(3);

            CollectionAssert.AreEqual(new List<string>(){ "fizz" }, resultList);
        }

        [TestMethod]
        public void Number_Five_With_Limit_Two_Fizz_Four()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer(2);

            var resultList = fizzBuzzer.Build(10);

            CollectionAssert.AreEqual(new List<string>() { "buzz", "11" }, resultList);
        }

        [TestMethod]
        public void Number_Fifteen_With_Limit_One_Fizzbuzz()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer(1);

            var resultList = fizzBuzzer.Build(15);

            CollectionAssert.AreEqual(new List<string>() { "fizzbuzz" }, resultList);
        }

        [TestMethod]
        public void Number_One_With_Limit_Fifteen()
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer(15);

            var resultList = fizzBuzzer.Build(1);

            var results = new List<string>() { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" };

            CollectionAssert.AreEqual(results, resultList);
        }

    }
}