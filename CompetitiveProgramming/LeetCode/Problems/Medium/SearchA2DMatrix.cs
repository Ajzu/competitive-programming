using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.Problems
{
    /// <summary>
    /// SearchA2DMatrix
    /// Difficulty - Medium
    /// </summary>
    public class SearchA2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            bool result = false;

            int rowLength = matrix.Length;


            for (int i = 0; i < rowLength; i++)
            {
                int colLength = matrix[i].Length;
                for (int j = 0; j < colLength; j++)
                {
                    if (target > matrix[i][j])
                    {
                        result = true;
                        return result;
                    }
                }
            }
            return result;
        }

        public static bool FindInArray(int[] array, int target)
        {
            foreach(int item in array)
            {
                if(item == target)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
