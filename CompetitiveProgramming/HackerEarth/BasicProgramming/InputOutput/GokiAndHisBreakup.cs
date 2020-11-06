using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class GokiAndHisBreakup
    {
        public static string[] BasicImplementation(int N, int X, int[] Y)
        {
            string[] result = new string[N];

            for(int i=0; i<N; i++)
            {
                if(Y[i] >= X)
                {
                    result[i] = "YES";
                }
                else
                {
                    result[i] = "NO";
                }
            }

            return result;
        }

        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int X = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int Y = Convert.ToInt32(Console.ReadLine());

                if (Y >= X)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
