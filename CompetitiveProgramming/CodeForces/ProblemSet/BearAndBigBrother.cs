using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.CodeForces.ProblemSet
{
    public class BearAndBigBrother
    {
        /// <summary>
        /// Edit below written Main2 to Main method.
        /// Also, edit any other Main function to Main2 for running code from here.
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            BearAndBigBrotherMethod();
        }

        /// <summary>
        /// This is more of a mathemetical question where a and b values are changing by certain ratio.
        /// One solution is to use while loop.
        /// Other could be using the math equation to determine using some sort of mathemetical formula.
        /// By this we will avoid loop in case of higher input numbers to save memory and time.
        /// </summary>
        private static void BearAndBigBrotherMethod()
        {
            string[] weights = Console.ReadLine().Split().ToArray();

            int limak = Convert.ToInt32(weights[0]);
            int bob = Convert.ToInt32(weights[1]);
            int years = 0;

            if (limak <= bob)
            {
                while (limak <= bob)
                {
                    bob = bob * 2;
                    limak = limak * 3;
                    years++;
                }
            }
            Console.WriteLine(years);
            Console.ReadLine();
        }
    }
}
