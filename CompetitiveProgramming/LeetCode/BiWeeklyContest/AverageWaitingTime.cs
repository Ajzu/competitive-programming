using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.BiWeeklyContest
{
    public class AverageWaitingTime
    {
        public static double AverageWaitingTimeImplementation(int[][] customers)
        {
            int begin = customers[0][0];
            int finish = 0;
            int totalWait = 0;

            foreach (int[] array in customers)
            {
                int arrival = array[0];
                int order = array[1];
                int wait = 0;

                if(arrival > begin)
                {
                    begin = arrival;
                }

                finish = begin + order;
                
                if (arrival < begin)
                {
                    wait = finish - arrival;
                }
                else
                {
                    wait = finish - begin;
                }

                begin = finish;
                totalWait += wait;
            }

            double averageWait = (double)totalWait /(double) customers.Length;

            return averageWait;
        }
    }
}
