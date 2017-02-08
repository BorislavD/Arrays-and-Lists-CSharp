using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sumArray = new int[arrNumbers.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = arrNumbers[arrNumbers.Length - 1];
                for (int j = arrNumbers.Length - 1; j >= 1; j--)
                {
                    arrNumbers[j] = arrNumbers[j - 1];
                    sumArray[j] += arrNumbers[j];
                }

                arrNumbers[0] = lastElement;
                sumArray[0] += lastElement;
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
