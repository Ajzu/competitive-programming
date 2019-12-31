using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    public class HackerRank
    {
        public HackerRank()
        {
            // ArrayDS2D();
        }


        #region HackerRank



        #region 30Days Challenge
        static void ConditionalStatements()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
            {
                if (N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
        }
        #endregion 30Days Challenge


        #region InterviewPreparationKit

        public void ArrayDS2D()
        {
            int[,] myArray = new int[6, 6];
            Dictionary<int, int> hourglasses = new Dictionary<int, int>();
            List<Tuple<int, int, int>> hourGlassList = new List<Tuple<int, int, int>>();
            List<int> hourglassSum = new List<int>();

            for(int i=0; i<6; i++)
            {
                string[] currentRow = Console.ReadLine().Split(' ');
                for(int j=0; j<6; i++)
                {
                    myArray[i, j] = Convert.ToInt32(currentRow[j]);
                    //if(i<3)
                    //{

                    //}
                }
            }

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    int startIndex = j;
                    int sum = 0;
                    for(int k=j; k<j+3; k++)
                    {
                        //Get first row item
                        sum += myArray[i, k];
                        //Get third row item
                        sum += myArray[i + 2, k];
                    }
                    //Get second row item
                    sum += myArray[i + 1, j + 1];
                    hourglassSum.Add(sum);
                }

                //if(i<=3)
                //{
                //    for(int j=0; j<6)
                //}
            }

            Console.WriteLine(hourglassSum.Max());

            //string[] row0 = Console.ReadLine().Split(' ');
            //string[] row1 = Console.ReadLine().Split(' ');
            //string[] row2 = Console.ReadLine().Split(' ');
        }

        #endregion InterviewPreparationKit



        #endregion HackerRank
    }
}
