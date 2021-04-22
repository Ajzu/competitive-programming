using NUnit.Framework;
using CompetitiveProgramming.LeetCode.BiWeeklyContest;

namespace CompetitiveProgrammingUnitTest.LeetCode.BiWeeklyContest
{
    public class NumberOfStudentdsUnableToEatLunchTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicImplementationTest()
        {
            int expectedResult = 0;
            int[] students = new int[] { 1, 1, 0, 0 };
            int[] sandwiches = new int[] { 0, 1, 0, 1 };

            int actualResult = NumberOfStudentdsUnableToEatLunch.CountStudents(students, sandwiches);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void BasicImplementationTest2()
        {
            int expectedResult = 0;
            int[] students = new int[] { 1, 1, 0, 0 };
            int[] sandwiches = new int[] { 0, 1, 0, 1 };

            int actualResult = NumberOfStudentdsUnableToEatLunch.CountStudents(students, sandwiches);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}