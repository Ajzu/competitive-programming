using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.CodeForces.ProblemSet
{
    public class Hulk
    {
        /// <summary>
        /// Edit below written Main2 to Main method.
        /// Also, edit any other Main function to Main2 for running code from here.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //HulkMethod1();
            HulkMethod2();
        }

        /// <summary>
        /// Hulk can be solved in multiple ways:
        /// 1st method is that we can use for loop and check the odd even for each iteration and add the value in the string builder feelings variable and replace it with that.
        /// 2nd method is to find out the n is odd or even, because if odd then output will end with "I hate it" else even then with "I love it".
        /// 
        /// </summary>
        private static void HulkMethod1()
        {
            int layers = Convert.ToInt32(Console.ReadLine());
            StringBuilder feelings = new StringBuilder();
            int count = 0;

            //constraint says n(1<= n <= 100)
            if(layers >0)
            {
                for(int i=1; i < (layers+1); i++)
                {

                    if (i == 1)
                    {
                        feelings.Append("I hate it");
                    }
                    else
                    {
                        feelings = feelings.Replace("it", "that ", (feelings.Length - 2), 2);
                        if (i % 2 == 0)
                        {
                            feelings.Append("I love it");
                        }
                        else
                        {
                            feelings.Append("I hate it");
                        }
                    }
                }
            }
            Console.WriteLine(feelings.ToString());
            //Console.ReadLine();
        }

        private static void HulkMethod2()
        {
            int layers = Convert.ToInt32(Console.ReadLine());
            StringBuilder feelings = new StringBuilder();

            if (layers > 1)
            {
                for (int i = 1; i < layers; i++)
                {
                    if (i % 2 == 0)
                    {
                        feelings.Append("I love that ");
                    }
                    else
                    {
                        feelings.Append("I hate that ");
                    }
                }

                if(layers %2 ==0)
                {
                    feelings.Append("I love it");
                }
                else
                {
                    feelings.Append("I hate it");
                }
            }
            else
            {
                feelings.Append("I hate it");
            }
            Console.WriteLine(feelings.ToString());
            //Console.ReadLine();
        }
    }
}
