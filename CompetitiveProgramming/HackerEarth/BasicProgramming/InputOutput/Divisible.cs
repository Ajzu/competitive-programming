using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class Divisible
    {
        public static string BasicImplementation(int N, string element)
        {
            string[] elements = element.Split(' ');
            StringBuilder sbNumber = new StringBuilder();

            //string generatedNumber = "";
            int mid = N / 2;
            long trick = 0;
            bool add = true;

            for(int i=0; i<N; i++)
            {
                if(i<mid)
                {
                    //generatedNumber = generatedNumber + elements[i].Substring(0, 1);
                    // elementsNumber[i] = elements[i].Substring(0, 1);
                    sbNumber.Append( elements[i].Substring(0, 1) );

                    if(add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring(0, 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring(0, 1));
                        add = true;
                    }
                }
                else
                {
                    //generatedNumber = generatedNumber + elements[i].Substring((elements[i].Length-1), 1);
                    sbNumber.Append(elements[i].Substring((elements[i].Length - 1), 1));

                    if (add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = true;
                    }
                }                
            }

            //int digits = Convert.ToInt32(generatedNumber);
            long digits = Convert.ToInt64(sbNumber.ToString());

            if ((digits % 11) == 0)
            {
                return "OUI";
            }
            else
            {
                return "NON";
            }
        }

        public static string TrickImplementation(int N, string element)
        {
            string[] elements = element.Split(' ');
            int mid = N / 2;
            long trick = 0;
            bool add = true;

            for (int i = 0; i < N; i++)
            {
                if (i < mid)
                {
                    if (add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring(0, 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring(0, 1));
                        add = true;
                    }
                }
                else
                {
                    if (add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = true;
                    }
                }
            }

            if ((trick % 11) == 0 || trick == 0)
            {
                return "OUI";
            }
            else
            {
                return "NON";
            }
        }

        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] elements = Console.ReadLine().Split(' ');

            string generatedNumber = "";
            int mid = N / 2;

            for (int i = 0; i < N; i++)
            {
                if (i < mid)
                {
                    generatedNumber = generatedNumber + elements[i].Substring(0, 1);
                }
                else
                {
                    generatedNumber = generatedNumber + elements[i].Substring((elements[i].Length - 1), 1);
                }
            }

            int digits = Convert.ToInt32(generatedNumber);

            if ((digits % 11) == 0)
            {
                Console.WriteLine("OUI");
            }
            else
            {
                Console.WriteLine("NON");
            }
        }

        public static void HackerEarthImplementation2()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] elements = Console.ReadLine().Split(' ');

            StringBuilder sbNumber = new StringBuilder();

            int mid = N / 2;

            for (int i = 0; i < N; i++)
            {
                if (i < mid)
                {
                    sbNumber.Append(elements[i].Substring(0, 1));
                }
                else
                {
                    sbNumber.Append(elements[i].Substring((elements[i].Length - 1), 1));
                }
            }

            long digits = Convert.ToInt64(sbNumber.ToString());

            if ((digits % 11) == 0)
            {
                Console.WriteLine("OUI");
            }
            else
            {
                Console.WriteLine("NON");
            }
        }

        public static void HackerEarthImplementation3()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] elements = Console.ReadLine().Split(' ');
            int mid = N / 2;
            long trick = 0;
            bool add = true;

            for (int i = 0; i < N; i++)
            {
                if (i < mid)
                {
                    if (add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring(0, 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring(0, 1));
                        add = true;
                    }
                }
                else
                {
                    if (add)
                    {
                        trick += Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = false;
                    }
                    else
                    {
                        trick -= Convert.ToInt32(elements[i].Substring((elements[i].Length - 1), 1));
                        add = true;
                    }
                }
            }

            if ((trick % 11) == 0 || trick == 0)
            {
                Console.WriteLine("OUI");
            }
            else
            {
                Console.WriteLine("NON");
            }
        }
    }
}
