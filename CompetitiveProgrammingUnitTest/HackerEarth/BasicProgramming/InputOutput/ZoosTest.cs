using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class Zoostest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestZoosBasic()
        {
            string input = "zZoooo";
            string actualResult = Zoos.BasicImplementation(input);
            Assert.AreEqual("Yes", actualResult);
        }
    }
}
