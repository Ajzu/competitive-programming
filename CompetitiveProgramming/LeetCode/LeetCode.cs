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

            //In Progress
            string J = "aA";
            string S = "aAAbbbbb";
            //NumJewelsInStones(J, S);

            string toLowerCase = "LOVELY";
            string test = ToLowerCase(toLowerCase);
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

    }
}
