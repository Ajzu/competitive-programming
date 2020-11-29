using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.WeeklyContest
{
    /// <summary>
    /// 5613 - Richest Customer Wealth
    /// </summary>
    public class RichestCustomerWealth
    {
        public static int BasicImplementation(int [][] accounts)
        {            
            int maxSum = 0;

            for(int i=0; i<accounts.Length; i++)
            {
                int sum = 0;

                for (int j=0; j< accounts[i].Length; j++)
                {
                     sum += accounts[i][j];
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            
            return maxSum;
        }


        public static int LeetCodeImplementation(int[][] accounts)
        {
            int maxSum = 0;

            foreach (int[] array in accounts)
            {
                int currentSum = 0;

                foreach (int value in array)
                {
                    currentSum += value;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }
    }
}
