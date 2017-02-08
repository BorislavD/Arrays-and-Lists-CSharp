using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotating
{
    class Rotating
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 4, 5, 7, 8 };
            int[] arr2 = new int[] { 2, 3, 6 };
            int lengthArr = arr1.Length;
            for (int i = 0; i < lengthArr; i++)
            {
                int remainder = arr2[i % arr2.Length];

                Console.WriteLine(remainder);
            }
        }
    }
}
