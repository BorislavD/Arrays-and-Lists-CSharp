using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string[] rezult = new string[arr.Length];
            rezult[0] = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                rezult[i + 1] = arr[i];
            }

            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}
