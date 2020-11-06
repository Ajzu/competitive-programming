using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class TwoStrings
    {
        public static string BasicImplementation(string S1, string S2)
        {
            if(S1 == S2)
            {
                return "YES";
            }
            else
            {
                if (S1.Length != S2.Length)
                {
                    return "NO";
                }
                else
                {
                    for (int i = 0; i < S1.Length; i++)
                    {
                        for (int j = 0; j < S2.Length; j++)
                        {
                            if (S1[i] == S2[j])
                            {
                                S1 = S1.Remove(i, 1);
                                S2 = S2.Remove(j, 1);
                                i--;
                                j--;
                                break;
                            }
                        }
                    }

                    if (S1.Length > 0 || S2.Length > 0)
                    {
                        return "NO";
                    }
                    else
                    {
                        return "YES";
                    }
                }                
            }       
        }

        public static string BasicImplementationDictionary(string S1, string S2)
        {
            bool result = true;

            if (S1 == S2)
            {
                result = true;
            }
            else
            {
                if (S1.Length != S2.Length)
                {
                    result = false;
                }
                else
                {
                    for (int i = 0; i < S1.Length; i++)
                    {
                        char a = S1[i];
                        int countS1 = 0;
                        int countS2 = 0;

                        for (int j = 0; j < S2.Length; j++)
                        {
                            if(a == S1[j])
                            {
                                countS1++;
                                S1 = S1.Remove(i, 1);
                                i--;
                            }

                            if(a == S2[j])
                            {
                                countS2++;
                                S2 = S2.Remove(j, 1);
                                j--;
                            }
                        }

                        if(countS1 != countS2)
                        {
                            result = false;
                            break;
                        }
                    }

                    if (S1.Length > 0 || S2.Length > 0)
                    {
                        result = false;
                    }                    
                }
            }

            string output = result ? "YES" : "NO";
            return output;
        }

        public static void HackerEarthImplementation()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for(int x=0; x<T; x++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string S1 = inputs[0];
                string S2 = inputs[1];

                if (S1 == S2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    if (S1.Length != S2.Length)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        for (int i = 0; i < S1.Length; i++)
                        {
                            for (int j = 0; j < S2.Length; j++)
                            {
                                if (S1[i] == S2[j])
                                {
                                    S1 = S1.Remove(i, 1);
                                    S2 = S2.Remove(j, 1);
                                    i--;
                                    j--;
                                    break;
                                }
                            }
                        }

                        if (S1.Length > 0 || S2.Length > 0)
                        {
                            Console.WriteLine("NO");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                }                
            }
        }
    }
}
