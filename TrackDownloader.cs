using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            string[] blaklistedWords = Console.ReadLine().Split();
            List<string> result = new List<string>();

            string input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                bool doesContain = false;
                for (int i = 0; i < blaklistedWords.Length; i++)
                {
                    if (input.Contains(blaklistedWords[i]))
                    {
                        doesContain = false;
                        break;
                    }
                    else
                    {
                        doesContain = true;
                    }
                }

                if (doesContain)
                {
                    result.Add(input);
                }

                input = Console.ReadLine();

            }

            result.Sort();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
