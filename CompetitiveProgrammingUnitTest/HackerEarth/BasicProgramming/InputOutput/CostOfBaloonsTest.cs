using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class CostOfBaloonsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCostOfBaloonsBasic()
        {
            string[] statusOfUsers = new string[] { "1 1", "1 1", "0 1", "0 0", "0 1", "0 0", "0 1", "0 1", "1 1", "0 0" };
            int totalCost = CostOfBaloons.BasicImplementation(1, "9 6", 10, statusOfUsers);
            Assert.AreEqual(69, totalCost);
            //Assert.Pass();
        }
    }
}
