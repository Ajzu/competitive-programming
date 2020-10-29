using System;
using CompetitiveProgramming.DataStructure;
using CompetitiveProgramming.Algorithm;
using CompetitiveProgramming.Utility.PDF;
using CompetitiveProgramming.Skillenza;
using CompetitiveProgramming.HackerEarth;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)  
        {
            
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
