using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class BackToSchoolTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBackToSchoolBasic()
        {
            int expectedResult = 8;
            string inputs = "8 6 11";
            int actualResult = 0;

            actualResult = BackToSchool.BasicImplementation( inputs );
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
