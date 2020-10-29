using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class CostOfBaloons
    {
        public static int BasicImplementation(int T, string cost, int numOfParticipants, string[] statusOfUsers)
        {
            int totalCost = 0;
            bool greenCost = true;
            for (int i=0; i<T; i++)
            {                
                int green = 0;
                int purple = 0;

                string[] costs = cost.Split();

                for(int j=0; j<numOfParticipants; j++)
                {
                    string[]status = statusOfUsers[j].Split();

                    if(status[0] == "1")
                    {
                        green++;
                    }
                    
                    if(status[1] =="1")
                    {
                        purple++;
                    }
                }

                if (greenCost == true)
                {
                    totalCost = (green * Convert.ToInt32(costs[0])) + (purple * Convert.ToInt32(costs[1]));
                    greenCost = false;
                }
                else
                {
                    totalCost = (purple * Convert.ToInt32(costs[0])) + (green * Convert.ToInt32(costs[1]));
                    greenCost = true;
                }
            }            

            return totalCost;
        }

        /// <summary>
        /// Working solution passed all the test cases
        /// For current implementation array has been used maybe in future a much more efficient solution will be implemented
        /// </summary>
        public static void HackerEarthImplementation()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            bool greenCost = true;
            for (int i = 0; i < T; i++)
            {

                int totalCost = 0;
                int green = 0;
                int purple = 0;

                string cost = Console.ReadLine();
                string[] costs = cost.Split();

                int numOfParticipants = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < numOfParticipants; j++)
                {
                    string statusOfUsers = Console.ReadLine();
                    string[] status = statusOfUsers.Split();

                    if (status[0] == "1")
                    {
                        green++;
                    }

                    if (status[1] == "1")
                    {
                        purple++;
                    }
                }
                if (greenCost == true)
                {
                    totalCost = (green * Convert.ToInt32(costs[0])) + (purple * Convert.ToInt32(costs[1]));
                    greenCost = false;
                }
                else
                {
                    totalCost = (purple * Convert.ToInt32(costs[0])) + (green * Convert.ToInt32(costs[1]));
                    greenCost = true;
                }

                Console.WriteLine(totalCost);
            }
        }

        public static void ReadInputs()
        {
            int T = 2; // Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<T; i++)
            {

            }

        }
    }
}
