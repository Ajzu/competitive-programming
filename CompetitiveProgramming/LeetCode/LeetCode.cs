using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    public class LeetCode
    {
        public LeetCode()
        {
            //Solved
            // int[] findNums = new int[] { 12, 345, 2, 6, 7896 };
            // FindNumbers(findNums);

            //string J = "aA";
            //string S = "aAAbbbbb";
            //NumJewelsInStones(J, S);

            //string toLowerCase = "LOVELY";
            //string test = ToLowerCase(toLowerCase);

            //In Progress
            int[] nums = new int[] { 2, 2, 1 };///{ 4, 1, 2, 1, 2 };
            int uniqueSinglenumber = SingleNumber2(nums);
        }

        // Function to remove duplicate 
        // elements This function returns  
        // new size of modified array. 
        public int removeDuplicates(int[] arr, int n)
        {

            if (n == 0 || n == 1)
                return n;

            // To store index of next 
            // unique element 
            int j = 0;

            // Doing same as done in Method 1 
            // Just maintaining another updated 
            // index i.e. j 
            for (int i = 0; i < n - 1; i++)
                if (arr[i] != arr[i + 1])
                    arr[j++] = arr[i];

            arr[j++] = arr[n - 1];

            return j;
        }

        public int FindNumbers(int[] nums)
        {
            int count = 0;

            foreach (int item in nums)
            {
                string numbers = item.ToString();
                if (numbers.Length % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int NumJewelsInStones1(string J, string S)
        {
            //Simple solution 1 - basic solution with for loop, faster than Linq
            int JewelCount = 0;

            foreach(char c in J)
            {
                for(int i=0; i<S.Length; i++)
                {
                    if(S[i]==c)
                    {
                        JewelCount++;
                    }
                }
            }
            return JewelCount;
        }

        public int NumJewelsInStones(string J, string S)
        {
            //Simple solution 2 - basic solution with for loop, faster than Linq, using the S.Contains to reduce the iteration and check memory.
            int JewelCount = 0;

            foreach (char c in J)
            {
                if (S.Contains(c))
                {
                    for (int i = 0; i < S.Length; i++)
                    {
                        if (S[i] == c)
                        {
                            JewelCount++;
                        }
                    } 
                }
            }
            return JewelCount;
        }

        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }

        public int SingleNumber(int[] nums)
        {
            int singleOne = 0;
            
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                if (singleOne == 0)
                {
                    for (int j = (i + 1); j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            singleOne = 0;
                            int temp = nums[i + 1];
                            nums[i + 1] = nums[j];
                            nums[j] = temp;
                            i++;
                            break;
                        }
                        else
                        {
                            singleOne = nums[i];
                        }
                    } 
                }
                else
                {
                    break;
                }
            }
            if(singleOne ==0)
            {
                singleOne = nums[nums.Length - 1];
            }
            return singleOne;
        }

        public int SingleNumber2(int[] nums)
        {
            int x = 0;
            for (int i = 0; i < nums.Length; i++) x ^= nums[i];
            return x;
        }

        public int SingleNumber3(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                res ^= nums[i];
            }

            return res;
        }

    }
}
