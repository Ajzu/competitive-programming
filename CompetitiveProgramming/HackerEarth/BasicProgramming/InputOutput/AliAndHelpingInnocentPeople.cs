using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class AliAndHelpingInnocentPeople
    {
        public static string BasicImplementation(string inputs)
        {
            int length = 9;
            string format = "DDXDDD-DD";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y' };
            bool foundVowel = false;

            foreach(char ch in vowels)
            {
                if(ch == inputs[2])
                {
                    foundVowel = true;
                    break;
                }
            }

            if(foundVowel == true)
            {
                return "invalid";
            }
            else
            {
                int sum12 = Convert.ToInt32(inputs[0]) + Convert.ToInt32(inputs[1]);

                int sum45 = Convert.ToInt32(inputs[3]) + Convert.ToInt32(inputs[4]);
                int sum56 = Convert.ToInt32(inputs[4]) + Convert.ToInt32(inputs[5]);

                int sum89 = Convert.ToInt32(inputs[7]) + Convert.ToInt32(inputs[8]);

                if( (sum12 % 2==0) && (sum45 % 2 == 0) && (sum56 % 2 == 0) && (sum89 % 2 == 0) )
                {
                    return "valid";
                }
                else
                {
                    return "invalid";
                }
            }
        }

        public static void HackerEarthImplementation()
        {
            string inputs = Console.ReadLine();

            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y' };
            bool foundVowel = false;

            foreach (char ch in vowels)
            {
                if (ch == inputs[2])
                {
                    foundVowel = true;
                    break;
                }
            }

            if (foundVowel == true)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                int sum12 = Convert.ToInt32(inputs[0]) + Convert.ToInt32(inputs[1]);
                int sum45 = Convert.ToInt32(inputs[3]) + Convert.ToInt32(inputs[4]);
                int sum56 = Convert.ToInt32(inputs[4]) + Convert.ToInt32(inputs[5]);
                int sum89 = Convert.ToInt32(inputs[7]) + Convert.ToInt32(inputs[8]);

                if ((sum12 % 2 == 0) && (sum45 % 2 == 0) && (sum56 % 2 == 0) && (sum89 % 2 == 0))
                {
                     Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
