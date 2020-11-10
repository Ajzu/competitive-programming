using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class AliAndHelpingInnocentPeopleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicImplementation1()
        {
            string expectedResult = "invalid";
            string input = "12X345-67";

            string actualResult = AliAndHelpingInnocentPeople.BasicImplementation(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBasicImplementation2()
        {
            string expectedResult = "valid";
            string input = "11X246-68";

            string actualResult = AliAndHelpingInnocentPeople.BasicImplementation(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBasicImplementation3()
        {
            string expectedResult = "invalid";
            string input = "11A246-68";

            string actualResult = AliAndHelpingInnocentPeople.BasicImplementation(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
