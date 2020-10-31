using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Zoos
    {
        public static string BasicImplementation(string input)
        {
            int countZ = 0;

            foreach(char item in input.ToLower())
            {
                if(item == 'z')
                {
                    countZ++;
                }
            }

            int countO = input.Length - countZ;
            int result = 2 * countZ;

            if(result == countO)
            {
                Console.WriteLine("Yes");
                return "Yes";
            }
            else
            {
                Console.WriteLine("No");
                return "No";
            }
        }


        /// <summary>
        /// HackerEarthImplementation can be pasted directly in the HackerEarth and it will work
        /// Passed all the 6 test cases.
        /// </summary>
        public static void HackerEarthImplementation()
        {
            string input = Console.ReadLine();
            int countZ = 0;

            foreach (char item in input.ToLower())
            {
                if (item == 'z')
                {
                    countZ++;
                }
            }

            int countO = input.Length - countZ;
            int result = 2 * countZ;

            if (result == countO)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
