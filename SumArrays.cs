using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lengthFirst = first.Length;
            int lengthSecond = second.Length;

            int shorter = Math.Min(lengthFirst, lengthSecond);
            int longer = Math.Max(lengthFirst, lengthSecond);

            int[] result = new int[longer];

            if (shorter == longer)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = first[i] + second[i];
                }
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = first[i % lengthFirst] + second[i % lengthSecond];
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

