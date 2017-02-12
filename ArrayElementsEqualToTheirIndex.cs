using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == i)
                {
                    list.Add(arr[i]);
                }
            }

            Console.WriteLine(string.Join(" ", list));

        }
    }
}
