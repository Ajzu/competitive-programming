using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Movement
    {
        public static int BasicImplementation()
        {
            int n = 26;
            int[] steps = new int[] { 1, 2, 3, 4, 5 };

            int totalSteps = 0;

            for(int i=(steps.Length-1); i>=0; i--)
            {
                int divisor = steps[i];
                int quotient = n / divisor;
                int remainder = n % divisor;

                if(quotient > 0)
                {
                    totalSteps += quotient;
                    n = remainder;
                }
                
                if(n==0)
                {
                    break;
                }
            }
            return totalSteps;
        }


        /// <summary>
        /// HackerEarthImplementation of Movement problem.
        /// Solved - passed all the 7 test cases.
        /// </summary>
        public static void HackerEarthImplementation()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] steps = new int[] { 1, 2, 3, 4, 5 };

            int totalSteps = 0;

            for (int i = (steps.Length - 1); i >= 0; i--)
            {
                int divisor = steps[i];
                int quotient = n / divisor;
                int remainder = n % divisor;

                if (quotient > 0)
                {
                    totalSteps += quotient;
                    n = remainder;
                }

                if (n == 0)
                {
                    break;
                }
            }
            Console.WriteLine(totalSteps);
        }
    }
}
