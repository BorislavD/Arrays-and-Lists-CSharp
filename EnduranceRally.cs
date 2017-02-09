using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries);
            double[] zones = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] checkPoitns = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                char[] ch = name.ToCharArray();
                int initialFuel = ch[0];
                double sum = initialFuel;
                int reachedZoneCounter = 0;

                for (int j = 0; j < zones.Length; j++)
                {
                    bool isEqual = false;
                    for (int k = 0; k < checkPoitns.Length; k++)
                    {
                        if (j == checkPoitns[k])
                        {
                            isEqual = true;
                        }
                    }

                    if (isEqual)
                    {
                        sum += zones[j];
                    }
                    else
                    {
                        sum -= zones[j];
                    }
                    if (sum > 0)
                    {
                        reachedZoneCounter++;
                    }
                    else
                    {
                        Console.WriteLine("{0} - reached {1}", name, reachedZoneCounter);
                        break;
                    }
                }

                if (sum > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", name, sum);
                }
            }
        }
    }
}