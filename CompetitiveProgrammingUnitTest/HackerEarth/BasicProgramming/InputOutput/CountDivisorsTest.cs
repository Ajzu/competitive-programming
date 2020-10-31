using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class CountDivisorsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCountDivisorsBasic()
        {
            int  expectedResult = 10;
            int l = 1;
            int r = 10;
            int k = 1;

            int actualResult = CountDivisors.BasicImplementation(1, 10, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
