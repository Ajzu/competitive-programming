using NUnit.Framework;
using CompetitiveProgramming.LeetCode.WeeklyContest;

namespace CompetitiveProgrammingUnitTest.LeetCode
{
    public class AverageWaitingTimeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicImplementationTest()
        {
            string expectedResult = "123-456-78";

            //string unformattedPhoneNumber = "123 4-5678";
            //string unformattedPhoneNumber = "123 4-567";
            //string unformattedPhoneNumber = "1-23-45 6";
            string unformattedPhoneNumber = "4802066218-13110231308 ";

            string actualResult = ReformatPhoneNumber.ReformatNumber(unformattedPhoneNumber);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}