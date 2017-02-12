using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string[] left = new string[arr.Length / 2];
            string[] right = new string[arr.Length / 2];
            bool areEqual = false;
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[arr.Length - 1 - i];
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (left[i] != right[i])
                {
                    Console.WriteLine("No");
                    break;
                }
                else
                {
                    areEqual = true;
                }
            }

            if (areEqual == true)
            {
                Console.WriteLine("Yes");
            }
            

        }
    }
}
