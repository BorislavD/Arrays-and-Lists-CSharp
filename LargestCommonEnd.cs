using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            int firstLength = first.Length;
            int secondLength = second.Length;
            int shorter = Math.Min(firstLength, secondLength);

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < shorter; i++)
            {
                if (first[i] == second[i])
                {
                    countLeft++;
                }
            }

            for (int i = 0; i < shorter; i++)
            {
                if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
                {
                    countRight++;
                }
            }

            int largest = Math.Max(countLeft, countRight);
            Console.WriteLine(largest);
        }
    }
}


