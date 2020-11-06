using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class DoctorsSecretTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDoctorsSecretBasic()
        {
            string expectedResult = "Take Medicine";
            string inputs = "27 1001";
            string actualResult = "";

            actualResult = DoctorsSecret.BasicImplementation( inputs );
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
