using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class TeddyAndTweetyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasic()
        {
            string expectedResult = "YES";
            int inputs = 6;            

            string actualResult = TeddyAndTweety.BasicImplementation( inputs );
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
