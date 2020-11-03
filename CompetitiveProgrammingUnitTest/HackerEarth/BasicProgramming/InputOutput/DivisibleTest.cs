using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class DivisibleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDivisibleBasic()
        {
            string expectedResult = "OUI";
            int N = 6;
            string elements = "15478 8452 8232 874 985 4512";
            string actualResult = "";

            actualResult = Divisible.BasicImplementation(N, elements);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
