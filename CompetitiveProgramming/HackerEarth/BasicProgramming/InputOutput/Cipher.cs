using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Cipher
    {
        public static string BasicImplementation(string S, int key)
        {
            string encrypt = "";
            
            //int sample = Difference(150, 122);

            for (int i=0; i< S.Length; i++)
            {
                int currentItem = 0;

                if (isDigits(S[i]))
                {
                    currentItem = Convert.ToInt32(S[i].ToString());
                }
                else
                {
                    currentItem = Convert.ToInt32(S[i]);
                }                

                if(currentItem >=65 && currentItem <= 90)
                {
                    currentItem += key;

                    if (currentItem > 90)
                    {
                        int difference = Difference(currentItem, 90);
                        //int difference = currentItem - 90;
                        currentItem = 64 + difference;
                    }

                    encrypt += ((char)currentItem).ToString();
                }
                else if(currentItem >=97 && currentItem <= 122)
                {
                    currentItem += key;

                    if (currentItem > 122)
                    {
                        int difference = Difference(currentItem, 122);
                        //int difference = currentItem - 122;
                        currentItem = 96 + difference;
                    }

                    encrypt += ((char)currentItem).ToString();
                }
                else if(currentItem >=0 && currentItem <= 9)
                {
                    currentItem += key;

                    if (currentItem > 9)
                    {
                        int difference = Difference(currentItem, 9);
                        //int difference = currentItem -9;
                        currentItem = difference -1;
                    }

                    encrypt += currentItem.ToString();
                }
                else
                {
                    encrypt += S[i];
                }
            }

            return encrypt;
        }


        public static void HackerEarthImplementation()
        {
            string S = Console.ReadLine();
            int key = Convert.ToInt32(Console.ReadLine());
            string encrypt = "";

            for (int i = 0; i < S.Length; i++)
            {
                int currentItem = 0;

                if (isDigits(S[i]))
                {
                    currentItem = Convert.ToInt32(S[i].ToString());
                }
                else
                {
                    currentItem = Convert.ToInt32(S[i]);
                }

                if (currentItem >= 65 && currentItem <= 90)
                {
                    currentItem += key;

                    if (currentItem > 90)
                    {
                        int difference = Difference(currentItem, 90);
                        currentItem = 64 + difference;
                    }

                    encrypt += ((char)currentItem).ToString();
                }
                else if (currentItem >= 97 && currentItem <= 122)
                {
                    currentItem += key;

                    if (currentItem > 122)
                    {
                        int difference = Difference(currentItem, 122);
                        currentItem = 96 + difference;
                    }

                    encrypt += ((char)currentItem).ToString();
                }
                else if (currentItem >= 0 && currentItem <= 9)
                {
                    currentItem += key;

                    if (currentItem > 9)
                    {
                        int difference = Difference(currentItem, 9);
                        currentItem = difference - 1;
                    }

                    encrypt += currentItem.ToString();
                }
                else
                {
                    encrypt += S[i];
                }
            }

            Console.WriteLine(encrypt);
        }

        public static bool isDigits(char s)
        {
            if ((s ^ '0') > 9)
            {
                return false;
            }

            return true;
        }

        public static int Difference(int currentItem , int maxLimit)
        {
            int difference = currentItem % maxLimit;

            return difference;
        }
    }
}
