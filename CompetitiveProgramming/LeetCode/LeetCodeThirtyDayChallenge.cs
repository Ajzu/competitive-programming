using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    public class LeetCodeThirtyDayChallenge
    {
        public LeetCodeThirtyDayChallenge()
        {
            //In Progress

            //int[] nums = new int[] { 2, 2, 1 };
            //int resultSingleNumber =  SingleNumber(nums);

            //bool numberIsHappy = IsHappy(19); //2, 20
        }

        public int SingleNumber(int[] nums)
        {
            int x = 0;
            for (int i = 0; i < nums.Length; i++) x ^= nums[i];
            return x;
        }

        public bool IsHappy(int n)
        {
            List<int> oldSums = new List<int>();

            while(n > 1)
            {
                char[] digits = n.ToString().ToCharArray();
                int sum = 0;

                for(int i=0; i< digits.Length; i++)
                {
                    int digit = Convert.ToInt32(digits[i].ToString());
                    int squareOfDigit = digit * digit;
                    sum = sum + squareOfDigit;
                }
                n = sum;
                if(oldSums.Contains(sum))
                {
                    break;
                }
                else
                {
                    oldSums.Add(sum);
                }                
            }

            if (n == 1)
                return true;
            else
                return false;
        }
    }
}
