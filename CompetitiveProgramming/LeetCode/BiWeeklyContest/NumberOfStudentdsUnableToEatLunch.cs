using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.LeetCode.BiWeeklyContest
{
    public class NumberOfStudentdsUnableToEatLunch
    {
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            bool getSandwich = true;
            int stCurrent = 0;
            int swCurrent = 0;

            while(getSandwich)
            {
                for(int i=swCurrent; i<sandwiches.Length; i++ )
                {
                    for(int j=stCurrent; j<students.Length; j++)
                    {
                        if(sandwiches[i] == students[j])
                        {
                            stCurrent = j+1;
                            swCurrent = i + 1;
                            getSandwich = true;
                            break;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
