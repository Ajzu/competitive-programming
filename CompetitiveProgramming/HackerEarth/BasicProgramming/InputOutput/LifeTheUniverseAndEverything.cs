using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class LifeTheUniverseAndEverything
    {
        public static void HackerEarthImplementation()
        {
            string input = Console.ReadLine();

            while(input != "42")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
