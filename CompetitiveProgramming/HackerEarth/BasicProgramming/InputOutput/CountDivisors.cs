using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class CountDivisors
    {
        public static int BasicImplementation(int l, int r, int k)
        {
            int countDivisors = 0;

            for(int i=l; i<=r; i++)
            {
                if(i%k==0)
                {
                    countDivisors++;
                }
            }
            return countDivisors;
        }

        public static void HackerEarthImplementation()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int l = Convert.ToInt32(inputs[0]);
            int r = Convert.ToInt32(inputs[1]);
            int k = Convert.ToInt32(inputs[2]);

            int countDivisors = 0;

            for (int i = l; i <= r; i++)
            {
                if (i % k == 0)
                {
                    countDivisors++;
                }
            }
            Console.WriteLine(countDivisors);
        }
    }
}
