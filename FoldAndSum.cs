using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            int lengthTotal = numbers.Length;
            int k = lengthTotal / 4;

            int[] firstRow = new int[2 * k];
            int[] secondRow = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = numbers[k - i - 1];
            }

            for (int i = 0; i < k; i++)
            {
                firstRow[k + i] = numbers[4 * k - 1 - i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                secondRow[i] = numbers[k + i];
            }

            int[] result = new int[secondRow.Length];
            for (int i = 0; i < secondRow.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
