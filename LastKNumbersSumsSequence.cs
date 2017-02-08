using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                long sum = 0;
                int start = Math.Max(0, i - k);
                for (int j = start; j <= i - 1; j++)
                {
                    sum += arr[j];
                }

                arr[i] = sum;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }
    }
}
