using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            int counter = 1;
            int previous = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (previous == list[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", previous, counter);
                    counter = 1;
                }

                previous = list[i];

            }

            Console.WriteLine("{0} -> {1}", previous, counter);
        }
    }
    }
}
