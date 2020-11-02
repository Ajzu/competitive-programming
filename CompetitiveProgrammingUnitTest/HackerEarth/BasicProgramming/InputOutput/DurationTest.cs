using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class DurationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDurationBasic()
        {
            string[]  expectedResult = new string[] { "0 30", "5 41" };
            int N = 2;
            string[] works = new string[] { "1 44 2 14", "2 42 8 23" };
            string[] actualResult = new string[N];

            actualResult = Duration.BasicImplementation(N, works);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
