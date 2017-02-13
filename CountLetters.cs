using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] countsHolder = new int[26];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    countsHolder[text[i] - 'a']++;
                }
            }

            for (int i = 0; i < countsHolder.Length; i++)
            {
                if(countsHolder[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", (char)(i + 'a'), countsHolder[i]);
                }
                
            }
        }
    }
}
