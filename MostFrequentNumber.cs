using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCount = 0;
                int tempElement = numbers[i];
                for (int j = i; j < numbers.Length; j++)
                {
                    if (tempElement == numbers[j])
                    {
                        tempCount++;
                    }

                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        element = tempElement;
                    }
                }
            }

            Console.WriteLine(element);
        }
    }
}
