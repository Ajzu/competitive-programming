using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.Algorithm
{
    public class AlgorithmFundamentals
    {
        public static void BubbleSort(int[] arr)
        {
            Console.WriteLine("User has given following array as the unordered array/input: ");
            Console.WriteLine(string.Join(" ", arr) + "\n");
            int iterations = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                iterations++;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Following is a sorted array using Bubble Sort Technique :");
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine("It took {0} iterations to sort the array", iterations);
        }

        public static void OptimizedBubbleSort(int[] arr)
        {
            Console.WriteLine("User has given following array as the unordered array/input: ");
            Console.WriteLine(string.Join(" ", arr) + "\n");
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
            Console.WriteLine("Following is a sorted array using Bubble Sort Technique :");
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine("It took {0} iterations to sort the array", iterations);
        }


        public static void CallingQuickSort()
        {
            //int[] arr = new int[6];
            int[] arr = new int[] { 5, 2, 6, 1, 3, 4, 4 };

            Console.WriteLine(" User Input Array Items : " + String.Join(" ", arr));

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted Array Items are : " + String.Join(" ", arr));
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = QuickSortPartition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSortPartition(arr, left, right);
                }
                if (pivot + 1 < right)
                {
                    QuickSortPartition(arr, pivot + 1, right);
                }
            }
        }

        public static int QuickSortPartition(int[] arr, int left, int right)
        {
            int pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }

                //if(left < right)//can't handle duplicates
                //{
                //    if (arr[left] == arr[right]) return right;

                //    int temp = arr[left];
                //    arr[left] = arr[right];
                //    arr[right] = temp;
                //}
                //else
                //{
                //    return right;
                //}


                if (left >= right)
                {
                    return right;
                }
                else
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }
        }
    }
}
