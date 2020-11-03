using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class IAmEasy
    {
        public static int[] BasicImplementation(int input)
        {
            int[] result = new int[10];

            for(int i=1; i<11; i++)
            {
                result[i - 1] = input * i;
            }

            return result;
        }

        public static void HackerEarthImplementation()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(input * i);
            }
        }
    }
}
