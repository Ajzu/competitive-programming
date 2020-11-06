using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class DivisibilityTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDivisibilityBasic()
        {
            string  expectedResult = "No";
            int N = 5;
            string numbers = "85 25 65 21 84";

            string actualResult = Divisibility.BasicImplementation(N, numbers);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
