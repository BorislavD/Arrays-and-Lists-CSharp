using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<int> firstInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            int shortest = int.MaxValue;

            for (int i = 0; i < firstInt.Count; i++)
            {
                int currentLength = (Math.Abs(firstInt[i]).ToString().Length);
                if (currentLength < shortest)
                {
                    shortest = currentLength;
                }
            }

            for (int i = 0; i < secondInt.Count; i++)
            {
                int currentLength = (Math.Abs(secondInt[i]).ToString().Length);
                if (currentLength < shortest)
                {
                    shortest = currentLength;
                }
            }

            for (int i = 0; i < firstInt.Count; i++)
            {
                if (Math.Abs(firstInt[i]).ToString().Length > shortest)
                {
                    firstInt.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < secondInt.Count; i++)
            {
                if (Math.Abs(secondInt[i]).ToString().Length > shortest)
                {
                    secondInt.RemoveAt(i);
                    i--;
                }
            }

            int shortestList = Math.Min(firstInt.Count, secondInt.Count);
            int longestList = Math.Max(firstInt.Count, secondInt.Count);
            List<int> result = new List<int>();

            if (firstInt.Count == secondInt.Count)
            {
                for (int i = 0; i < shortestList; i++)
                {
                    result.Insert(i * 2, secondInt[i]);
                    result.Insert(i * 2 + 1, firstInt[i]);

                }
            }
            else if (firstInt.Count > secondInt.Count)
            {
                for (int i = 0; i < shortestList; i++)
                {
                    result.Insert(i * 2, secondInt[i]);
                    result.Insert(i * 2 + 1, firstInt[i]);
                }

                for (int i = secondInt.Count; i < firstInt.Count; i++)
                {
                    char[] ch = firstInt[i].ToString().ToCharArray();
                    result.Add(int.Parse(string.Join("", ch)));
                }
            }
            else
            {
                for (int i = 0; i < shortestList; i++)
                {
                    result.Insert(i * 2, secondInt[i]);
                    result.Insert(i * 2 + 1, firstInt[i]);
                }

                for (int i = firstInt.Count; i < secondInt.Count; i++)
                {
                    char[] ch = secondInt[i].ToString().ToCharArray();
                    result.Add(int.Parse(string.Join("", ch)));
                }
            }

            Console.WriteLine(string.Join(" ", result));


        }

    }

}


