using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> result = new List<string>();
            result.Add(list[0]);

            for (int i = list.Count - 2; i >= 1; i--)
            {
                result.Add(list[i]);
            }

            result.Add(list[list.Count - 1]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
