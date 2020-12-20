using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.WeeklyContest
{
    public class GoalParserInterpretation
    {
        public static string Interpet(string command)
        {
            StringBuilder parsedCommand = new StringBuilder();

            for(int i=0; i<command.Length; i++)
            {
                if (command[i] == '(')
                {
                    if(command[i+1] == ')')
                    {
                        parsedCommand.Append('o');
                        i++;
                    }
                    else if( command[i+1] == 'a' && command[i+2] == 'l')
                    {
                        parsedCommand.Append("al");
                        i += 3;
                    }
                }
                else
                {
                    parsedCommand.Append(command[i]);
                }
            }

            return parsedCommand.ToString();
        }

        public static int MaxOperations(int[] nums, int k)
        {
            //OptimizedBubbleSort(nums);
            BubbleSortGFG(nums);
            int operations = 0;
            int lastIndex = nums.Length - 1;

            for(int i=0; i<nums.Length -2; i++)
            {
                if (nums[i] <= k)
                {
                    int temp = k - nums[i];

                    for (int j = lastIndex; j > i; j--)
                    {
                        if (temp == nums[j])
                        {
                            operations++;
                            lastIndex--;
                            break;
                        }
                        else if(temp < nums[j])
                        {
                            lastIndex--;
                        }
                    } 
                }
            }
            return operations;
        }


        public static void BubbleSortGFG(int[] arr)
        {
            int n = arr.Length;
            int i, j, temp;
            int iterations = 0;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    iterations++;
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }

        public static void OptimizedBubbleSort(int[] arr)
        {
            int iterations = 0;
            bool noChange = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!noChange)
                {
                    iterations++;
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            noChange = false;
                        }
                        else
                        {
                            noChange = true;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }


        public void SortArray(int[] nums, int k)
        {
            for(int i=nums.Length-1; i>=0; i --)
            {
                if(nums[i]< nums[i -1])
                {
                    int swap = nums[i - 1];
                    nums[i - 1] = nums[i];
                    nums[i - 1] = swap;
                }
            }
        }
    }
}
