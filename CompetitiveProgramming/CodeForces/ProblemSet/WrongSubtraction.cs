using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.CodeForces.ProblemSet
{
    /// <summary>
    /// Solved
    /// Wrong Subtraction is the title in code forces
    /// Submitssion code- 977A - Wrong Subtraction
    /// Difficulty - 500
    /// time limit per test1 second
    /// memory limit per test256 megabytes
    /// inputstandard input
    /// outputstandard output
    /// </summary>
    public class WrongSubtraction
    {
        /// <summary>
        /// Edit below written Main2 to Main method.
        /// Also, edit any other Main function to Main2 for running code from here.
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            WrongSubtractionMethod();
        }

        static void WrongSubtractionMethod()
        {
            string[] Inputs = Console.ReadLine().Split().ToArray();
            int n = Convert.ToInt32(Inputs[0]);
            int k = Convert.ToInt32(Inputs[1]);

            for (int i = 0; i < k; i++)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n--;
                }
            }
            Console.WriteLine(n);
        }
    }
}
