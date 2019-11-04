using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.Skillenza
{
    public class Skillenza
    {
        public static void SpiltMilk2()
        {
            int testcases = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < testcases; x++)
            {
                int finalVolume = 0;
                int spiltMilk = 0;

                int totalContainers = Convert.ToInt32(Console.ReadLine());
                string[] containers = Console.ReadLine().Split(' ');
                string[] initialVolume = Console.ReadLine().Split(' ');

                int currentContainerVolume = 0;
                int carryForwardVolume = 0;
                currentContainerVolume = Convert.ToInt32(containers[0]);
                carryForwardVolume = Convert.ToInt32(initialVolume[0]);

                for (int y = 1; y < totalContainers; y++)
                {
                    carryForwardVolume += Convert.ToInt32(initialVolume[y]);
                    currentContainerVolume = Convert.ToInt32(containers[y]);

                    if (carryForwardVolume > currentContainerVolume)
                    {
                        spiltMilk += carryForwardVolume - currentContainerVolume;
                        carryForwardVolume = currentContainerVolume;
                    }
                }
                finalVolume = carryForwardVolume;

                Console.WriteLine("{0} {1}", finalVolume, spiltMilk);
            }
        }

        public static void SpiltMilk()
        {
            int testcases = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < testcases; x++)
            {
                int spiltMilk = 0;

                int totalContainers = Convert.ToInt32(Console.ReadLine());
                string[] containers = Console.ReadLine().Split(' ');
                string[] initialVolume = Console.ReadLine().Split(' ');

                int currentContainerVolume = Convert.ToInt32(containers[0]);
                int carryForwardVolume = Convert.ToInt32(initialVolume[0]);
                bool zeroVolume = true;

                foreach(string volume in initialVolume)
                {
                    if(volume != "0")
                    {
                        zeroVolume = false;
                        break;
                    }
                }

                if(zeroVolume == false)
                {
                    for (int y = 1; y < totalContainers; y++)
                    {
                        carryForwardVolume += Convert.ToInt32(initialVolume[y]);
                        currentContainerVolume = Convert.ToInt32(containers[y]);

                        if (carryForwardVolume > currentContainerVolume)
                        {
                            spiltMilk += carryForwardVolume - currentContainerVolume;
                            carryForwardVolume = currentContainerVolume;
                        }
                    }
                }              
                Console.WriteLine("{0} {1}", carryForwardVolume, spiltMilk);
            }
            Console.ReadLine();
        }

        public static void SpiltMilk3()
        {
            int testcases = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < testcases; x++)
            {
                int spiltMilk = 0;

                int totalContainers = Convert.ToInt32(Console.ReadLine());
                string[] containers = Console.ReadLine().Split(' ');
                string[] initialVolume = Console.ReadLine().Split(' ');

                int currentContainerVolume = Convert.ToInt32(containers[0]);
                int carryForwardVolume = Convert.ToInt32(initialVolume[0]);

                for (int y = 1; y < totalContainers; y++)
                {
                    carryForwardVolume += Convert.ToInt32(initialVolume[y]);
                    currentContainerVolume = Convert.ToInt32(containers[y]);

                    if (carryForwardVolume > currentContainerVolume)
                    {
                        spiltMilk += carryForwardVolume - currentContainerVolume;
                        carryForwardVolume = currentContainerVolume;
                    }
                }
                Console.WriteLine("{0} {1}", carryForwardVolume, spiltMilk);
            }
            Console.ReadLine();
        }
    }
}
