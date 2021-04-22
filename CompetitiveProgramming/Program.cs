using System;
using CompetitiveProgramming.DataStructure;
using CompetitiveProgramming.Algorithm;
using CompetitiveProgramming.Utility.PDF;
using CompetitiveProgramming.Skillenza;
using CompetitiveProgramming.HackerEarth.BasicProgramming;
using CompetitiveProgramming.LeetCode.WeeklyContest;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)  
        {
            SortedSquares();
            DuplicateZeros();

            int[] a = new int[] { 1, 2, 3, 4 };
            int[] b = new int[] { 3, 1, 3, 4,3 };
            int[] c = new int[] { 2, 5, 4, 4, 1, 3, 4, 4, 1, 4, 4, 1, 2, 1, 2, 2, 3, 2, 4, 2 };

            GoalParserInterpretation.MaxOperations(c, 3);

            GoalParserInterpretation.MaxOperations(a, 5);
            GoalParserInterpretation.MaxOperations(b, 6);
            //GoalParserInterpretation.Interpet("G()(al)");
            //GoalParserInterpretation.Interpet("G()()()()(al)");
            //GoalParserInterpretation.Interpet("(al)G(al)()()G");


            // Ladderophilia.HackerEarthImplementation(); // Solved
            // LifeTheUniverseAndEverything.HackerEarthImplementation(); // Solved
            // FriendsRelationship.HackerEarthImplementation(); // Solved

            #region LeetCode
            //LeetCode leetCode = new LeetCode();
            LeetCodeThirtyDayChallenge leetCodeThirtyDayChallenge = new LeetCodeThirtyDayChallenge();
            //leetCode.FindNumbers();
            #endregion LeetCode

            #region Skillenza

            // Skillenza.Skillenza.SpiltMilk();

            #endregion Skillenza

            #region Utility
            ChromeToPDFLibraryUtility chromeToPDFLibraryUtility = new ChromeToPDFLibraryUtility();
            //chromeToPDFLibraryUtility.ConvertHtmlToPDF();
            #endregion Utility

            //HackerEarth.HackerEarth.MonkAndPrisonerOfAzkaban();



            #region DotNet Interview Questions

            //Program obProgram = new Program();

            //Console.WriteLine("Comparison is {0}", obProgram.Compare<int>(1, 1));
            //Console.WriteLine("Comparison is {0}", obProgram.Compare<int>(1, 100));

            //Console.WriteLine("Comparison is {0}", obProgram.Compare<string>("abc", "abc"));
            //Console.WriteLine("Comparison is {0}", obProgram.Compare<string>("abc", "xyz"));

            //Console.WriteLine("Comparison is {0}", obProgram.Compare<char>('a', 'a'));
            //Console.WriteLine("Comparison is {0}", obProgram.Compare<char>('a', 'c'));

            #endregion DotNet Interview Questions

            #region HackerRank
            HackerRank hackerRank = new HackerRank();
            #region 30Days Challenge
            //ConditionalStatements();
            #endregion 30Days Challenge

            #endregion HackerRank

            #region HackerEarth
            CompetitiveProgramming.HackerEarth.HackerEarth obHackerEarth = new CompetitiveProgramming.HackerEarth.HackerEarth();
            //obHackerEarth.Companies();
            //obHackerEarth.Circuits();
            //HackerEarth.PlayWithNumbers();

            #region CodeArena
            //WalterWhiteSellMeth();
            //MatrixRowMinorColumnMajor();
            //CircularPermutationMasterMind();
            //CodeArenaChallenge2();//both opponents lost
            //CodeArenaChallenge1();//both opponents lost this challenge
            //ShelMakeArrayBeautiful();

            #endregion CodeArena
            #region Challenges
            //AlmostVowel();
            #endregion Challenges

            #region Tutorials
            //LinearSearch();
            #endregion Tutorials

            //HamiltonianAndLagrangin();
            //MostFrequent();
            //MicroAndArrayUpdate2();

            //EEDC();
            //EEDCString();
            //NeutralisationOfCharges();
            //ArrayGame();
            //MIvsCSKandPearls();

            #region ExecutedSolutions
            //TakeOff();
            //SeatingArrangement();
            //PrimeNumber();
            //PrimeNumberPractice();
            //HackerEarth solutions
            //MaximizeTheEarning();
            //BinaryQueries();
            //MemoriseMe();
            //MonkAndWelcomeProblem();
            //MicroAndArrayUpdate();
            //HelpJarvis();

            //Other solutions
            //splitString();
            //oldSchoolFindSmallestNumber();
            //findSmallestNumber();
            //LongATMQueue();
            //MonkAndPowerOfTime();
            //MonkAndPowerOfTimeUsingQueue();
            //BirthdayParty();
            #endregion ExecutedSolutions

            #region DataStructures

            DataStructureFundamentals dsTutorials = new DataStructureFundamentals();
            //dsTutorials.CreateBinaryTree();
            //dsTutorials.BasicsOfLinkedList();
            //dsTutorials.BasicsOfQueues();

            #endregion DataStructures

            #endregion HackerEarth

            #region Algorithm

            // AlgorithmFundamentals.BubbleSort(new int[] { 1, 5, 6, 2, 4, 3 });
            //AlgorithmFundamentals.OptimizedBubbleSort(new int[] { 11, 17, 18, 26, 23 });
            //AlgorithmFundamentals.CallingQuickSort();
            // AlgorithmFundamentals.BasicBubbleSort();
            #endregion Algorithm

            Console.ReadLine();
        }

        public static void FindMaxConsecutiveOnes()//int[] nums)
        {
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            int max = 0;
            int currentCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (currentCounter > max)
                    {
                        max = currentCounter;
                    }
                    currentCounter = 0;
                }
                else
                {
                    currentCounter++;
                }
            }

            if (currentCounter > max)
            {
                max = currentCounter;
            }

            Console.WriteLine(max);

        }

        /// <summary>
        /// Find Numbers With Even Number Of Digits
        /// </summary>
        /// <returns></returns>
        public int FindNumbers()//int[] nums)
        {
            int[] nums = new[] { 12, 345, 2, 6, 7896 };

            int evenNumberOfDigits = 0;

            foreach(int item in nums)
            {
                string currentitem = item.ToString();

                if(currentitem.Length/2==0)
                {
                    evenNumberOfDigits++;
                }
            }

            return evenNumberOfDigits;
        }

        public static int[] SortedSquares()//int[] nums)
        {
            //int[] nums = new int[] { -4, -1, 0, 3, 10 };//working
            //int[] nums = new int[] { -4, 0, 1, 3, 10 };//working
            int[] nums = new int[] { 1,2, 3, 5, 10 };// working
            //int[] nums = new int[] { -5, -4, -3, -2, -1 };//working
            //int[] nums = new int[] { -5, -4, -3, -2, -1 , 5};

            int[] squares = new int[nums.Length];

            //check if the first number is zero or positive number
            if(nums[0] >=0)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    squares[i] = nums[i] * nums[i];
                }
            }
            //if array has negative numbers
            else if(nums[nums.Length-1] <0)
            {
                for (int i = 0; i <nums.Length; i++)
                {
                    squares[i] = nums[nums.Length-(i+1)] * nums[nums.Length - (i + 1)];
                }
            }
            else
            {
                int median = nums.Length / 2;
                //int middleIndex = 0;
                int leftIndex = median;
                int rightIndex = median;

                //find the middle index
                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[leftIndex] <0 && nums[leftIndex+1] <0)
                    {
                        leftIndex++;
                    }
                    else if(nums[leftIndex] >=0)
                    {
                        leftIndex--;
                    }
                    else
                    {
                        rightIndex = leftIndex + 1;
                    }
                }
                Console.WriteLine("left index " + leftIndex + " : " + nums[leftIndex]);
                Console.WriteLine("right index " + rightIndex + " : " + nums[rightIndex]);

                bool leftDone = false;
                bool rightDone = false;

                for(int i=0; i<nums.Length; i++)
                {
                    int left = -(nums[leftIndex]);

                    if (((left < nums[rightIndex]) || (rightDone == true)) && (leftDone==false))
                    {
                        squares[i] = left * left;
                        leftIndex--;

                        if(leftIndex <0)
                        {
                            leftIndex = 0;
                            leftDone = true;
                        }
                    }
                    else
                    {
                        squares[i] = nums[rightIndex] * nums[rightIndex];
                        rightIndex++;

                        if(rightIndex >= nums.Length)
                        {
                            rightIndex--;
                            rightDone = true;
                        }
                    }
                }
            }
            return squares;
        }

        public static void DuplicateZeros()//int[] arr)
        {
            int[] arr = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            int nextItem = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if(nextItem >=0 || arr[i] ==0)
                {
                    if (arr[i] == 0)
                    {
                        nextItem = arr[i + 1];
                        arr[i + 1] = 0;
                        i++;
                    }
                    else
                    {
                        if (arr[i] < arr.Length)
                        {
                            int previousItem = nextItem;
                            nextItem = arr[i];
                            arr[i] = previousItem;
                        }
                        else
                        {
                            arr[i] = nextItem;
                        }
                    }
                }
                else
                {
                    //do nothing
                    //no zeros found
                }
            }
        }
    }
}
public class SeatingArragements
{
    public int seatNumber { get; set; }
    public string seatType { get; set; }

}

public class PeakValueProfit
{
    public int peak { get; set; }
    public int valley { get; set; }
    public int profit { get; set; }
}


//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        Solution();
//    }

//    public static void Solution()
//    {

//    }
//}
