using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            if (list.Count == n)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", list));
                return;
            }
            else
            {
                while (list.Count > n)
                {
                    list.RemoveAt(0);
                    list.RemoveAt(list.Count - 1);
                    counter++;
                }
            }

            Console.WriteLine("{0} rounds", counter);
            Console.WriteLine("remaining: {0}", string.Join(" ", list));

        }
    }
}
