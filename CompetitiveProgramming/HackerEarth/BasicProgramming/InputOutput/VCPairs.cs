using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class VCPairs
    {
        public static int[] BasicImplementation(int testCases, int[] lengths, string[] inputs)
        {
            int[] result = new int[testCases];

            for (int j = 0; j < testCases; j++)
            {
                int occurences = 0;

                for (int i = 1; i < (inputs[j].Length); i++)
                {   
                    char currentitem = inputs[j][i];
                    char previousItem = inputs[j][i];

                    if (currentitem == 'a' || currentitem == 'e' || currentitem == 'i' || currentitem == 'o' || currentitem == 'u')
                    {
                        if (previousItem != 'a' || previousItem != 'e' || previousItem != 'i' || previousItem != 'o' || previousItem != 'u')
                        {
                            occurences++;
                        }
                    }
                }
                result[j] = occurences;
            }

            return result;
        }

        public static void HackerEarthImplementation()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < testCases; j++)
            {
                int occurences = 0;
                int length = Convert.ToInt32(Console.ReadLine());
                string SS = Console.ReadLine();

                for (int i = 1; i < (SS.Length); i++)
                {
                    char currentitem = SS[i];
                    char previousItem = SS[i -1];

                    if (currentitem == 'a' || currentitem == 'e' || currentitem == 'i' || currentitem == 'o' || currentitem == 'u')
                    {
                        if (previousItem != 'a' || previousItem != 'e' || previousItem != 'i' || previousItem != 'o' || previousItem != 'u')
                        {
                            occurences++;
                        }
                    }
                }
                Console.WriteLine(occurences);
            }
        }
    }
}
