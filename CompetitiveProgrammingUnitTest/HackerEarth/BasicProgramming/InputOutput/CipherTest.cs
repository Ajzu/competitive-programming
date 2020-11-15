using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CompetitiveProgramming.HackerEarth.BasicProgramming;

namespace CompetitiveProgrammingUnitTest.HackerEarth
{
    public class CipherTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCipherBasic()
        {
            string expectedResult = "Epp-gsrzsCw-3-fi:Epivx5.";

            string inputs = "All-convoYs-9-be:Alert1."; //"Y91.";// "All-convoYs-9-be:Alert1.";
            int key = 4;
            

            string actualResult = Cipher.BasicImplementation( inputs, key );
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
