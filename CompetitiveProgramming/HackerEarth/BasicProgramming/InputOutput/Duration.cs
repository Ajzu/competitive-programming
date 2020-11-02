using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Duration
    {
        public static string[] BasicImplementation(int N, string[] works)
        {
            string[] result = new string[N];

            for(int i=0; i<N; i++)
            {
                string[] time = works[i].Split(' ');

                int SH = Convert.ToInt32(time[0]);
                int SM = Convert.ToInt32(time[1]);
                int EH = Convert.ToInt32(time[2]);
                int EM = Convert.ToInt32(time[3]);

                int totalStartingMinutes = (SH * 60) + SM;
                int totalEndingMinutes = (EH * 60) + EM;
                int differenceMinutes = totalEndingMinutes - totalStartingMinutes;

                int durationMinutes = differenceMinutes % 60;
                int durationHours = differenceMinutes / 60;

                result[i] = durationHours + " " + durationMinutes;
            }

            return result;
        }

        /// <summary>
        /// Solved- Passed all the 20 test cases
        /// </summary>
        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] time = Console.ReadLine().Split(' ');

                int SH = Convert.ToInt32(time[0]);
                int SM = Convert.ToInt32(time[1]);
                int EH = Convert.ToInt32(time[2]);
                int EM = Convert.ToInt32(time[3]);

                int totalSM = (SH * 60) + SM;
                int totalEM = (EH * 60) + EM;
                int differenceM = totalEM - totalSM;

                int durationM = differenceM % 60;
                int durationH = differenceM / 60;

                Console.WriteLine(durationH + " " + durationM);
            }
        }
    }
}
