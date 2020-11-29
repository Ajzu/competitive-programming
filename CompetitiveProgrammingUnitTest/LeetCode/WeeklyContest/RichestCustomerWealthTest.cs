using NUnit.Framework;
using CompetitiveProgramming.LeetCode.WeeklyContest;

namespace CompetitiveProgrammingUnitTest.LeetCode
{
    public class RichestCustomerWealthTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicImplementationTest()
        {
            int expectedResult = 15;

            int[][] accounts = new int[3][];
            accounts[0] = new int[] { 1,2,3};
            accounts[1] = new int[] { 1, 2, 3,4 };
            accounts[2] = new int[] { 1, 2, 3,4,5 };            

            int actualResult = RichestCustomerWealth.BasicImplementation(accounts);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}