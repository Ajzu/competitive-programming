using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Ladderophilia
    {
        public static void HackerEarthImplementation()
        {
            int stepsOfLadder = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<stepsOfLadder; i++)
            {
                Console.WriteLine("*   *");
                Console.WriteLine("*   *");
                Console.WriteLine("*****");
            }
            Console.WriteLine("*   *");
            Console.WriteLine("*   *");
        }
    }
}
