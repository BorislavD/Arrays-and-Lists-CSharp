using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int longest = 1;
            int current = 1;
            int bestElement = int.Parse(arr[0]);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    current++;
                    if (current > longest)
                    {
                        longest = current;
                        bestElement = int.Parse(arr[i]);
                    }
                }
                else
                {
                    current = 1;
                }
            }

            for (int i = 0; i < longest; i++)
            {
                Console.Write("{0} ", bestElement);
            }

            Console.WriteLine();
        }
    }
}
