using CompetitiveProgramming.HackerEarth.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth
{
    public class HackerEarth
    {
        Honeywell obHoneywell;
        Circuits obCircuits;
        ArrayDS obArrayDS;
        public HackerEarth()
        {
            obHoneywell = new Honeywell();
            obCircuits = new Circuits();
            obArrayDS = new ArrayDS();
            // EMazeIn(); Solved
            //BricksGame();
            //SampleSortedDictionary();
            //NotInRange();

            //Inprogress
            Zoos();
        }

        #region BasicProgramming

        public static void EMazeIn()
        {
            string mazeDirections = Console.ReadLine();
            char[] directions = mazeDirections.ToCharArray();
            int leftCount = directions.Where(x => x == 'L').Count();
            int rightCount = directions.Where(x => x == 'R').Count();
            int upCount = directions.Where(x => x == 'U').Count();
            int downCount = directions.Where(x => x == 'D').Count();
            Console.WriteLine( (rightCount - leftCount) + " " + (upCount - downCount) );
        }

        public static void BricksGame()
        {
            int totalBricks = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=totalBricks; i++)
            {
                if (totalBricks >= i)
                {
                    totalBricks = totalBricks - i;
                    int motu = (i * 2);
                    if (totalBricks > 0)
                    {
                        if(totalBricks > motu)
                        {
                            totalBricks = totalBricks - motu;
                            if (totalBricks <= 0)
                            {
                                totalBricks = 0;
                                Console.WriteLine("Motu");
                                break;
                            }                                
                        }
                        else
                        {
                            totalBricks = 0;
                            Console.WriteLine("Motu");
                            break;
                        }
                    }
                    else
                    {
                        totalBricks = 0;
                        Console.WriteLine("Patlu");
                        break;
                    }
                }
                else
                {
                    totalBricks = 0;
                    Console.WriteLine("Patlu");
                    break;
                }             
            }
            if(totalBricks > 0)
            {
                Console.WriteLine("Patlu");
            }
            
        }

        public static void NotInRange()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            SortedDictionary<int, int> ranges = new SortedDictionary<int, int>();

            for(int i=0; i<N; i++)
            {
                string[] range = Console.ReadLine().Split(' ');
                int left = Convert.ToInt32(range[0]);
                int right = Convert.ToInt32(range[1]);
                KeyValuePair<int, int> oldRange = new KeyValuePair<int, int>();
                oldRange = ranges.Where(x => x.Key == left).FirstOrDefault();
                if(oldRange.Value > 0)
                {
                    if(left == oldRange.Key)
                    {
                        if(oldRange.Value < right)
                        {
                            ranges[left] = right;
                        }
                    }
                }
                else
                {
                    ranges.Add(left, right);
                }

                //KeyValuePair<int, int> overlappingRange = new KeyValuePair<int, int>();
                //overlappingRange = ranges.Where(x => x.Value == left).FirstOrDefault();
            }

            for(int i=0; i< ranges.Count(); i++)
            {
                if (i < (ranges.Count()-1))
                {
                    //If left range is smaller than the next left range
                    if (ranges.ElementAt(i).Key <= ranges.ElementAt(i + 1).Key)
                    {
                        //If next range is within the previous range
                        if(ranges.ElementAt(i).Value >= ranges.ElementAt(i+1).Value)
                        {
                            ranges.Remove(ranges.ElementAt(i + 1).Key);
                        }
                    }
                }
                
            }

        }

        public static void SampleSortedDictionary()
        {
            // Create a new SortedDictionary 
            // of strings, with int keys. 
            SortedDictionary<int, string> myDr = new SortedDictionary<int, string>();

            // Adding key/value pairs in myDr 
            myDr.Add(1, "Dog");
            myDr.Add(7, "Turtle");
            myDr.Add(2, "Cat");
            myDr.Add(3, "Birds");
            myDr.Add(4, "Rabbits");
            myDr.Add(5, "Fish");
            myDr.Add(6, "Hamster");
            //myDr.Add(7, "Turtle");

            // Display the total number of  
            // key/value pairs present in myDr 
            Console.WriteLine("Total number of pairs " + "present in myDr : {0}", myDr.Count);
        }

        public static void Zoos()
        {
            string xy = Console.ReadLine();
            int xCount = 0;
            int yCount = 0;

            foreach(char c in xy)
            {
                if(c =='z')
                {
                    xCount++;
                }
                else
                {
                    yCount++;
                }
            }

            xCount = 2 * xCount;
            
            if(xCount == yCount)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }            
        }

        #endregion BasicProgramming

        #region Challenges

        /// <summary>
        /// Japanese challenge - https://www.hackerearth.com/challenge/competitive/Connect-Job-Hackerthon-2018/problems/a2cea098c8794ea782b88ce814367881/
        /// Global Hiring Challenge by Connect Job
        /// Almost Vowel :
        /// You are given with a string . Your task is to remove atmost two substrings of any length from the given string  such that the remaining string contains vowels('a','e','i','o','u') only. Your aim is the maximise the length of the remaining string. Output the length of remaining string after removal of atmost two substrings. NOTE: The answer may be 0, i.e.removing the entire string.
        /// INPUT FORMAT: First line of input contains number of test cases . Each test case comprises of a single line corresponding to string .
        /// OUTPUT FORMAT: Output a single integer denoting length of string containing only vowels after removal of atmost two substrings of any length.
        /// CONSTRAINTS: 
        /// Sample Input :
        /// 2
        /// earthproblem
        /// letsgosomewhere
        /// 
        /// Sample Output: 
        /// 3
        /// 2
        /// Explanation : For the first test case, the maximum length possible is 3. String of length 3 with only vowels formed by removing atmost 2 substrings can be: "eao" or "eae". For the second test case, the maximum length possible is 2. String of length 2 with only vowels formed by removing atmost 2 substrings can be: "ee" or "oe".
        /// </summary>
        private static void AlmostVowel()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> result = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                string testCase = Console.ReadLine();
                Dictionary<int, int> vowelCountIndex = new Dictionary<int, int>();

                if (testCase.Length > 0)
                {
                    for (int j = 0; j < testCase.Length; j++)
                    {
                        if (testCase[j] == 'a' || testCase[j] == 'e' || testCase[j] == 'i' || testCase[j] == 'o' || testCase[j] == 'u')
                        {
                            int vowelCount = 1;
                            if (j != testCase.Length)
                            {
                                for (int k = (j + 1); k < testCase.Length; k++)
                                {
                                    if (testCase[k] == 'a' || testCase[k] == 'e' || testCase[k] == 'i' || testCase[k] == 'o' || testCase[k] == 'u')
                                    {
                                        vowelCount++;
                                    }
                                    else
                                    {
                                        vowelCountIndex.Add(j, vowelCount);
                                        j += vowelCount;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                vowelCountIndex.Add(j, vowelCount);
                            }
                        }
                    }

                    if (vowelCountIndex.Count > 2)
                    {
                        //now find the maximum subarray or maximum consecutive vowels and remove the t20 largest substring
                        //check if zero is the first item of dictionary
                        //check if last item of dictionary is sum of key(index) + vowelcount(value) == testcase.Length
                        if (vowelCountIndex.First().Key == 0 && testCase.Length == (vowelCountIndex.Last().Key + vowelCountIndex.Last().Value))
                        {
                            int max1 = vowelCountIndex.First().Value;
                            int max2 = vowelCountIndex.Last().Value;
                            vowelCountIndex.Remove(0);
                            vowelCountIndex.Remove(vowelCountIndex.Last().Key);

                            var ordered2 = vowelCountIndex.OrderByDescending(x => x.Value);
                            int max3 = ordered2.First().Value;
                            result.Add(max1 + max2 + max3);
                        }
                        else
                        {
                            //get the first maximum value
                            //get the second maximum value
                            var ordered2 = vowelCountIndex.OrderByDescending(x => x.Value);
                            int max1 = ordered2.First().Value;
                            int max2 = ordered2.Skip(1).First().Value;
                            result.Add(max1 + max2);
                        }
                    }
                    else
                    {
                        //get the first maximum value
                        //get the second maximum value
                        int max1 = vowelCountIndex.First().Value;
                        int max2 = 0;
                        if (vowelCountIndex.Count > 1)
                        {
                            max2 = vowelCountIndex.Skip(1).First().Value;
                        }
                        result.Add(max1 + max2);
                    }
                }
                else
                {
                    result.Add(0);
                }
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        #endregion Challenges

        #region CodeArena

        private static void ShelMakeArrayBeautiful()
        {
            int[] shelArray = new int[Convert.ToInt32(Console.ReadLine())];
            string[] shelArrayItems = Console.ReadLine().Split(' ');
            int result = 0;

            for (int i = 0; i < shelArray.Length; i++)
            {
                result += (shelArray.Length - (i + 1));
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Partially accepted
        /// 6/9 score
        /// 66 total score
        /// Congratulations, you won the fight
        /// YOUR SCORE
        /// 30
        /// </summary>
        private static void WalterWhiteSellMeth()
        {
            string[] cities = new string[Convert.ToInt32(Console.ReadLine())];
            int currentCity = 0;
            int travellingCost = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = Console.ReadLine();
            }

            int[,] costMatrix = new int[cities.Length, cities.Length];

            for (int i = 0; i < cities.Length; i++)
            {
                string[] cost = Console.ReadLine().Split(' ');

                for (int j = 0; j < cost.Length; j++)
                {
                    costMatrix[i, j] = Convert.ToInt32(cost[j]);
                }
            }

            string[] destinationCities = new string[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < destinationCities.Length; i++)
            {
                destinationCities[i] = Console.ReadLine();
                int destination = Array.IndexOf(cities, destinationCities[i]);
                travellingCost += costMatrix[currentCity, destination];
                currentCity = destination;
            }
            Console.WriteLine(travellingCost);
        }


        /// <summary>
        /// Given Two matrix A and B of some order RXC. Both matrix contains elements from 1 to R*C . Matrix A contains elements in Row-major order while Matrix B contains elements in Column-major order .you are asked to answer a very simple question what is the trace of the matrix formed by the addition of A and B. Here, Trace of the matrix is defined as P[1][1] + P[2][2]... + P[min(n,m)][min(n,m)] for any rectangular matrix P.
        /// INPUT: 
        /// First line of input contains T denoting number of test cases.Each test case consists of single line only containing two integers denoting order of matrix R and C.
        /// OUTPUT: output consists of T lines each containing answer to the corresponding test cases.
        /// CONSTRAINTS
        /// T<=10^5
        /// 1<=R,C<=10^6
        /// Sample Input: 
        /// 2
        /// 3 3
        /// 1 2
        /// Sample Output:
        /// 30
        /// 2
        /// Explanation
        /// For first input , the two matrices A and B will be :
        ///         1 2 3 
        ///     A = 4 5 6 
        ///         7 8 9
        ///             1 4 7
        ///         B = 2 5 8
        ///             3 6 9
        ///                   2 6 10
        ///             A+B = 6 10 14
        ///                   10 14 18
        ///                   There , the trace of (A+B) matrix is 2 + 10 + 18 = 30
        ///                   Similarly , answer can be found for the second input also.
        /// </summary>
        private static void MatrixRowMinorColumnMajor()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            int[] result = new int[testCases];

            for (int i = 0; i < testCases; i++)
            {
                string[] matrixOrder = Console.ReadLine().Split(' ');

                int rows = Convert.ToInt32(matrixOrder[0]);
                int columns = Convert.ToInt32(matrixOrder[1]);

                int[,] matrix = new int[rows, columns];
                int[,] matrix2 = new int[rows, columns];

                int rowValue = 1;
                int columnValue = 1;

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        matrix[j, k] = rowValue;

                        matrix2[k, j] = rowValue;
                        rowValue++;
                    }
                }

                int[,] matrixSum = new int[rows, columns];

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        matrixSum[j, k] = matrix[j, k] + matrix2[j, k];
                    }
                }

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (j == k)
                        {
                            result[i] += matrixSum[j, k];
                        }

                    }
                }
            }
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// PROBLEM STATEMENT Points: 30
        /// I have scored 10/30 - won the fight
        /// 1/8 of 8 test cases were solved partially solved
        /// Ma5termind is having his birthday this weekend.Yeah !! You all are invited . Ma5termind wants to send an invitation to those groups of people which he finds interesting.A group of N people is said to be interesting only if the number of their possible circular permutations is divisible by N.Now, Ma5termind got confused as he is having all the groups having number of people belongs to [L, R] (both inclusive). Help him in find the minimum number of invitation cards required and win yourself a chance to attend Ma5termind's birthday party .
        /// [INPUT:]
        /// First line of the input contains a single integer T denoting the number of test cases. First and the only line of each test case consists of two space separated integers L and R denoting the range such that N belongs to [L, R] (both inclusive).
        /// [OUTPUT:]
        /// Output consists of T lines each containing the answer to the corresponding test case denoting the minimum number of invitation cards required by the Ma5termind.
        /// [CONSTRAINTS:]
        /// T<=10^6
        /// 1<=L<=R<=10^6
        /// SAMPLE INPUT
        /// 1
        /// 10 15
        /// SAMPLE OUTPUT
        /// 4
        /// Explanation
        /// For all 'n' belongs to the set {10,12,14,15} people . Group is interesting so, ma5termind will require 4 invitation cards in all.
        /// </summary>
        private static void CircularPermutationMasterMind()
        {
            int[] result = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < result.Length; i++)
            {
                string[] LR = Console.ReadLine().Split(' ');
                int left = Convert.ToInt32(LR[0]);
                int right = Convert.ToInt32(LR[1]);

                int invitations = 0;

                for (int j = left; j <= right; j++)
                {
                    //check if number is prime
                    if (!IsPrimeCircularPermutationMasterMind(j))
                    {
                        invitations++;
                    }
                }

                result[i] = invitations;
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsPrimeCircularPermutationMasterMind(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private static void CodeArenaChallenge2()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                string[] PQS = Console.ReadLine().Split(' ');
                int P = Convert.ToInt32(PQS[0]);

                int S = Convert.ToInt32(PQS[2]);
                string moveWinner = "";
                int moveCount = 0;

                for (int j = 0; j < P; j++)
                {
                    int Q = Convert.ToInt32(PQS[1]);
                    moveCount += (int)(Q / S);
                }
                if (moveCount > 1)
                {
                    if (moveCount % 2 == 0)
                    {
                        moveWinner = "Havanese";
                    }
                    else
                    {
                        moveWinner = "Bernard";
                    }
                }
                else
                {
                    moveWinner = "Bernard";
                }
                result.Add(moveWinner);
            }
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void CodeArenaChallenge1()//lost this challenge
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                string[] words = Console.ReadLine().Split(' ');
                //string[] swaps = new string[words.Length];

                if (words.Length > 1)
                {
                    for (int j = 0; j < words.Length - 1; j++)
                    {
                        int swapIndex = (words.Length - (j + 1));
                        string tempWord = words[j];
                        words[j] = words[swapIndex];
                        words[swapIndex] = tempWord;
                        //swaps[j] = words[swapIndex];
                        //swaps[swapIndex] = tempWord;
                    }

                    //result.Add(string.Join(" ", swaps));
                    result.Add(string.Join(" ", words));
                }
                else
                {
                    result.Add(words[0]);
                }
            }

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        #endregion CodeArena

        #region Tutorials
        public static void LinearSearch()
        {
            string[] arrayDetails = Console.ReadLine().Split(' ');
            int compareItem = Convert.ToInt32(arrayDetails[1]);

            int[] inputArray = new int[Convert.ToInt32(arrayDetails[0])];
            int lastIndex = -1;
            string[] arrayItems = Console.ReadLine().Split(' ');


            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(arrayItems[i]);
                if (inputArray[i] == compareItem)
                {
                    lastIndex = i + 1;
                }
            }

            Console.WriteLine(lastIndex);
        }
        #endregion Tutorials

        #region Unsolved

        //public static void NeutralisationOfCharges()
        //{
        //    int stringSize = Convert.ToInt32(Console.ReadLine());
        //    StringBuilder sb = new StringBuilder(Console.ReadLine());
        //    //bool neutralization = true;
        //    int changes = 0;
        //    int iteration = 0;

        //    for (int i = 0; i < sb.Length; i++)
        //    {
        //        iteration++;
        //        if (changes == 0 && i > 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            for (int j = 0; j < (sb.Length - 1); j++)
        //            {
        //                if (sb[j] == sb[j + 1])
        //                {
        //                    sb.Remove(j, 2);
        //                    changes++;
        //                }
        //            }
        //        }
        //    }          
        //    Console.WriteLine(sb.Length);
        //    Console.WriteLine(sb.ToString());
        //}

        public static void NeutralisationOfChargesStack()
        {
            int stringSize = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            //bool neutralization = true;
            int changes = 0;
            int iteration = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                iteration++;
                if (changes == 0 && i > 0)
                {
                    break;
                }
                else
                {
                    for (int j = 0; j < (sb.Length - 1); j++)
                    {
                        if (sb[j] == sb[j + 1])
                        {
                            sb.Remove(j, 2);
                            changes++;
                        }
                    }
                }
            }
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());
        }

        //public static int DetectChanges(int changes, StringBuilder sb)
        //{
        //    if (changes == 0)
        //    {
        //        return changes;
        //    }
        //    else
        //    {
        //        for (int j = 0; j < (sb.Length - 1); j++)
        //        {
        //            if (sb[j] == sb[j + 1])
        //            {
        //                sb.Remove(j, 2);
        //                changes++;
        //                DetectChanges(changes, sb);
        //            }
        //        }
        //    }
        //}

        public static void EEDC()
        {
            long N = Convert.ToInt32(Console.ReadLine());
            string[] allIntegers = Console.ReadLine().Split(' ');
            int[] inputArray = new int[N];
            Dictionary<int, int> luckyIndices = new Dictionary<int, int>();
            List<int> finalResult = new List<int>();

            for (int i = 0; i < allIntegers.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(allIntegers[i]);
            }

            int Queries = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Queries; i++)
            {
                string[] LR = Console.ReadLine().Split(' ');
                int leftIndex = Convert.ToInt32(LR[0]);
                int rightIndex = Convert.ToInt32(LR[1]);
                int finalSum = 0;

                for (int currentIndex = leftIndex; currentIndex <= rightIndex; currentIndex++)
                {

                    if (!luckyIndices.ContainsKey(currentIndex))
                    {
                        finalSum = EEDCSum(currentIndex, inputArray);
                        luckyIndices.Add(currentIndex, finalSum);
                    }
                    else
                    {
                        finalSum = luckyIndices[currentIndex];
                    }

                    if (finalSum > 0)
                    {
                        break;
                    }
                }
                finalResult.Add(finalSum);
            }

            foreach (int item in finalResult)
            {
                Console.WriteLine(item);
            }
        }

        public static int EEDCSum(int leftIndex, int[] inputArray)
        {
            int result = 0;
            int leftNumber = 0;
            int rightNumber = 0;
            leftIndex--;

            StringBuilder left = new StringBuilder("0");
            StringBuilder right = new StringBuilder("0");

            for (int i = 0; i < leftIndex; i++)
            {
                left.Append(inputArray[i].ToString());
            }

            for (int i = (leftIndex + 1); i < inputArray.Length; i++)
            {
                right.Append(inputArray[i].ToString());
            }
            leftNumber = Convert.ToInt32(left.ToString());
            rightNumber = Convert.ToInt32(right.ToString());
            long sum = leftNumber + rightNumber;
            if (sum % 2 == 0 && sum % 3 == 0 && sum % 5 == 0)
            {
                result = 1;
            }

            return result;
        }

        public static void EEDCString()
        {
            long N = Convert.ToInt32(Console.ReadLine());
            string[] allIntegers = Console.ReadLine().Split(' ');
            Dictionary<long, long> luckyIndices = new Dictionary<long, long>();
            List<long> finalResult = new List<long>();
            long Queries = Convert.ToInt32(Console.ReadLine());

            for (long i = 0; i < Queries; i++)
            {
                string[] LR = Console.ReadLine().Split(' ');
                long leftIndex = Convert.ToInt64(LR[0]);
                long rightIndex = Convert.ToInt64(LR[1]);
                long finalSum = 0;

                for (long currentIndex = leftIndex; currentIndex <= rightIndex; currentIndex++)
                {
                    if (luckyIndices.ContainsKey(currentIndex))
                    {
                        finalSum = luckyIndices[currentIndex];
                    }
                    else
                    {
                        finalSum = EEDCSumString(currentIndex, allIntegers);
                        luckyIndices.Add(currentIndex, finalSum);
                    }

                    if (finalSum > 0)
                    {
                        break;
                    }
                }
                finalResult.Add(finalSum);
            }

            foreach (int item in finalResult)
            {
                Console.WriteLine(item);
            }
        }
        public static long EEDCSumString(long leftIndex, string[] inputArray)
        {
            long result = 0;
            leftIndex--;
            StringBuilder left = new StringBuilder("0");
            StringBuilder right = new StringBuilder("0");

            for (long i = 0; i < leftIndex; i++)
            {
                left.Append(inputArray[i].ToString());
            }

            for (long i = (leftIndex + 1); i < inputArray.Length; i++)
            {
                right.Append(inputArray[i].ToString());
            }

            ulong leftNumber = Convert.ToUInt64(left.ToString());
            ulong rightNumber = Convert.ToUInt64(right.ToString());
            ulong sum = leftNumber + rightNumber;

            if (sum % 2 == 0 && sum % 3 == 0 && sum % 5 == 0)
            {
                result = 1;
            }
            return result;
        }


        public static void ArrayGame()
        {
            string[] arraySizes = Console.ReadLine().Split(' ');
            int[] A = new int[Convert.ToInt32(arraySizes[0])];
            int[] B = new int[Convert.ToInt32(arraySizes[1])];

            string[] inputA = Console.ReadLine().Split(' ');
            string[] inputB = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputA.Length; i++)
            {
                A[i] = Convert.ToInt32(inputA[i]);
            }
            for (int i = 0; i < inputB.Length; i++)
            {
                B[i] = Convert.ToInt32(inputB[i]);
            }

            //heapSortString(inputA, inputA.Length);

            heapSort(A, A.Length);
            heapSort(B, B.Length);

            int minimumNumber = A[0];
            int maximumNumber = B[B.Length - 1];

            int difference = maximumNumber - minimumNumber;
            Console.WriteLine(difference);

        }

        public static void MIvsCSKandPearls()
        {
            List<PeakValueProfit> peakValueProfits = new List<PeakValueProfit>();

            string[] NK = Console.ReadLine().Split(' ');
            string[] Nitems = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(NK[0]);
            int K = Convert.ToInt32(NK[1]);
            List<int> prices = new List<int>();
            prices.Add(Convert.ToInt32(Nitems[0]));

            for (int i = 1; i < Nitems.Length; i++)
            {
                int currentPrice = Convert.ToInt32(Nitems[i]);

                if (currentPrice != prices[prices.Count() - 1])
                {
                    prices.Add(currentPrice);
                }
            }

            int firstLowerNumber = prices[0];
            bool peak = false;
            bool valley = false;
            int lastValley = 0;
            int lastPeak = 0;
            Dictionary<int, string> pv = new Dictionary<int, string>();

            List<int> priceJumps = new List<int>();

            for (int i = 0; i < prices.Count(); i++)
            {
                if (peak == false && valley == false)//determine the first number is peak or valley
                {
                    if (prices[i] < firstLowerNumber)
                    {
                        valley = true;
                        lastValley = prices[i];
                        pv.Add(i - 1, "Peak");
                    }
                    else if (prices[i] > firstLowerNumber)
                    {
                        peak = true;
                        lastPeak = prices[i];
                        pv.Add(i - 1, "Valley");
                    }
                }
                else
                {
                    if (valley == true && lastValley < prices[i])
                    {
                        valley = false;
                        peak = true;
                        lastPeak = prices[i];
                        pv.Add(i - 1, "Valley");
                        //pv.Add(i, "P");
                    }
                    if (peak == true && prices[i - 1] > prices[i])
                    {
                        valley = true;
                        peak = false;
                        pv.Add(i - 1, "Peak");
                    }
                }
            }

            if (peak == true)
            {
                pv.Add(prices.Count() - 1, "Peak");
            }
            else
            {
                pv.Add(prices.Count() - 1, "Valley");
            }

            int highestPeak = pv.Where(x => x.Value == "Peak").FirstOrDefault().Key;

            foreach (KeyValuePair<int, string> kv in pv.Where(x => x.Value == "Peak"))
            {
                if (prices[kv.Key] > prices[highestPeak])
                {
                    highestPeak = kv.Key;
                }
            }

            int deepestValley = pv.Where(x => x.Value == "Valley").FirstOrDefault().Key;
            Dictionary<int, int> finalValleyPeak = new Dictionary<int, int>();

            //foreach(KeyValuePair<int, string> kv in pv)
            //{
            //    Console.WriteLine(kv.Key + " Index : " + kv.Value + " Value : " + prices[kv.Key]);
            //}
            //Console.WriteLine("\n\n");

            foreach (KeyValuePair<int, string> currentPeak in pv.Where(x => x.Value == "Peak"))//foreach peak find all the vallies before the peak and then find the maximum value of profit
            {
                int maximumProfit = 0;
                int currentDeepestValley = -1;

                foreach (KeyValuePair<int, string> currentValley in pv.Where(x => x.Value == "Valley"))
                {
                    if (currentValley.Key < currentPeak.Key)
                    {
                        int currentProfit = prices[currentPeak.Key] - prices[currentValley.Key];

                        if (currentProfit > maximumProfit)
                        {
                            currentDeepestValley = currentValley.Key;
                            maximumProfit = currentProfit;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentDeepestValley > -1)
                {
                    finalValleyPeak.Add(currentPeak.Key, currentDeepestValley);
                    int tempDifference = prices[currentPeak.Key] - prices[currentDeepestValley];
                    int tempProfit = tempDifference * K;
                    PeakValueProfit obProfits = new PeakValueProfit();
                    obProfits.peak = currentPeak.Key;
                    obProfits.valley = currentDeepestValley;
                    obProfits.profit = tempProfit;
                    peakValueProfits.Add(obProfits);
                    //Console.WriteLine("Index : "+ currentPeak.Key +" Peak Value : " + prices[currentPeak.Key] + " Deepest Valley : " + prices[currentDeepestValley] + " And Maximum Difference : " + tempDifference + " Maximum Profit : " + tempProfit );
                }
            }

            Console.WriteLine(peakValueProfits.Max(x => x.profit));
            //Console.WriteLine()
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Deepest Valley : " + prices[deepestValley]);
            //Console.WriteLine("Highest Peak : " + prices[highestPeak]);
            //Console.WriteLine("Maximum Value : " + (prices[highestPeak] - prices[deepestValley]));
            //Console.WriteLine(prices[highestPeak] - prices[deepestValley]);
        }
        public static void MIvsCSKandPearlsOld()
        {
            string[] NK = Console.ReadLine().Split(' ');
            string[] Nitems = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(NK[0]);
            int K = Convert.ToInt32(NK[1]);
            List<int> prices = new List<int>();
            prices.Add(Convert.ToInt32(Nitems[0]));

            for (int i = 1; i < Nitems.Length; i++)
            {
                int currentPrice = Convert.ToInt32(Nitems[i]);

                if (currentPrice != prices[prices.Count() - 1])
                {
                    prices.Add(currentPrice);
                }
            }

            int firstLowerNumber = prices[0];
            bool peak = false;
            bool valley = false;
            int lastValley = 0;
            int lastPeak = 0;

            Dictionary<int, string> pv = new Dictionary<int, string>();
            List<int> priceJumps = new List<int>();

            for (int i = 0; i < prices.Count(); i++)
            {
                if (peak == false && valley == false)//determine the first number is peak or valley
                {
                    if (prices[i] < firstLowerNumber)
                    {
                        valley = true;
                        lastValley = prices[i];
                        //pv.Add(i - 1, "Peak");
                        pv.Add(i, "Peak");
                    }
                    else if (prices[i] > firstLowerNumber)
                    {
                        peak = true;
                        lastPeak = prices[i];
                        //pv.Add(i - 1, "Valley");
                        pv.Add(i, "Valley");
                    }
                }
                else
                {
                    if (valley == true && lastValley < prices[i])
                    {
                        valley = false;
                        peak = true;
                        lastPeak = prices[i];
                        //pv.Add(i - 1, "Valley");
                        pv.Add(i, "Valley");
                    }
                    if (peak == true && prices[i - 1] > prices[i])
                    {
                        valley = true;
                        peak = false;
                        //pv.Add(i - 1, "Peak");
                        pv.Add(i, "Peak");
                    }
                }
            }

            if (peak == true)
            {
                pv.Add(prices.Count() - 1, "Peak");
            }
            else
            {
                pv.Add(prices.Count() - 1, "Valley");
            }

            int highestPeak = pv.Where(x => x.Value == "Peak").FirstOrDefault().Key;

            foreach (KeyValuePair<int, string> kv in pv.Where(x => x.Value == "Peak"))
            {
                if (prices[kv.Key] > prices[highestPeak])
                {
                    highestPeak = kv.Key;
                }
                //Console.WriteLine(kv.Value + " : " + prices[kv.Key]);
            }

            int deepestValley = pv.Where(x => x.Value == "Valley").FirstOrDefault().Key;

            foreach (KeyValuePair<int, string> kv in pv.Where(x => x.Value == "Valley"))
            {
                if (kv.Key < highestPeak)
                {
                    if (prices[kv.Key] < prices[deepestValley])
                    {
                        deepestValley = kv.Key;
                    }
                }
                else
                {
                    break;
                }
            }
            //Console.WriteLine("Deepest Valley : " + prices[deepestValley]);
            //Console.WriteLine("Highest Peak : " + prices[highestPeak]);
            //Console.WriteLine("Maximum Value : " + (prices[highestPeak] - prices[deepestValley]));
            Console.WriteLine(K * (prices[highestPeak] - prices[deepestValley]));
        }

        //static void heapSortString(string[] arr, int n)
        //{
        //    for (int i = n / 2 - 1; i >= 0; i--)
        //        heapify(arr, n, i);
        //    for (int i = n - 1; i >= 0; i--)
        //    {
        //        int temp = arr[0];
        //        arr[0] = arr[i];
        //        arr[i] = temp;
        //        heapify(arr, i, 0);
        //    }
        //}

        //static void heapifyString(string[] arr, int n, int i)
        //{
        //    int largest = i;
        //    int left = 2 * i + 1;
        //    int right = 2 * i + 2;
        //    if (left < n && arr[left] > arr[largest])
        //        largest = left;
        //    if (right < n && arr[right] > arr[largest])
        //        largest = right;
        //    if (largest != i)
        //    {
        //        int swap = arr[i];
        //        arr[i] = arr[largest];
        //        arr[largest] = swap;
        //        heapify(arr, n, largest);
        //    }
        //}

        static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }

        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }

        #endregion Unsolved


        public static void MonkAndPrisonerOfAzkaban()//partially works 3 test casess executed successfully TLE in next 12 Test cases
        {
            int N = Convert.ToInt32(Console.ReadLine());
            long[] A = new long[N];
            string[] integers = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt64(integers[i]);
            }

            int x = 0;
            int y = 0;

            List<long> xyResult = new List<long>();

            for (int i = 0; i < N; i++)
            {
                x = -1;

                if (i > 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (A[j] > A[i])
                        {
                            x = j + 1;
                            break;
                        }
                    }
                }

                y = -1;

                for (int j = i + 1; j < N; j++)
                {
                    if (A[j] > A[i])
                    {
                        y = j + 1;
                        break;
                    }
                }
                xyResult.Add(x + y);
            }
            Console.WriteLine(String.Join(" ", xyResult));
        }

        public static void MonkAndPrisonerOfAzkabanStack()
        {

        }

        public static void PlayWithNumbers()
        {
            string[] NQ = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(NQ[0]);
            int Q = Convert.ToInt32(NQ[1]);
            Dictionary<int, int> queries = new Dictionary<int, int>();
            List<LeftRighSum> listLRS = new List<LeftRighSum>();
            int[] arrayA = new int[N];
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < elements.Length; i++)
            {
                arrayA[i] = Convert.ToInt32(elements[i]);
            }

            for (int i = 0; i < Q; i++)
            {
                string[] LR = Console.ReadLine().Split(' ');
                int L = Convert.ToInt32(LR[0]);
                int R = Convert.ToInt32(LR[1]);
                queries.Add(L, R);
            }

            foreach(KeyValuePair<int, int> item in queries)
            {               
                int L = item.Key;
                L--;
                int R = item.Value;
                R--;

                int sum = 0;
                for (int j = L; j <= R; j++)
                {
                    sum += arrayA[j];
                }
                int count = R - L;
                count++;
                int mean = sum / count;
                Console.WriteLine(mean);

                LeftRighSum obLRS = new LeftRighSum();
                obLRS.Left = item.Key;
                obLRS.Right = item.Value;
                obLRS.Sum = sum;

                listLRS.Add(obLRS);
            }
        }

        public static KeyValuePair<int, int> CheckLeftRight(List<LeftRighSum> listLRS, KeyValuePair<int, int> obLR)
        {
            KeyValuePair<int, int> leftSum = new KeyValuePair<int, int>();
            List<LeftRighSum> resultList = new List<LeftRighSum>();
            resultList = listLRS.Where(x => x.Left <= obLR.Key && x.Right <= obLR.Value).ToList();
            
            if(resultList.Count >0)
            {
                
            }
            else
            {
                //leftSum.Key = 0;
                //leftSum.Value = 0;
            }
            return leftSum;
        }


        #region Practice

        private static void PrimeNumberPractice()
        {
            int max = Convert.ToInt32(Console.ReadLine());
            List<int> primeNumbers = new List<int>();

            if (max == 2 || max == 1)
            {
                if (max == 2)
                {
                    primeNumbers.Add(max);
                }
            }
            else
            {
                for (int i = 2; i < max; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", primeNumbers));
        }

        private static void SeatingArrangement()
        {
            string[] seatType = new string[] { "WS", "MS", "AS", "AS", "MS", "WS" };
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<SeatingArragements> results = new List<SeatingArragements>();
            //Dictionary<int, string> results = new Dictionary<int, string>();

            for (int i = 0; i < testCases; i++)
            {
                int seatNumber = Convert.ToInt32(Console.ReadLine());
                //get seat number and current cycle
                int cycles = 0;
                int halves = 1;
                int currentPosition = seatNumber;
                int oppositeSeat = 0;
                int finalSeat = 0;
                SeatingArragements currentSeating = new SeatingArragements();

                if (seatNumber >= 12)
                {
                    cycles = seatNumber / 12;
                    currentPosition = seatNumber % 12;
                }

                if (currentPosition > 6)
                {
                    halves++;
                    int temp = currentPosition - 6;
                    oppositeSeat = 6 - (temp - 1);
                    oppositeSeat = (cycles * 12) + oppositeSeat;
                }
                else
                {
                    if (currentPosition == 0)
                    {
                        oppositeSeat = (cycles * 12) + oppositeSeat;
                        oppositeSeat -= 11;
                    }
                    else
                    {
                        oppositeSeat = 12 + (1 - currentPosition);
                        oppositeSeat = (cycles * 12) + oppositeSeat;
                    }
                }
                if (currentPosition > 6)
                {
                    currentPosition = currentPosition - 6;
                }

                if (currentPosition == 0)
                {
                    //results.Add(oppositeSeat, seatType[currentPosition]);
                    currentSeating.seatNumber = oppositeSeat;
                    currentSeating.seatType = seatType[currentPosition];
                }
                else
                {
                    currentSeating.seatNumber = oppositeSeat;
                    currentSeating.seatType = seatType[currentPosition - 1];
                    //results.Add(oppositeSeat, seatType[currentPosition - 1]);
                }

                results.Add(currentSeating);
            }

            foreach (var item in results)
            {
                Console.WriteLine(item.seatNumber + " " + item.seatType);
            }
        }

        private static void HelpJarvis()
        {
            string[] trains = new string[Convert.ToInt32(Console.ReadLine())];
            string[] result = new string[trains.Length];

            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = Console.ReadLine();
                int[] myArray = trains[i].Select(x => Int32.Parse(x.ToString())).ToArray();
                Array.Sort(myArray);
                bool isSequential = Enumerable.Range(0, myArray.Length).Any(s => myArray[s] != myArray[0] + s);

                if (isSequential)
                {
                    result[i] = "NO";
                }
                else
                {
                    result[i] = "YES";
                }
            }

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void MostFrequent()
        {
            //string[] s = Console.ReadLine().Split(' ');
            string inputSize = Console.ReadLine();
            //string s = Console.ReadLine().Replace(" ","");
            string[] s = Console.ReadLine().Split(' ');

            var count = s.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }

        private static void PrimeNumber()
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            List<string> primeNumbers = new List<string>();

            if (inputNumber == 2)
            {
                primeNumbers.Add(inputNumber.ToString());
            }
            else if (inputNumber > 2)
            {
                primeNumbers.Add("2");
                for (int i = 3; i < inputNumber; i++)
                {
                    bool prime = true;
                    //int maxDivisor = (int)i / 2;
                    //for(int j=2; j<maxDivisor; j++)
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        primeNumbers.Add(i.ToString());
                    }
                }
            }
            Console.WriteLine(string.Join(" ", primeNumbers));
        }

        private static void HamiltonianAndLagrangin()
        {
            int[] inputArray = new int[Convert.ToInt32(Console.ReadLine())];

            string[] inputItems = Console.ReadLine().Split(' ');
            for (int i = 0; i < inputItems.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(inputItems[i]);
            }

            List<int> results = new List<int>();
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (j != (inputArray.Length - 1))
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        //sort the array and then call the recursive function or binary search to search for the max element
                        int[] subArray = new int[inputArray.Length - j];
                        //subArray
                        //call recursive function
                        results.Add(inputArray[j]);
                    }
                }
            }
            results.Add(inputArray[inputArray.Length - 1]);

            Console.WriteLine(String.Join(" ", results));
        }

        private static void MaximizeTheEarning()
        {
            int street = Convert.ToInt32(Console.ReadLine());
            int[] earnings = new int[street];

            for (int i = 0; i < street; i++)
            {
                string[] NR = Console.ReadLine().Split(' ');
                int[] buildings = new int[Convert.ToInt32(NR[0])];
                int earningPerBuilding = Convert.ToInt32(NR[1]);

                string[] inputBuildings = Console.ReadLine().Split();

                for (int j = 0; j < buildings.Length; j++)
                {
                    buildings[j] = Convert.ToInt32(inputBuildings[j]);
                }

                int ableToSee = 1;
                int maxHeight = buildings[0];

                for (int k = 1; k < buildings.Length; k++)
                {
                    if (buildings[k] > maxHeight)
                    {
                        ableToSee++;
                        maxHeight = buildings[k];
                    }
                }

                earnings[i] = earningPerBuilding * ableToSee;
            }

            foreach (int item in earnings)
            {
                Console.WriteLine(item);
            }
        }

        private static void BinaryQueries()
        {
            string[] NQ = Console.ReadLine().Split(' ');//N & Q
            string[] Q = new string[Convert.ToInt32(NQ[1])];//Q
            string[] N = Console.ReadLine().Split(' ');//N values

            for (int i = 0; i < Q.Length; i++)
            {
                string[] query = Console.ReadLine().Split(' ');

                if (Convert.ToInt32(query[0]) == 1)
                {
                    int flipIndex = Convert.ToInt32(query[1]) - 1;
                    N[flipIndex] = (N[flipIndex] == "1") ? "0" : "1";
                }
                else
                {
                    int lastBit = Convert.ToInt32(N[Convert.ToInt32(query[2]) - 1]);
                    Console.WriteLine((lastBit == 0) ? "EVEN" : "ODD");
                }
            }
        }

        private static void BinaryQueriesTwo()
        {
            string[] NQ = Console.ReadLine().Split(' ');//N & Q
            string[] Q = new string[Convert.ToInt32(NQ[1])];//Q
            string[] N = Console.ReadLine().Split(' ');//N values

            for (int i = 0; i < Q.Length; i++)
            {
                Q[i] = Console.ReadLine();
                string[] query = Q[i].Split(' ');

                if (Convert.ToInt32(query[0]) == 1)
                {
                    //query type 1 - flip x
                    int flip = Convert.ToInt32(query[1]);
                    int flipIndex = flip - 1;
                    if (N[flipIndex] == "1")
                    {
                        N[flipIndex] = "0";
                    }
                    else
                    {
                        N[flipIndex] = "1";
                    }
                }
                else
                {
                    //query type 2 - identify the ODD or EVEN
                    int r = Convert.ToInt32(query[2]);
                    string rN = N[r - 1];
                    int lastBit = Convert.ToInt32(rN);
                    if (lastBit == 0)
                    {
                        Console.WriteLine("EVEN");
                    }
                    else
                    {
                        Console.WriteLine("ODD");
                    }
                    //Console.WriteLine((lastBit == 0) ? "EVEN" : "ODD");
                }
            }
        }

        private static void BinaryQueriesOne()
        {
            string[] userInputs = Console.ReadLine().Split(' ');//N & Q
            //int[] binaryNumbers = new int [Convert.ToInt32(userInputs[0])];//N
            string[] q = new string[Convert.ToInt32(userInputs[1])];//Q

            string[] n = Console.ReadLine().Split(' ');//N values

            for (int i = 0; i < q.Length; i++)
            {
                q[i] = Console.ReadLine();

                string[] query = q[i].Split(' ');

                if (query.Length <= 2)
                {
                    //query type 1 - flip x
                    int flip = Convert.ToInt32(query[1]);
                    n[flip - 1] = query[0];
                }
                else
                {
                    //query type 2 - identify the ODD or EVEN
                    int r = Convert.ToInt32(query[2]);
                    string rN = n[r - 1];
                    int lastBit = Convert.ToInt32(rN);

                    Console.WriteLine((lastBit == 0) ? "EVEN" : "ODD");
                }
            }
            //for (int i = 0; i < binaryNumbers.Length; i++)
            //{
            //    //convert N inputs received in string to integer array
            //    binaryNumbers[i] = Convert.ToInt32(binaryInputs[i]);
            //}
        }

        private static void MemoriseMe()
        {
            string[] arrayItems = new string[Convert.ToInt32(Console.ReadLine())];
            arrayItems = Console.ReadLine().Split(' ');
            int[] memoryArray = new int[arrayItems.Length];

            for (int i = 0; i < arrayItems.Length; i++)
            {
                memoryArray[i] = Convert.ToInt32(arrayItems[i]);
            }
            Array.Sort(memoryArray);
            int[] customQueryResult = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < customQueryResult.Length; i++)
            {
                int queryItem = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int binaryPosition = MemoriseMeBinarySearch(memoryArray, queryItem);

                if (binaryPosition >= 0)
                {
                    count++;
                    //left array
                    for (int j = (binaryPosition - 1); j >= 0; j--)
                    {
                        if (queryItem == memoryArray[j])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //right array
                    for (int k = (binaryPosition + 1); k < memoryArray.Length; k++)
                    {
                        if (queryItem == memoryArray[k])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                customQueryResult[i] = count;
            }
            foreach (int item in customQueryResult)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }
        private static int MemoriseMeBinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        private static void MemoriseMeFourth()
        {
            string[] arrayItems = new string[Convert.ToInt32(Console.ReadLine())];
            arrayItems = Console.ReadLine().Split(' ');
            int[] memoryArray = new int[arrayItems.Length];

            for (int i = 0; i < arrayItems.Length; i++)
            {
                memoryArray[i] = Convert.ToInt32(arrayItems[i]);
            }
            Array.Sort(memoryArray);
            int[] customQueryResult = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < customQueryResult.Length; i++)
            {
                int queryItem = Convert.ToInt32(Console.ReadLine());
                bool itemFound = false;
                int count = 0;

                for (int j = 0; j < memoryArray.Length; j++)
                {
                    if (itemFound == true && queryItem != memoryArray[j])
                    {
                        break;
                    }
                    else if (queryItem == memoryArray[j])
                    {
                        itemFound = true;
                        count++;
                    }
                }
                customQueryResult[i] = count;
            }
            foreach (int item in customQueryResult)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }

        private static void MemoriseMeBinarySearchThird()
        {
            string[] arrayItems = new string[Convert.ToInt32(Console.ReadLine())];
            arrayItems = Console.ReadLine().Split(' ');
            int[] memoryArray = new int[arrayItems.Length];

            for (int i = 0; i < arrayItems.Length; i++)
            {
                memoryArray[i] = Convert.ToInt32(arrayItems[i]);
            }

            Array.Sort(memoryArray);
            int[] queryResult = new int[Convert.ToInt32(Console.ReadLine())];
            int[] binaryResult = new int[queryResult.Length];

            for (int i = 0; i < queryResult.Length; i++)
            {
                int queryItem = Convert.ToInt32(Console.ReadLine());
                queryResult[i] = memoryArray.Count(x => x == queryItem);
                binaryResult[i] = BinarySearch(memoryArray, queryItem);
            }

            foreach (int item in queryResult)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }

        }

        private static void MemoriseMeSecond()
        {
            string[] arrayItems = new string[Convert.ToInt32(Console.ReadLine())];
            arrayItems = Console.ReadLine().Split(' ');
            int[] memoryArray = new int[arrayItems.Length];

            for (int i = 0; i < arrayItems.Length; i++)
            {
                memoryArray[i] = Convert.ToInt32(arrayItems[i]);
            }

            Array.Sort(memoryArray);
            int[] queryResult = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < queryResult.Length; i++)
            {
                int queryItem = Convert.ToInt32(Console.ReadLine());
                queryResult[i] = memoryArray.Count(x => x == queryItem);
            }

            foreach (int item in queryResult)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }

        private static void MemoriseMeFirst()
        {
            string[] arrayItems = new string[Convert.ToInt32(Console.ReadLine())];
            arrayItems = Console.ReadLine().Split(' ');
            int[] memoryArray = new int[arrayItems.Length];

            for (int i = 0; i < arrayItems.Length; i++)
            {
                memoryArray[i] = Convert.ToInt32(arrayItems[i]);
            }
            GC.Collect();

            int[] queryItems = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < queryItems.Length; i++)
            {
                queryItems[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in queryItems)
            {
                int isPresent = 0;

                isPresent = memoryArray.Count(x => x == item);
                if (isPresent > 0)
                {
                    Console.WriteLine(isPresent);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
        }

        private static void MonkAndWelcomeProblem()
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] c = new int[arraySize];
            string[] itemsA = new string[arraySize];
            string[] itemsB = new string[arraySize];

            itemsA = Console.ReadLine().Split(' ');
            itemsB = Console.ReadLine().Split(' ');

            for (int i = 0; i < arraySize; i++)
            {
                c[i] = Convert.ToInt32(itemsA[i]) + Convert.ToInt32(itemsB[i]);
            }
            Console.WriteLine(string.Join(" ", c));
        }


        /// <summary>
        /// Hacker Earth ds\1d\practice problem
        /// </summary>
        private static void MicroAndArrayUpdate()
        {
            int[] result = new int[Convert.ToInt32(Console.ReadLine())];
            if (result.Length > 0)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    string[] testCaseDetails = Console.ReadLine().Split(' ');
                    int[] testCaseArray = new int[Convert.ToInt32(testCaseDetails[0])];
                    int targetValue = Convert.ToInt32(testCaseDetails[1]);

                    string[] testCaseArrayItems = Console.ReadLine().Split(' ');

                    for (int j = 0; j < testCaseArray.Length; j++)
                    {
                        testCaseArray[j] = Convert.ToInt32(testCaseArrayItems[j]);
                    }

                    int smallestNumber = testCaseArray.Min();
                    int testCaseResult = targetValue - smallestNumber;

                    result[i] = 0;

                    if (testCaseResult >= 1)
                    {
                        result[i] = testCaseResult;
                    }
                }
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void MicroAndArrayUpdate2()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            List<long> result = new List<long>();

            for (int i = 0; i < T; i++)
            {
                string[] NK = Console.ReadLine().Split(' ');
                int[] A = new int[Convert.ToInt32(NK[0])];
                string[] arrayItems = Console.ReadLine().Split(' ');
                long smallestItem = Convert.ToInt32(arrayItems[0]);

                for (int j = 0; j < arrayItems.Length; j++)
                {
                    A[j] = Convert.ToInt32(arrayItems[j]);
                    if (smallestItem > A[j])
                    {
                        smallestItem = A[j];
                    }
                }
                long arrayResult = Convert.ToInt32(NK[1]) - smallestItem;
                result.Add(arrayResult);
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void splitString()
        {
            string sample = "5 7";
            string[] splitValues = sample.Split(' ');
        }

        static void oldSchoolFindSmallestNumber()
        {
            int[] myArray = new int[] { 10, 11, 3, 5, 8 };
            int smallestNumber = myArray[0];

            foreach (int item in myArray)
            {
                if (smallestNumber > item)
                {
                    smallestNumber = item;
                }
            }
        }

        static void findSmallestNumber()
        {
            int[] myArray = new int[] { 10, 11, 3, 5, 8 };
            int smallesNumber = myArray.Min();
        }

        private static void TakeOff()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> resultDays = new List<int>();

            for (int i = 0; i < testCases; i++)
            {
                int takeOffDays = 0;
                string[] testCaseDetails = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(testCaseDetails[0]);
                int A = Convert.ToInt32(testCaseDetails[1]);
                int B = Convert.ToInt32(testCaseDetails[2]);
                int C = Convert.ToInt32(testCaseDetails[3]);

                for (int j = 1; j <= N; j++)
                {
                    int flightsTakingOff = 0;

                    if (j % A == 0)
                    {
                        flightsTakingOff++;
                    }

                    if (j % B == 0)
                    {
                        flightsTakingOff++;
                    }

                    if (j % C == 0)
                    {
                        flightsTakingOff++;
                    }

                    if (flightsTakingOff == 1)
                    {
                        takeOffDays++;
                    }
                }
                resultDays.Add(takeOffDays);
            }

            foreach (int item in resultDays)
            {
                Console.WriteLine(item);
            }
        }

        private static void LongATMQueue()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] queue = Console.ReadLine().Split(' ');
            int groups = 1;
            int maximumHeight = 0;

            foreach (string item in queue)
            {
                int currentHeight = Convert.ToInt32(item);

                if (currentHeight >= maximumHeight)
                {
                    maximumHeight = currentHeight;
                }
                else
                {
                    maximumHeight = currentHeight;
                    groups++;
                }
            }

            Console.WriteLine(groups);
        }

        private static void MonkAndPowerOfTime()//working successfully
        {
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                List<string> callingOrder = new List<string>();
                List<string> idealOrder = new List<string>();

                callingOrder = Console.ReadLine().Split(' ').ToList();
                idealOrder = Console.ReadLine().Split(' ').ToList();

                int totalTime = 0;
                int currentPosition = 0;

                while (N > 0)
                {
                    totalTime++;
                    if (callingOrder[currentPosition] == idealOrder[0])
                    {
                        callingOrder.RemoveAt(currentPosition);
                        idealOrder.RemoveAt(0);
                        N--;
                        currentPosition--;
                    }

                    if (currentPosition == (N - 1))
                    {
                        currentPosition = 0;
                    }
                    else
                    {
                        currentPosition++;
                    }
                }
                Console.WriteLine(totalTime);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void MonkAndPowerOfTimeUsingQueue()// working solution using queue
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> callingOrder = new List<string>(Console.ReadLine().Split(' '));
            Queue<string> idealOrder = new Queue<string>(Console.ReadLine().Split(' '));
            int totalTime = 0;
            int currentPosition = 0;

            while (idealOrder.Count() > 0)
            {
                totalTime++;

                if (idealOrder.Peek() == callingOrder[currentPosition])
                {
                    idealOrder.Dequeue();
                    callingOrder.RemoveAt(currentPosition);
                    currentPosition--;
                    N--;
                }

                if (currentPosition == (N - 1))
                {
                    currentPosition = 0;
                }
                else
                {
                    currentPosition++;
                }
            }
            Console.WriteLine(totalTime);
        }
        public static void BirthdayParty()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                string[] NM = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(NM[0]);
                int M = Convert.ToInt32(NM[1]);

                if (M % N == 0)
                {
                    result.Add("Yes");
                }
                else
                {
                    result.Add("No");
                }
            }

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }



        #endregion Practice


        #region CommonMethods


        private static int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return 0;
        }

        #endregion CommonMethods


        #region Companies
        public void Companies()
        {
            //obHoneywell.DivideArray();
        }
        #endregion Companies

        #region Circuits

        public void Circuits()
        {
            //obCircuits.DistributionOfToys();

            int totalFriendsN = 11;
            List<string> identityDislikes = new List<string>();
            identityDislikes.Add("7 3 11 4 5 6 1 2 8 9");
            identityDislikes.Add("1 11 10 5 6 8 3 7 4 2");
            identityDislikes.Add("9 3 2 7 5 8 10 4 1 11");
            identityDislikes.Add("8 2 5 10 3 6 4 7 9 1");
            identityDislikes.Add("3 10 2 11 7 9 1 5 6 4");
            identityDislikes.Add("5 11 1 3 8 10 4 6 2 9");
            identityDislikes.Add("11 1 8 7 3 2 10 6 5 9");
            identityDislikes.Add("4 1 5 11 10 6 3 2 9 7");
            identityDislikes.Add("2 1 9 11 8 6 7 10 3 4");
            identityDislikes.Add("10 5 4 1 3 6 2 11 7 8");
            obCircuits.DislikesAndParty(totalFriendsN, identityDislikes);

            int totalFriendsN2 = 10;
            List<string> identityDislikes2 = new List<string>();
            identityDislikes2.Add("1 2 3 4 5 6");
            identityDislikes2.Add("2 1 3 8 10");
            identityDislikes2.Add("3 1 2 4 10");
            obCircuits.DislikesAndParty(totalFriendsN2, identityDislikes2);

        }

        #endregion Circuits
    }
}

public class LeftRighSum
{
    private int left;
    private int right;
    private int sum;
    public int Left
    {
        get { return left;  }
        set { left = value; }            
    }

    public int Right
    {
        get { return right; }
        set { right = value; }
    }

    public int Sum
    {
        get { return sum; }
        set { sum = value; }
    }
}
