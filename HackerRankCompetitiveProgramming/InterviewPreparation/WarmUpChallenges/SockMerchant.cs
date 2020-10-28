using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankCompetitiveProgramming.InterviewPreparation.WarmUpChallenges
{
    public class SockMerchant
    {
        
        public SockMerchant()
        {
            CodeWarmUp();
        }

        // Complete the sockMerchant function below.
        static int SockMerchantLogic(int n, int[] ar)
        {
            Dictionary<int, int> sockPairs = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentItem = ar[i];

                if (currentItem > 0)
                {
                    if (i != n)
                    {
                        for (int j =n+1; j < n; j++)
                        {
                            if (currentItem == ar[j])
                            {

                            }
                        }
                    }
                    else
                    {
                        sockPairs.Add(currentItem, 1);
                    }
                }
            }
            return 0;
        }

        static void CodeWarmUp()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 9;

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] ar = new int[9] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = SockMerchantLogic(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
