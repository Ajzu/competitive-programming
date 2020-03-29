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
            #region In Progress
            //In Progress

            //int[] nums = new int[] { 3, 2, 1 };
            //int ThirdMaxIs = ThirdMax(nums);

            IncreasingDecreasingString("aaaabbbbcccc");

            /*
            int[] nums = new int[]{-1, -2, -3, -4, -5};/// { -3,4,3,90 };// { 3,2,4};//{ 2, 7, 11, 15 };
            int target = -8;// 0;// 6;//9;
            int[] temp = new int[2];
            temp = TwoSum(nums, target);
            */

            //int[] nums = new int[] { 2, 2, 1 };///{ 4, 1, 2, 1, 2 };
            //int uniqueSinglenumber = SingleNumber2(nums);

            #endregion In Progress

            #region Solved
            //Solved
            // int[] findNums = new int[] { 12, 345, 2, 6, 7896 };
            // FindNumbers(findNums);

            //string J = "aA";
            //string S = "aAAbbbbb";
            //NumJewelsInStones(J, S);

            //string toLowerCase = "LOVELY";
            //string test = ToLowerCase(toLowerCase);

            //int totalSteps = NumberOfSteps(14);

            //int[] nums = new int[] { -2, 0, 10, -19, 4, 6, -8 };
            //bool CheckIfExist = CheckIfNandItsDoubleExists(nums);

            //string address = "1.1.1.1";
            //string defangedIPaddress = DefangIPaddr(address);

            /*
            int n = 234;
            int resultSubtractProductAndSum = SubtractProductAndSum(n);
            */

            /*
            int[] nums = new int[] { 8, 1, 2, 2, 3 };  //Input 3- { 7, 7, 7, 7 };//Input 2- { 6, 5, 4, 8 }; 
            int[] resultSmallerNumbersThanCurrent = (int[])SmallerNumbersThanCurrent(nums);
            */

            #endregion Solved
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

        public int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];

            int index1 = 0;
            int index2 = 0;
            bool foundTwoSum = false;

            for(int i=0; i<(nums.Length-1); i++)
            {
                if(nums[i] > nums[i+1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                index1 = i;
                int nextItem = target - nums[index1];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nextItem)
                    {
                        index2 = j;
                        foundTwoSum = true;
                        break;
                    }
                }

                if (foundTwoSum)
                {
                    break;
                }
            }

            indices[0] = index1;
            indices[1] = index2;

            return indices;
        }

        /// <summary>
        /// TwoSum1 is a successfully working solution and solves all the test cases.
        /// It is number 1.TwoSum in LeetCode numbering.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] indices = new int[2];

            int index1 = 0;
            int index2 = 0;
            bool foundTwoSum = false;

            for (int i = 0; i < nums.Length; i++)
            {
                index1 = i;
                int nextItem = target - nums[index1];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nextItem)
                    {
                        index2 = j;
                        foundTwoSum = true;
                        break;
                    }
                }

                if (foundTwoSum)
                {
                    break;
                }
            }

            indices[0] = index1;
            indices[1] = index2;

            return indices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int NumberOfSteps(int num)
        {
            int steps = 0;
            if (num > 0)
            {
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = num - 1;
                    }
                    steps++;
                }
            }
            return steps;
        }

        public bool CheckIfNandItsDoubleExists(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for(int j=0; j<arr.Length; j++)
                    {
                        if (arr[j] == 0 && i != j)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    int temporaryIndex = i + 1;
                    while (temporaryIndex < arr.Length)
                    {
                        if (arr[i] == (2 * arr[temporaryIndex]))
                        {
                            return true;
                        }
                        else if (arr[temporaryIndex] == (2 * arr[i]))
                        {
                            return true;
                        }
                        else
                        {
                            temporaryIndex++;
                        }
                    }
                }
            }
            return false;
        }

        public int ThirdMax(int[] nums)
        {
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int temp = nums[i + 1];
                    nums[i + 1] = nums[i];
                    nums[i] = temp;
                }
            }
            if(nums.Length >2)
            {
                int thirdMaxItem = 0;
                for (int i = (nums.Length - 1); i > 0; i--)
                {
                    if (nums[i] > nums[i-1])
                    {
                        if(thirdMaxItem <3)
                        {
                            thirdMaxItem++;
                        }
                        else
                        {
                            break;
                        }                        
                    }
                }
                if(thirdMaxItem == 3)
                {
                    return nums[nums.Length - 3];
                }
                else
                {
                    return nums[nums.Length - 1];
                }
                
            }
            else
            {
                return nums[1];
            }        
        }

        public string DefangIPaddr(string address)
        {

            address = address.Replace(".", "[.]");
            return address;
        }

        /// <summary>
        /// Solved.
        /// Subtract the Product and Sum of Digits of an Integer - is the title in leetcode.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>result as the difference of product and sum.</returns>
        public int SubtractProductAndSum(int n)
        {
            string inputNumber = n.ToString();
            char[] digits = inputNumber.ToCharArray();
            int sum = 0;
            int product = 1;
            foreach(char item in digits)
            {
                sum += Convert.ToInt32(item.ToString());
                product = product * Convert.ToInt32(item.ToString());
            }
            int result = product - sum;

            return result;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int greaterThan = 0;

                for(int j=0; j<nums.Length; j++)
                {
                    if(i!=j)
                    {
                        if(nums[i] > nums[j])
                        {
                            greaterThan++;
                        }
                    }
                }
                result[i] = greaterThan;
            }

            //first sort array items in descending order.

            //for (int i = 0; i < (nums.Length - 1); i++)
            //{
            //    if (nums[i] < nums[i + 1])
            //    {
            //        int temp = nums[i + 1]
            //      nums[i + 1] = nums[i];
            //        nums[i] = temp;
            //    }
            //}

            //Now get the count of the items on the left side of the number except similar or equal numbers on the left like 2,2,2,1, here we will skip all the 2 and count from 1.

            return result;
        }

        public string IncreasingDecreasingString(string s)
        {
            string result = "";

            foreach(char item in s)
            {
                char customItem = s[0];
                int sampleASCII = Convert.ToInt32(item);
                //int test = (int)item;
            }

            return result;
        }
    }
}
