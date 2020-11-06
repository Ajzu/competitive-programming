using System;
using System.Collections.Generic;
using System.Text;
using CompetitiveProgramming.HackerEarth.BasicProgramming;
using NUnit.Framework;

namespace CompetitiveProgrammingUnitTest.HackerEarth.BasicProgramming
{
    class TwoStringsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicImplementation()
        {
            string expectedResult = "NO";
            string S1 = "abhi";
            string S2 = "hibb";
            string actualResult = "";

            actualResult = TwoStrings.BasicImplementation(S1, S2);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void TestBasicImplementationDictionary()
        {
            string expectedResult = "NO";
            string S1 = "abhiabhiabhiabhiabhiabhi";
            string S2 = "hibbhibbhibbhibbhibbhibb";
            string actualResult = "";

            actualResult = TwoStrings.BasicImplementationDictionary(S1, S2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
