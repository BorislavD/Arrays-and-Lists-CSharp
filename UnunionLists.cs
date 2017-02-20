using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = initialList.Distinct().ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> middle = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < middle.Count; j++)
                {
                    if (!result.Contains(middle[j]))
                    {
                        result.Add(middle[j]);
                    }
                    else
                    {
                        result.Remove(middle[j]);
                    }
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
