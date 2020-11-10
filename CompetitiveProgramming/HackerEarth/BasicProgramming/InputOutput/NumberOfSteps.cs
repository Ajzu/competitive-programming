using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class NumberOfSteps
    {
        public static int BasicImplementation(int n, int[]A, int []B)
        {
            int smallestNum = A[0];
            int numberOfSteps = 0;

            for(int i=1; i<n; i++)
            {
                if(smallestNum > A[i])
                {
                    smallestNum = A[i];
                }
            }

            for(int i=0; i<n; i++)
            {
                int steps = 0;

                if (A[i] >= smallestNum && A[i] > B[i])
                {
                    while(A[i] > smallestNum)
                    {
                        A[i] = A[i] - B[i];
                        steps++;

                        if (A[i] == smallestNum)
                        {
                            break;
                        }
                        else if(A[i] <smallestNum)
                        {
                            steps--;
                            break;
                        }                        
                    }
                }
                else
                {
                    return -1;
                }

                numberOfSteps += steps;
            }

            if (numberOfSteps == 0)
            {
                return -1;
            }
            else
            {
                return numberOfSteps;
            }            
        }

        public static void HackerEarthImplementation()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A = Console.ReadLine().Split(' ');
            string[] B = Console.ReadLine().Split(' ');

            int smallestNum = Convert.ToInt32(A[0]);
            int numberOfSteps = 0;

            for (int i = 1; i < n; i++)
            {
                int currentNum = Convert.ToInt32(A[i]);
                if (smallestNum > currentNum)
                {
                    smallestNum = currentNum;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int steps = 0;
                int a = Convert.ToInt32(A[i]);
                int b = Convert.ToInt32(B[i]);

                if (a >= smallestNum && a > b)
                {
                    while (a > smallestNum)
                    {
                        a = a - b;
                        steps++;

                        if (a == smallestNum)
                        {
                            break;
                        }
                        else if (a < smallestNum)
                        {
                            steps--;
                            break;
                        }
                    }
                }
                else
                {
                    //Console.WriteLine("-1");
                    steps = -1;
                    break;
                }

                if (steps == -1)
                {
                    numberOfSteps = 0;
                    break;
                }
                else
                {
                    numberOfSteps += steps;
                }
            }

            if (numberOfSteps == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(numberOfSteps);
            }
        }
    }
}
