using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string nums = Console.ReadLine();
            while (!nums.Equals("end"))
            {
                int number = int.Parse(nums);
                int firstDigit = 0;
                while (number > 0)
                {
                    firstDigit = number % 10;
                    number = number / 10;
                }

                input.Insert(firstDigit, int.Parse(nums));
                nums = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
