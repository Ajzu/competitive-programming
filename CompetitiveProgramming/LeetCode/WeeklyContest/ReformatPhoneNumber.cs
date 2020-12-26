using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.WeeklyContest
{
    public class ReformatPhoneNumber
    {
        public static string ReformatNumber(string number)
        {
            int length = number.Length;

            StringBuilder cleanNumber = new StringBuilder();
            StringBuilder output = new StringBuilder();

            number = number.Replace("-", "");
            number = number.Replace(" ", "");
            
            cleanNumber.Append(number);

            if(cleanNumber.Length <=0)
            {
                return cleanNumber.ToString();
            }
            else
            {
                int remainder = cleanNumber.Length % 3;
                int repetition = cleanNumber.Length / 3;

                if(remainder == 2)
                {
                    //length is 8;
                    //"123-456-78"
                    for (int i = 0; i < repetition; i++)
                    {
                        string sample = cleanNumber.ToString().Substring(i * 3, 3)+"-";
                        output.Append(sample);                        
                    }

                    output.Append(cleanNumber.ToString().Substring(cleanNumber.Length - 2, 2));
                }
                else
                {
                    for (int i = 0; i < (repetition-1); i++)
                    {
                        string sample = cleanNumber.ToString().Substring(i * 3, 3) + "-";
                        output.Append(sample);
                    }

                    if(cleanNumber.Length % 6 == 0)
                    {
                        output.Append(cleanNumber.ToString().Substring(cleanNumber.Length - 3, 3));
                    }
                    else
                    {
                        output.Append(cleanNumber.ToString().Substring(cleanNumber.Length - 4, 2));
                        output.Append("-" + cleanNumber.ToString().Substring(cleanNumber.Length - 2, 2));
                    }
                }
            }
            return output.ToString();
        }
    }
}
