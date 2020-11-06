using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Divisibility
    {
        public static string BasicImplementation(int N, string numbers)
        {
            string lastItem = numbers.Substring((numbers.Length - 1), 1);

            if(lastItem == "0")
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string numbers = Console.ReadLine();

            string lastItem = numbers.Substring((numbers.Length - 1), 1);

            if (lastItem == "0")
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
