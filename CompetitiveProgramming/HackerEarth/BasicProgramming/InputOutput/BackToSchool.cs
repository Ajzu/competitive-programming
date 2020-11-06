using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class BackToSchool
    {
        public static int BasicImplementation(string inputs)
        {
            string[] points = inputs.Split(' ');
            int maxPoint = Convert.ToInt32(points[0]);

            for(int i=1; i<points.Length; i++)
            {
                if(maxPoint < Convert.ToInt32(points[i]))
                {
                    maxPoint = Convert.ToInt32(points[i]);
                }
            }
            return maxPoint;
        }

        public static void HackerEarthImplementation()
        {
            string[] points = Console.ReadLine().Split(' ');
            int maxPoint = Convert.ToInt32(points[0]);

            for (int i = 1; i < points.Length; i++)
            {
                if (maxPoint < Convert.ToInt32(points[i]))
                {
                    maxPoint = Convert.ToInt32(points[i]);
                }
            }
            Console.WriteLine(maxPoint);
        }
    }
}
