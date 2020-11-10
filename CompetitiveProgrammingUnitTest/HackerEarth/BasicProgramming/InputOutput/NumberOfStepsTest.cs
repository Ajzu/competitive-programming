using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class NumberOfStepsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicImplementation1()
        {
            int expectedResult = 8;
            int N = 5;
            int[] A = new int[] { 5, 7, 10, 5, 15 };
            int[] B = new int[] { 2, 2, 1, 3, 5 };

            int actualResult = NumberOfSteps.BasicImplementation(N, A, B);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBasicImplementation2()
        {
            int expectedResult = -1;
            int N = 2;
            int[] A = new int[] { 5, 6 };
            int[] B = new int[] { 4, 3 };

            int actualResult = NumberOfSteps.BasicImplementation(N, A, B);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
