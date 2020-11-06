using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class DoctorsSecret
    {
        public static string BasicImplementation(string inputs)
        {
            string[] secretBook = inputs.Split(' ');
            int length = Convert.ToInt32(secretBook[0]);
            int pageNumber = Convert.ToInt32(secretBook[1]);

            if(length<= 23 && pageNumber >= 500 && pageNumber <= 1000)
            {
                return "Take Medicine";
            }
            else
            {
                return "Don't Take Medicine";
            }
        }

        public static void HackerEarthImplementation()
        {   
            string[] secretBook = Console.ReadLine().Split(' ');
            int length = Convert.ToInt32(secretBook[0]);
            int pageNumber = Convert.ToInt32(secretBook[1]);

            if (length <= 23 && pageNumber >= 500 && pageNumber <= 1000)
            {
                Console.WriteLine("Take Medicine");
            }
            else
            {
                Console.WriteLine("Don't Take Medicine");
            }
        }
    }
}
