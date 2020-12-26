using NUnit.Framework;
using CompetitiveProgramming.LeetCode.Problems;

namespace CompetitiveProgrammingUnitTest.LeetCode
{
    public class SearchA2DMatrixTest
    {
        SearchA2DMatrix searchA2DMatrix;

        SearchA2DMatrixTest()
        {
            searchA2DMatrix = new SearchA2DMatrix();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicImplementationTest()
        {
            bool expectedResult = true;

            int target = 13;
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 3, 5, 7 };
            matrix[1] = new int[] { 10, 11, 16, 20 };
            matrix[2] = new int[] { 23, 30, 34, 50 };            

            bool actualResult = searchA2DMatrix.SearchMatrix(matrix, target);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}