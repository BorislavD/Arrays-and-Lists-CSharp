using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(new char[]
            { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries);
            
            List<string> lowecaseList = new List<string>();
            List<string> uppercaseList = new List<string>();
            List<string> mixedList = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isAllLowerCase = true;
                bool isAllUpperCase = true;

                string word = arr[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if(char.IsLower(word[j]))
                    {
                        isAllUpperCase = false;
                    }
                    else if(char.IsUpper(word[j]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllUpperCase = false;
                        isAllLowerCase = false;
                    }
                }

                if (isAllLowerCase)
                {
                    lowecaseList.Add(word);
                }
                else if (isAllUpperCase)
                {
                    uppercaseList.Add(word);
                }
                else
                {
                    mixedList.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowecaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseList));
        }
    }
}
