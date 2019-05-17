using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerRank
{
    public class HackerRank
    {
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

        #endregion HackerRank
    }
}
