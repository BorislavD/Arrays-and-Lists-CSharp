using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int counter = 1;
            string equalElement = string.Empty;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == arr[i-1])
                {
                    counter++;
                   
                    if (counter == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", arr[i]);
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

           
        }

    }
}

