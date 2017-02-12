using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1)
                {
                    if((char.Parse(arr[i]) >= 65) && (char.Parse(arr[i]) <= 90))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
