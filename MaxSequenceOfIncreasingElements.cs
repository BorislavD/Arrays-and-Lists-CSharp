using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> resultList = new List<int>();
            List<int> finalList = new List<int>();
            int current = 1;
            int longest = 1;
            resultList.Add(numbers[0]);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    current++;
                    resultList.Add(numbers[i + 1]);
                }
                else
                {
                    current = 1;
                    resultList.Clear();
                    resultList.Add(numbers[i + 1]);
                }

                if (current > longest)
                {
                    finalList.Clear();
                    longest = current;
                    finalList.AddRange(resultList);
                }
            }

            if (longest == 1)
            {
                Console.WriteLine(numbers[0]);

            }
            else
            {
                Console.WriteLine(string.Join(" ", finalList));
            }
        }
    }
}
