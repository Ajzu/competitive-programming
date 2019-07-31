using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    public class Honeywell
    {
        public void DivideArrayFirst()
        {
            int[] arrayA = new int[Convert.ToInt32(Console.ReadLine())];
            arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
             
            int Q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                int D = Convert.ToInt32(Console.ReadLine()); 

                for (int j = 0; j < arrayA.Length; j++)
                {
                    if (arrayA[j] >= D || arrayA[j] > 0)
                    {
                        arrayA[j] = arrayA[j] / D;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", arrayA));
        }

        public void DivideArray()
        {
            int[] arrayA = new int[Convert.ToInt32(Console.ReadLine())];
            arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] Q = new int [ Convert.ToInt32(Console.ReadLine())];
            Dictionary<int, int> dividedNumbers = new Dictionary<int, int>();

            for (int i = 0; i < Q.Length; i++)
            {
                Q[i] = Convert.ToInt32(Console.ReadLine());                
            }

            for (int j = 0; j < arrayA.Length; j++)
            {
                int currentNumber = arrayA[j];
                if(dividedNumbers.ContainsKey(currentNumber))
                {
                    arrayA[j] = dividedNumbers.Where(x => x.Key == arrayA[j]).FirstOrDefault().Value;
                }
                else 
                {
                    for (int k = 0; k < Q.Length; k++)
                    {
                        int D = Q[k];
                        if (D > 0)
                        {
                            if (arrayA[j] >= D || arrayA[j] > 0)
                            {
                                arrayA[j] = arrayA[j] / D;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    dividedNumbers.Add(currentNumber, arrayA[j]);
                }
            }
            Console.WriteLine(String.Join(" ", arrayA));
        }

        public void ItsAllAboutMagic()
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());
            string magicalString = "1";

            for (int i=0; i<TestCases; i++)
            {
                int M = Convert.ToInt32(Console.ReadLine());

                if(M > 2)
                {
                    for (int j=0; j<M; j++)
                    {
                        //
                    }
                }                
            }           
        }
    }
}
