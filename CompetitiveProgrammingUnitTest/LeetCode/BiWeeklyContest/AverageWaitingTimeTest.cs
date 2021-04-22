using NUnit.Framework;
using CompetitiveProgramming.LeetCode.BiWeeklyContest;

namespace CompetitiveProgrammingUnitTest.LeetCode.BiWeeklyContest
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
            double expectedResult = 5.000000;
            int[][] customers = new int[][] {new int[] { 1, 2 }, new int[] { 2, 5 }, new int[] { 4, 3 } };// [[1, 2],[2,5],[4,3]]

            double actualResult = AverageWaitingTime.AverageWaitingTimeImplementation(customers);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void BasicImplementationTest2()
        {
            double expectedResult = 3.25000;
            int[][] customers = new int[][] { new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 10, 3 }, new int[] {20, 1 } };// [[1, 2],[2,5],[4,3]]

            double actualResult = AverageWaitingTime.AverageWaitingTimeImplementation(customers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void BasicImplementationTest3()
        {
            double expectedResult = 4.16667;
            int[][] customers = new int[][] { new int[] { 2, 3 }, new int[] { 6, 3 }, new int[] { 7, 5 }, new int[] { 11, 3 }, new int[] { 15, 2 }, new int[] { 18, 1 } };

            double actualResult = AverageWaitingTime.AverageWaitingTimeImplementation(customers);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}