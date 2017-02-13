using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split('|');
            List<string> result = new List<string>();
            for (int i = 0; i < tokens.Length; i++)
            {
                string[] help = tokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = help.Length - 1; j >= 0; j--)
                {
                    result.Add(help[j]);
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
