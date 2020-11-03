using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class IAmEasyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIAmEasyBasic()
        {
            int[]  expectedResult = new int[] { 3,6,9,12,15,18,21,24,27,30 };
            int N = 3;
            int[] actualResult = new int[10];

            actualResult = IAmEasy.BasicImplementation(N);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
