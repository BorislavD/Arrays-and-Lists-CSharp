using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> upper = new List<string>();
            List<string> lower = new List<string>();
            for (int i = 0; i < list.Count / 2; i++)
            {
                lower.Add(list[i]);
            }

            for (int i = list.Count / 2; i < list.Count; i++)
            {
                upper.Add(list[i]);
            }

            for (int i = 0; i < upper.Count; i++)
            {
                char[] ch = upper[i].ToCharArray();

                lower.Insert(i * 3, ch[0].ToString());
                lower.Insert(i * 3 + 2, ch[1].ToString());
            }

            Console.WriteLine(string.Join(" ", lower));
        }
    }
}
