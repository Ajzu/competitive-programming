﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.HackerEarth.BasicProgramming
{
    public class SplitHouses
    {
        public static void HackerEarthImplementation()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string grids = Console.ReadLine();
            char[] houses = grids.ToCharArray();
            bool possible = false;

            for(int i=0; i<n; i++)
            {
                if(houses[i] =='.')
                {
                    houses[i] = 'B';
                    possible = true;
                }
            }

            string result = possible ? "YES" : "NO";            
            Console.WriteLine(result);
            if(possible)
            {
                Console.WriteLine(String.Join("", houses));
            }            
        }
    }
}
