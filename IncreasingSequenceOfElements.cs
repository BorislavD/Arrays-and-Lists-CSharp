using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIncreasing = false;
            List<int> increasingList = new List<int>();
            List<int> decreasingList = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    increasingList.Add(arr[i + 1]);
                }
                else
                {
                    decreasingList.Add(arr[i + 1]);

                }
            }

            if (decreasingList.Count > 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
