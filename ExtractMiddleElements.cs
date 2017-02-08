using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> list = new List<int>();

            if (arr.Length == 1)
            {
                list.Add(arr[0]);
            }
            else
            {
                if (arr.Length % 2 == 0)
                {
                    list.Add(arr[arr.Length / 2 - 1]);
                    list.Add(arr[arr.Length / 2]);
                }
                else
                {
                    list.Add(arr[arr.Length / 2 - 1]);
                    list.Add(arr[arr.Length / 2]);
                    list.Add(arr[arr.Length / 2 + 1]);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
