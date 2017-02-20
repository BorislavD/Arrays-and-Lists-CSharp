using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    if(first[i] == second[j])
                    {
                        second.RemoveAt(j);
                        second.Remove()
                    }
                }
            }

            int firstSum = first.Sum();
            int secondSum = second.Sum();

            if(firstSum == secondSum)
            {
                Console.WriteLine("Yes. Sum: {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
