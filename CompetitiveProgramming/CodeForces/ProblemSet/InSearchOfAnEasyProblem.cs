using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.CodeForces.ProblemSet
{
    /// <summary>
    /// In Progress
    /// In Search of an Easy Problem
    /// Submitssion code-
    /// time limit per test1 second
    /// memory limit per test256 megabytes
    /// inputstandard input
    /// outputstandard output
    /// </summary>
    public class InSearchOfAnEasyProblem
    {
        /// <summary>
        /// Edit below written Main2 to Main method.
        /// Also, edit any other Main function to Main2 for running code from here.
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            InSearchOfAnEasyProblemMethod();
        }


        /// <summary>
        /// According to problem statement even if one person says it's hard i.e, 1 then the problem is hard.
        /// So all we have to do is search for 1 in the opinions.
        /// So now it's a search problem where we search for 1. If search is fast then quickly we know the result.
        /// Let's look at our options for faster search or search algorithms:
        /// 1. Naive String Matching Algorithm.
        /// 2. Rabin Karp Algorithm.
        /// Following is the implementation of Naive String Matching Algorithm.
        /// </summary>
        static void InSearchOfAnEasyProblemMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string nOpinion = Console.ReadLine().Replace(" ","");
            char[] opinions = nOpinion.ToCharArray();
            bool easy = true;

            for (int i = 0; i < n; i++)
            {
                if (opinions[i] == '1')
                {
                    easy = false;
                    Console.WriteLine("HARD");
                    break;
                }
            }
            if(easy == true)
            {
                Console.WriteLine("EASY");
            }            
        }
    }
}
