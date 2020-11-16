using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class TeddyAndTweety
    {
        public static string BasicImplementation(int N)
        {
            if(N %3 == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 3 == 0)
            {
                Console.WriteLine( "YES" );
            }
            else
            {
                Console.WriteLine( "NO" );
            }
        }
    }
}
