using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.Algorithm
{
    public class AlgorithmFundamentals
    {
        public static void OldBubbleSort(int[] arr)
        {
            //Discarded this bubbleSort technique because for a sample array 100, 9, 7, 1, 22 it took 20 iterations and other implementation was much faster.
            Console.WriteLine("User has given following array as the unordered array/input: ");
            Console.WriteLine(string.Join(" ", arr) + "\n");
            int iterations = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //iterations++;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    iterations++;
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

        /// <summary>
        /// Self implemented Basic Bubble Sort which is surprisingly optimized.
        /// </summary>
        public static void BasicBubbleSort()
        {
            //BubbleSortMichaelMcMilan();
            //BubbleSortGFG();
            int[] myArray = new int[] { 100, 9, 7, 1, 22 }; //{ 100, 9, 23, 54, 1, 5, 11, 234, 4 };
            int lastSwappedIndex = myArray.GetUpperBound(0);
            int iterations = 0;

            for (int j = myArray.GetUpperBound(0); j >= 1; j--) 
            {
                for (int i = 0; i < lastSwappedIndex; i++)
                {
                    iterations++;
                    if (myArray[j] < myArray[i])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
                lastSwappedIndex--;
            }
            Console.WriteLine("Final Array : " + String.Join(" ", myArray));
            Console.WriteLine("Total Iterations : " + iterations);
        }

        public static void BubbleSortMichaelMcMilan() 
        {
            int[] arr = new int[] { 100, 9, 7, 1, 22 }; //{ 100, 9, 23, 54, 1, 5, 11, 234, 4 };
            Console.WriteLine("Unsorted Array: " + string.Join(" ", arr));
            int temp;
            int iterations = 0;

            for (int outer = arr.GetUpperBound(0); outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    iterations++;
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }                    
            }
            Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
            Console.WriteLine("Iterations : " + iterations);
        }

        public static void BubbleSortGFG()
        {
            int[] arr = new int[] { 100, 9, 7, 1, 22 };
            int n = arr.Length;
            Console.WriteLine("Initial Array : " + String.Join(" ", arr));
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
                        // swap arr[j] and arr[j+1] 
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
            Console.WriteLine("Final Array : " + String.Join(" ", arr));
            Console.WriteLine("Total Iterations : " + iterations);
        }

    }
}
