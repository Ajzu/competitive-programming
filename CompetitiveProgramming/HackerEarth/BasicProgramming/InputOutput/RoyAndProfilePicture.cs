using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class RoyAndProfilePicture
    {
        public static string BasicImplementation()
        {
            string result = "";
            int L = 180;
            int N = 3;

            for(int i=0; i<N; i++)
            {
                string[] WH = "640 480".Split(' ');
                int W = Convert.ToInt32(WH[0]);
                int H = Convert.ToInt32(WH[1]);

                if (W < L || H < L)
                {
                    result = "UPLOAD ANOTHER";
                }
                else
                {
                    if(W == H)
                    {
                        result = "ACCEPTED";
                    }
                    else
                    {
                        result = "CROP IT";
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// HackerEarthImplementation
        /// Solved - passed all the 7 test cases.
        /// </summary>
        public static void HackerEarthImplementation()
        {
            int L = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] WH = Console.ReadLine().Split(' ');
                int W = Convert.ToInt32(WH[0]);
                int H = Convert.ToInt32(WH[1]);

                if (W < L || H < L)
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else
                {
                    if (W == H)
                    {
                        Console.WriteLine("ACCEPTED");
                    }
                    else
                    {
                        Console.WriteLine("CROP IT");
                    }
                }
            }
        }
    }
}
