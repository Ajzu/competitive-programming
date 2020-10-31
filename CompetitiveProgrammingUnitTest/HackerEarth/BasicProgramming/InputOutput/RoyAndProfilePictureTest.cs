using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class RoyAndProfilePictureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRoyAndProfilePictureBasic()
        {
            string  expectedResult = "CROP IT";

            string actualResult = RoyAndProfilePicture.BasicImplementation();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
