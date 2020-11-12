using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class BookOfPotionMakingTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicImplementation()
        {
            string expectedResult = "Legal ISBN";
            string digitCode = "1401601499";

            string actualResult = BookOfPotionMaking.BasicImplementation(digitCode);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBasicImplementation2()
        {
            string expectedResult = "Illegal ISBN";
            string digitCode = "14016014991";

            string actualResult = BookOfPotionMaking.BasicImplementation(digitCode);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBasicImplementation3()
        {
            string expectedResult = "Illegal ISBN";
            string digitCode = "0000000000";

            string actualResult = BookOfPotionMaking.BasicImplementation(digitCode);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
