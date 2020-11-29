using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class VCParisTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasic()
        {
            int[] expectedResult = new int[] { 3, 1, 0 };

            int testCases = 3;
            int[] lengths = new int[] { 6, 3, 1 };
            string[] inputs = new string[] { "bazeci", "abu", "o" };

            int[] actualResult = VCPairs.BasicImplementation(testCases, lengths, inputs);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
