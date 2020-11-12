using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class HelloTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicImplementation()
        {
            string expectedResult = "Hello Kirti";
            string actualResult = Hello.BasicImplementation();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
