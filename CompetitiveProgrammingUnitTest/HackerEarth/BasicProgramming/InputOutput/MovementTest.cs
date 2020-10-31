using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class MovementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMovementBasic()
        {
            int  expectedResult = 6;
            int input = 26;

            int actualResult = Movement.BasicImplementation();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
