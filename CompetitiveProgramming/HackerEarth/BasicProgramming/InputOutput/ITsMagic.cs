using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class ITsMagic
    {
        public static int BasicImplementation(int N, string inputs)
        {
            string[] A = inputs.Split(' ');
            int smallestIndex = -1;
            long smallestItem = 1000000000;

            long sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += Convert.ToInt64(A[i]);
            }

            for (int i = 0; i < N; i++)
            {
                long temp = Convert.ToInt64(A[i]);

                if (((sum - temp) % 7 == 0) && (temp < smallestItem))
                {
                    smallestItem = temp;
                    smallestIndex = i;
                }
            }

            return smallestIndex;            
        }

        public static void HackerEarthImplementation()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] A = Console.ReadLine().Split(' ');

            int smallestIndex = -1;
            long smallestItem = 1000000000;
            long sum = 0;

            for(int i=0; i<N; i++)
            {
                sum += Convert.ToInt32(A[i]);
            }

            for (int i = 0; i < N; i++)
            {
                int temp = Convert.ToInt32(A[i]);

                if (((sum -temp) % 7 == 0) && (temp < smallestItem))
                {
                    smallestItem = temp;
                    smallestIndex = i;
                }
            }

            Console.WriteLine(smallestIndex);
        }

        public static void Discussion()
        {
            string totalnumbers = Console.ReadLine();
            string[] numbers = Console.ReadLine().ToString().Split(' ');

            int sum = 0;
            long minNum = 1000000000000, minIndex = -1;

            for (int j = 0; j < numbers.Length; j++)
            {
                sum += int.Parse(numbers[j]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((sum - int.Parse(numbers[i])) % 7 == 0 && int.Parse(numbers[i]) < minNum)
                {
                    minNum = int.Parse(numbers[i]);
                    minIndex = i;
                }
            }

            Console.WriteLine(minIndex);
        }
    }
}
