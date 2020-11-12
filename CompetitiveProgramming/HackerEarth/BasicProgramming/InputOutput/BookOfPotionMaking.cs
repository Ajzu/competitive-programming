using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class BookOfPotionMaking
    {
        public static string BasicImplementation(string digitCode)
        {
            if(digitCode.Length != 10)
            {
                return "Illegal ISBN";
            }
            else
            {
                int totalSum = 0;

                for(int i=1; i<11; i++)
                {
                    int sum = i * Convert.ToInt32(digitCode.Substring((i-1),1));
                    totalSum += sum;
                }

                if(totalSum %11 == 0 && totalSum >10)
                {
                    return "Legal ISBN";
                }
                else
                {
                    return "Illegal ISBN";
                }
            }
        }

        public static void HackerEarthImplementation()
        {
            string digitCode = Console.ReadLine();
            if (digitCode.Length != 10)
            {
                Console.WriteLine( "Illegal ISBN" );
            }
            else
            {
                int totalSum = 0;

                for (int i = 1; i < 11; i++)
                {
                    int sum = i * Convert.ToInt32(digitCode.Substring((i - 1), 1));
                    totalSum += sum;
                }

                if (totalSum % 11 == 0 && totalSum > 10)
                {
                    Console.WriteLine( "Legal ISBN" );
                }
                else
                {
                    Console.WriteLine( "Illegal ISBN" );
                }
            }
        }
    }
}
