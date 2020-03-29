using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.DataStructure
{
    public class ArrayDS
    {
        public ArrayDS()
        {

            //InProgress
            //BinaryQueries2();

            //Solved
        }

        public void BinaryQueries()
        {
            //string[] NQ = Console.ReadLine().Split().ToArray();
            string[] NQ = "5 2".Split().ToArray();
            int Queries = Convert.ToInt32(NQ[1]);
            //string[] N = Console.ReadLine().Split().ToArray();
            string[] N = "1 0 1 1 0".Split().ToArray();
            int binaryNumber = 0;

            for (int i = 0; i < Queries; i++)
            {
                string[] query = Console.ReadLine().Split().ToArray();

                if (query.Length == 2)
                {
                    int index = (Convert.ToInt32(query[1]) -1);
                    //N[index--] = query[0];
                    N[index] = query[0];//"3";
                }
                else
                {
                    int left = (Convert.ToInt32(query[1]) - 1);
                    int right = Convert.ToInt32(query[2]);
                    //string temporaryBinary = string.Join("", N, 0, 4);
                    string temporaryBinary = string.Join("", N, left, right);
                    string lastcharacter = N[left + (right-1)];
                    binaryNumber = Convert.ToInt32(temporaryBinary, 2);

                }
            }

            if (binaryNumber % 2 == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }

        public void BinaryQueries2()
        {
            //string[] NQ = Console.ReadLine().Split().ToArray();
            string[] NQ = "5 2".Split().ToArray();
            int Queries = Convert.ToInt32(NQ[1]);
            //string[] N = Console.ReadLine().Split().ToArray();
            string samplestring = "1 0 1 1 0".Replace(" ","");
            string flipsample = samplestring;

            for (int i = 0; i < Queries; i++)
            {
                //get queries
                string[] query = Console.ReadLine().Split().ToArray();
                
                if (query.Length == 2)
                {
                    //flip
                    int index = (Convert.ToInt32(query[1]) - 1);
                    flipsample = flipsample.Remove(index, 1);
                    flipsample = flipsample.Insert(index, query[0]);
                }
                else
                {
                    int left = (Convert.ToInt32(query[1]) - 1);
                    int right = Convert.ToInt32(query[2]);
                    string lastcharacter = flipsample[left + (right - 1)].ToString();

                    if(lastcharacter=="1")
                    {
                        Console.WriteLine("ODD");
                    }
                    else
                    {
                        Console.WriteLine("EVEN");
                    }
                    flipsample = samplestring;
                }
            }
        }

    }
}
