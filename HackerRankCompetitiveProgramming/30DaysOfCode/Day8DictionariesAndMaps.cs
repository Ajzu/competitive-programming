using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankCompetitiveProgramming._30DaysOfCode
{
    public class Day8DictionariesAndMaps
    {
        public Day8DictionariesAndMaps()
        {
            DictionariesAndMapsLogic();
        }

        public void DictionariesAndMapsLogic()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] contactInformation = Console.ReadLine().Split(" ");
                phoneBook.Add(contactInformation[0], contactInformation[1]);
            }

            bool breakFlag = false;

            while (!breakFlag)
            {
                string line = Console.ReadLine();

                if (line == "")
                {
                    breakFlag = true;
                }
                else
                {
                    Console.WriteLine(SearchPhoneBook(line, phoneBook));
                    line = "";
                }
            }

            Console.WriteLine("Out of loop");

            //string line = null;

            //while((line = Console.ReadLine())!="")
            //{
            //    Console.WriteLine(SearchPhoneBook(line, phoneBook));
            //}
        }

        public string SearchPhoneBook(string name, Dictionary<string, string> phoneBook)
        {
            if(name != "")
            {
                foreach(KeyValuePair<string,string> item in phoneBook)
                {
                    if(item.Key== name)
                    {
                        return item.Key + "=" + item.Value;
                    }
                }
            }
            return "Not Found";
        }
    }
}
