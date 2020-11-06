using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class GokiAndHisBreakupTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGokiAndHisBreakupBasic()
        {
            string[] expectedResult = new string[] { "YES", "YES", "NO", "YES", "NO" };

            int N = 5;
            int X = 100;
            int[] Y = new int[] { 110, 130, 90, 100, 45 };

            string[] actualResult = new string[N];

            actualResult = GokiAndHisBreakup.BasicImplementation( N, X, Y );
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
