using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class FriendsRelationship
    {
        public static void BasicImplementation()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<T; i++)
            {
                int A = Convert.ToInt32(Console.ReadLine());

                //for (int j=0; j<A; j++)
                for (int j = A; j > 0; j--)
                {
                    int hashCount = j;
                    int starCount = A- j;
                    StringBuilder sbMiddle = new StringBuilder();
                    StringBuilder sbLeftRight = new StringBuilder();

                    for (int k=0; k<hashCount; k++)
                    {
                        if(k>0)
                        {
                            sbMiddle.Append("##");
                        }                        
                    }                    

                    for(int k=0; k<starCount; k++)
                    {
                        sbLeftRight.Append("*");
                    }

                    Console.WriteLine(sbLeftRight.ToString() + sbMiddle.ToString() + sbLeftRight.ToString());
                }
                Console.WriteLine();
            }
        }

        public static void BasicImplementation2()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int A = Convert.ToInt32(Console.ReadLine());

                for (int j = A; j > 0; j--)
                {
                    int hashCount = j;
                    int starCount = A - j;
                    StringBuilder sbMiddle = new StringBuilder();
                    StringBuilder sbLeftRight = new StringBuilder();

                    for (int k = 0; k < hashCount; k++)
                    {
                        if (k > 0)
                        {
                            sbMiddle.Append("##");
                        }
                        else
                        {
                            sbMiddle.Replace('#', '*', 0, 1);
                        }
                    }

                    for (int k = 0; k < starCount; k++)
                    {
                        sbLeftRight.Append("*");
                    }

                    if(j == 0)
                    {
                        sbLeftRight.Replace('#', '*', 0, 1);
                    }

                    Console.WriteLine(sbLeftRight.ToString() + sbMiddle.ToString() + sbLeftRight.ToString());
                }
                Console.WriteLine();
            }
        }

        public static void HackerEarthImplementation()
        {
            int T = Convert.ToInt32(Console.ReadLine());            

            for (int i = 0; i < T; i++)
            {
                int A = Convert.ToInt32(Console.ReadLine());
                string[] result = new string[A];
                StringBuilder pattern = new StringBuilder();

                for(int j=0; j<A; j++)
                {
                    pattern.Append("**");
                }

                result[0] = pattern.ToString();

                for (int j = 1; j < A; j++)
                {
                    pattern.Replace('*', '#', A - j, 1);
                    pattern.Replace('*', '#', (A - 1) + j, 1);
                    result[j] = pattern.ToString();
                }

                for(int j=(A-1); j>=0; j--)
                {
                    Console.WriteLine(result[j]);
                }

                Console.WriteLine();
            }
        }

        public static void BasicImplementationInverse()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int A = Convert.ToInt32(Console.ReadLine());
                string[] result = new string[A];
                StringBuilder pattern = new StringBuilder();

                for (int j = 0; j < A; j++)
                {
                    pattern.Append("**");
                }

                //Console.WriteLine(pattern.ToString());

                result[0] = pattern.ToString();

                for (int j = 1; j < A; j++)
                {
                    pattern.Replace('*', '#', A - j, 1);
                    pattern.Replace('*', '#', (A - 1) + j, 1);

                    result[j] = pattern.ToString();
                    //Console.WriteLine(pattern.ToString());
                }

                for (int j = (A - 1); j >= 0; j--)
                {
                    Console.WriteLine(result[j]);
                }

                for (int j = A; j > 1; j--)
                {
                    pattern.Replace('*', '#', A - j, 1);
                    pattern.Replace('*', '#', (A - 1) + j, 1);

                    Console.WriteLine(pattern.ToString());
                }

                Console.WriteLine();
            }
        }
    }
}
