using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] ch = input.ToCharArray();
            List<char> list = new List<char>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                int result = 0;
                if (numbers[i] %2 != 0)
                {
                    result = (numbers[i] + (int)ch[i]);
                    char final = (char)result;
                    list.Add(final);
                }
                else
                {
                    result = Math.Abs((int)ch[i] - numbers[i]);
                    char final = (char)result;
                    list.Add(final);
                }
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}
